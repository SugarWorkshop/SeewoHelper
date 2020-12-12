using SeewoHelper.Utilities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class SubjectStorageInfoGettingWindow : Form
    {
        private SubjectStorageInfo _subjectStorageInfo = null;

        public SubjectStorageInfoGettingWindow()
        {
            InitializeComponent();
        }

        public static SubjectStorageInfo GetInfo()
        {
            var form = new SubjectStorageInfoGettingWindow();
            form.ShowDialog();
            return form._subjectStorageInfo;
        }

        private void ButtonGettingPath_Click(object sender, EventArgs e)
        {
            textBoxPath.Text = FolderBrowserDialogUtilities.GetFilePath();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (StringUtilities.IsNullOrWhiteSpace(textBoxName.Text, textBoxPath.Text, textBoxKeywords.Text))
                MessageBox.Show("请输入内容！");
            else
            {
                _subjectStorageInfo = new SubjectStorageInfo(textBoxName.Text, textBoxPath.Text, textBoxKeywords.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim()).ToList());
                Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonEditKeyword_Click(object sender, EventArgs e)
        {
            new KeywordWindow().ShowDialog();
        }
    }
}
