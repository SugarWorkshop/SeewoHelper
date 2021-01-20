using SeewoHelper.Utilities;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeewoHelper.Forms
{
    public partial class SubjectStorageInfoGettingWindow : UIForm, IReturnableForm<SubjectStorageInfo, SubjectStorageInfo>
    {
        private SubjectStorageInfo _subjectStorageInfo = null;
        private List<Keyword> _keywords = new List<Keyword>();

        public SubjectStorageInfoGettingWindow()
        {
            InitializeComponent();
            Program.FormStyleController.Initialize(this);
        }

        public SubjectStorageInfo GetResult(SubjectStorageInfo info = null)
        {
            if (info != null)
            {
                textBoxName.Text = info.Name;
                textBoxPath.Text = info.Path;
                _keywords = info.Keywords;
                textBoxKeywords.Text = string.Join(", ", info.Keywords.Select(x => x.Pattern));
            }

            ShowDialog();
            return _subjectStorageInfo;
        }

        private void ButtonGettingPath_Click(object sender, EventArgs e)
        {
            textBoxPath.Text = FolderBrowserDialogUtilities.GetFilePath();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (SystemUtilities.IsNullOrWhiteSpace(textBoxName.Text, textBoxPath.Text) || !_keywords.Any())
            {
                MessageBox.ShowError("内容不可为空！");
            }
            else if (!(IOUtilities.IsProperPath(textBoxPath.Text) && IOUtilities.GetPathType(textBoxPath.Text, true) == PathType.Directionary))
            {
                MessageBox.ShowError("路径不合法！");
            }
            else
            {
                _subjectStorageInfo = new SubjectStorageInfo(textBoxName.Text, textBoxPath.Text, _keywords);
                Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonEditKeyword_Click(object sender, EventArgs e)
        {
            _keywords = new KeywordEditWindow().GetResult(_keywords);
            textBoxKeywords.Text = string.Join(", ", _keywords.Select(x => x.Pattern));
        }

        private void SubjectStorageInfoGettingWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Add("开始加载 SubjectStorageInfoGettingWindow");
            Program.Logger.Add("SubjectStorageInfoGettingWindow 加载完成");
        }
    }
}
