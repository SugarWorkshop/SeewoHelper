using SeewoHelper.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class SubjectStorageInfoGettingWindow : Form, IReturnableForm<SubjectStorageInfo>
    {
        private SubjectStorageInfo _subjectStorageInfo = null;
        private List<string> _keywords = new List<string>();

        public SubjectStorageInfoGettingWindow()
        {
            InitializeComponent();
        }

        public SubjectStorageInfo GetInfo()
        {
            ShowDialog();
            return _subjectStorageInfo;
        }

        private void ButtonGettingPath_Click(object sender, EventArgs e)
        {
            textBoxPath.Text = FolderBrowserDialogUtilities.GetFilePath();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (StringUtilities.IsNullOrWhiteSpace(textBoxName.Text, textBoxPath.Text) || !_keywords.Any())
            {
                MessageBox.Show("请输入内容！");
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
            _keywords = new KeywordEditWindow().GetInfo(_keywords);
            textBoxKeywords.Text = string.Join(", ", _keywords);
        }
    }
}
