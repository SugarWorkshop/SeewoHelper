using SeewoHelper.Utilities;
using Sunny.UI;
using System;
using System.Collections.Generic;

namespace SeewoHelper.Forms
{
    public partial class KeywordGettingWindow : UIForm, IReturnableForm<Keyword, Keyword>
    {
        private Keyword _keyword = null;

        private static readonly Dictionary<KeywordMatchingWay, string> _keywordMatchingWayDictionary = new Dictionary<KeywordMatchingWay, string>()
        {
            [KeywordMatchingWay.Normal] = "正常",
            [KeywordMatchingWay.CaseInsensitive] = "不区分大小写",
            [KeywordMatchingWay.Regex] = "正则表达式"
        };

        public KeywordGettingWindow()
        {
            InitializeComponent();
            Program.FormStyleController.Initialize(this);
        }

        public Keyword GetResult(Keyword keyword = null)
        {
            if (keyword == null)
            {
                comboBoxMatchingWay.SelectedIndex = 0;
            }
            else
            {
                _keyword = keyword;
                textBoxPattern.Text = keyword.Pattern;
                comboBoxMatchingWay.Text = _keywordMatchingWayDictionary[keyword.MatchingWay];
            }

            ShowDialog();
            return _keyword;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPattern.Text) || comboBoxMatchingWay.SelectedIndex == -1)
            {
                MessageBoxUtilities.ShowError("内容不可为空！");
            }
            else
            {
                _keyword = new Keyword(textBoxPattern.Text, _keywordMatchingWayDictionary.GetKey(comboBoxMatchingWay.Text));
                Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KeywordGettingWindow_Load(object sender, EventArgs e)
        {
            Program.Logger.Info($"开始加载 {nameof(KeywordGettingWindow)}");
            Program.Logger.Info($"{nameof(KeywordGettingWindow)} 加载完成");
        }
    }
}
