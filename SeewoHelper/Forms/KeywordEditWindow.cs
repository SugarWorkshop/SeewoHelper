using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class KeywordEditWindow : Form, IReturnableForm<List<string>, List<string>>
    {
        private List<string> _keywords;

        public KeywordEditWindow()
        {
            InitializeComponent();
        }

        public List<string> GetInfo(List<string> list)
        {
            _keywords = list;
            listViewKeywords.Items.AddRange(list.Select(x => new ListViewItem(x)).ToArray());
            ShowDialog();

            return _keywords;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            _keywords = listViewKeywords.Items.ToList().Select(x => x.Text).ToList();
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string keyword = new InputBoxWindow().GetInfo("添加关键词：", Text);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                listViewKeywords.Items.Add(keyword);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            listViewKeywords.RemoveSelectedItems();
        }

        private void ListViewKeywords_DoubleClick(object sender, EventArgs e)
        {
            var item = listViewKeywords.SelectedItems.ToList().Single();
            string keyword = new InputBoxWindow().GetInfo("修改关键词：", Text, item.Text);

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                item.Text = keyword;
            }
        }
    }
}
