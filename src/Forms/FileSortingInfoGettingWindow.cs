using SeewoHelper.Utilities;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeewoHelper.Forms
{
    public partial class FileSortingInfoGettingWindow : UIForm, IReturnableForm<FileSortingInfo, FileSortingInfo>
    {
        private FileSortingInfo _subjectStorageInfo = null;
        private List<Keyword> _keywords = new();

        public FileSortingInfoGettingWindow()
        {
            InitializeComponent();
            Program.FormStyleController.Initialize(this);
        }

        public FileSortingInfo GetResult(FileSortingInfo info = null)
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
            textBoxPath.Text = FolderBrowserDialogUtilities.GetFilePath() ?? textBoxPath.Text;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (SystemUtilities.IsNullOrWhiteSpace(textBoxName.Text, textBoxPath.Text) || !_keywords.Any())
            {
                MessageBoxUtilities.ShowError("内容不可为空！");
            }
            else if (!(IOUtilities.IsProperPath(textBoxPath.Text) && IOUtilities.GetPathType(textBoxPath.Text) == PathType.Directionary))
            {
                MessageBoxUtilities.ShowError("路径不合法！");
            }
            else
            {
                _subjectStorageInfo = new FileSortingInfo(textBoxName.Text, textBoxPath.Text, _keywords);
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

        private void FileSortingInfoGettingWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Info($"开始加载 {nameof(FileSortingInfoGettingWindow)}");
            Program.Logger.Info($"{nameof(FileSortingInfoGettingWindow)} 加载完成");
        }
    }
}
