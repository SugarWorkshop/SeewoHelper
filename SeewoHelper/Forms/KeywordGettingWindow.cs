using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SeewoHelper.Forms
{
    public partial class KeywordGettingWindow : Form, IReturnableForm<Keyword, Keyword>
    {
        private Keyword _keyword = null;

        private static readonly Dictionary<KeywordMatchingWay, string> KeywordMatchingWayDictionary = new Dictionary<KeywordMatchingWay, string>()
        {
            [KeywordMatchingWay.Normal] = "正常",
            [KeywordMatchingWay.CaseInsensitive] = "不区分大小写",
            [KeywordMatchingWay.Regex] = "正则匹配"
        };

        public KeywordGettingWindow()
        {
            InitializeComponent();
        }

        public Keyword GetInfo(Keyword keyword = null)
        {
            if (keyword != null)
            {
                _keyword = keyword;
                textBoxPattern.Text = keyword.Pattern;
                comboBoxMatchingWay.SelectedItem = KeywordMatchingWayDictionary[keyword.MatchingWay];
            }

            ShowDialog();
            return _keyword;
        }

        private void KeywordGettingWindow_Load(object sender, EventArgs e)
        {
            comboBoxMatchingWay.Items.AddRange(KeywordMatchingWayDictionary.Values.ToArray());
            comboBoxMatchingWay.SelectedIndex = 0;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBoxPattern.Text) || comboBoxMatchingWay.SelectedIndex == -1))
            {
                _keyword = new Keyword(textBoxPattern.Text, KeywordMatchingWayDictionary.Where(x => x.Value == (string)comboBoxMatchingWay.SelectedItem).Single().Key);
            }

            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
