using EvernoteSDK;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeywordFinder
{
    public partial class Form1 : Form
    {
        public class EvernoteInfo
        {
            public ENNoteRef noteRef;
            public string title;
            public string textContent;
        }

        public Form1()
        {
            InitializeComponent();

            dgvEvernoteApiKey.Rows.Add("S=s1:U=968f6:E=18511093430:C=17db9580830:P=1cd:A=en-devtoken:V=2:H=9d15dc7a7053c86a49918011f027574e");
        }

        private void btnKeywordSearch_Click(object sender, EventArgs e)
        {
            // 빈값이면 전체 조회
            // 빈값 조회 하지 않으려면 주석 해제
            //if (string.IsNullOrEmpty(txtKeyword.Text))
            //{
            //    MessageBox.Show("키워드를 입력하세요.", "[알림]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtKeyword.Focus();
            //    return;
            //}

            // 그리드 뷰 초기화
            dgvFindResult.Rows.Clear();

            // 크롬 북마크 체크
            var bookmarks = findChromeBookmarks(txtKeyword.Text);

            foreach (var bookmark in bookmarks)
                dgvFindResult.Rows.Add("Bookmark", bookmark.name, bookmark.url);

            // 에버노트 체크
            foreach (DataGridViewRow row in dgvEvernoteApiKey.Rows)
            {
                string token = row.Cells["colToken"].Value?.ToString();

                if (string.IsNullOrEmpty(token))
                    continue;

                var notes = findEverNoteKeyword(token, txtKeyword.Text);

                foreach (var note in notes)
                    dgvFindResult.Rows.Add("Evernote", note.title, note.textContent);
            }
        }

        private List<ChromeBookmark.Children> findChromeBookmarks(string keyword)
        {
            List<ChromeBookmark.Children> findResult = new List<ChromeBookmark.Children>();

            string path = @"C:\Users\whhan\AppData\Local\Google\Chrome\User Data\Default\Bookmarks";
            if (System.IO.File.Exists(path))
            {
                string bookmarkJson = System.IO.File.ReadAllText(path);

                ChromeBookmark bookmarks = JsonConvert.DeserializeObject<ChromeBookmark>(bookmarkJson);

                foreach (var children in bookmarks.roots.bookmarkBar.childrens)
                {
                    string keywordLower = keyword.ToLower();
                    string name = children.name.ToLower();
                    string url = children.url.ToLower();

                    if (name.Contains(keywordLower) || url.Contains(keywordLower))
                        findResult.Add(children);
                }
            }

            return findResult;
        }

        private List<EvernoteInfo> findEverNoteKeyword(string token, string keyword)
        {
            // 에버노트 API Key 설정.
            // https://dev.evernote.com/doc/ sandbox ke 발급 URL

            // api key 발급은 sandbox (test) 서버로 1차 발급 받고,
            // https://sandbox.evernote.com/ 로 접속하여 developer token 을 발급 받는다.

            // 실제 개발은 developer token 으로 개발 진행하며, 개발 완료 후 api key (key + secret) 를 통하여
            // https://dev.evernote.com/support/ 방문하여 [activate an API Key] 를 통해서 production key 를 발급 받아야 함

            // production key 를 발급 받으면 아래 함수로 production key, secret 로 요청하여 사용 할 수 있다.
            // ENSession.SetSharedSessionConsumerKey(key, secret);

            // notestore URL 은 고정
            ENSession.SetSharedSessionDeveloperToken(token, "https://sandbox.evernote.com/shard/s1/notestore");

            // 에버노트 API Key 설정 이후 정상 승인 되었는지 체크
            ENSession.SharedSession.AuthenticateToEvernote();
            if (!ENSession.SharedSession.IsAuthenticated)
            {
                MessageBox.Show($"에버노트 인증이 실패되었습니다.\token: {token}", "[알림]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // 에버노트 입력 노트 리스트 가져오기
            var notebooks = ENSession.SharedSession.ListNotebooks();

            List<EvernoteInfo> findNotes = new List<EvernoteInfo>();
            foreach (var notebook in notebooks)
            {
                // 전체 노트 조회
                var notes = ENSession.SharedSession.FindNotes(ENNoteSearch.NoteSearch(""), notebook, ENSession.SearchScope.All, ENSession.SortOrder.RecentlyUpdated, 500);

                foreach (var note in notes)
                {
                    var noteDetail = ENSession.SharedSession.DownloadNote(note.NoteRef);

                    if (noteDetail.Title.Contains(txtKeyword.Text) || noteDetail.TextContent.Contains(txtKeyword.Text))
                        findNotes.Add(new EvernoteInfo() { noteRef = note.NoteRef, title = noteDetail.Title, textContent = noteDetail.TextContent });
                }
            }

            return findNotes;
        }

        private void createNote(string token, string title, string content)
        {
            // notestore URL 은 고정
            ENSession.SetSharedSessionDeveloperToken(token, "https://sandbox.evernote.com/shard/s1/notestore");

            // 에버노트 API Key 설정 이후 정상 승인 되었는지 체크
            ENSession.SharedSession.AuthenticateToEvernote();
            if (!ENSession.SharedSession.IsAuthenticated)
            {
                MessageBox.Show($"에버노트 인증이 실패되었습니다.\token: {token}", "[알림]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 에버노트 노트 추가
            ENNote myPlainNote = new ENNote();

            myPlainNote.Title = title;
            myPlainNote.Content = ENNoteContent.NoteContentWithString(content);

            ENSession.SharedSession.UploadNote(myPlainNote, null);

            MessageBox.Show($"에버노트 노트가 등록되었습니다.", "[알림]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            // 등록 된 Develop Key 모두 노트 등록
            foreach (DataGridViewRow row in dgvEvernoteApiKey.Rows)
            {
                string token = row.Cells["colToken"].Value?.ToString();

                if (string.IsNullOrEmpty(token))
                    continue;

                createNote(token, txttitle.Text, txtcontent.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
