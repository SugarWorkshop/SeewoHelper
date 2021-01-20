using System;
using System.Diagnostics;

namespace SeewoHelper.Utilities
{
    /// <summary>
    /// 提供 <see cref="System.Net"/> 命名空间下相关的方法
    /// </summary>
    public static class NetUtilities
    {
        /// <summary>
        /// 打开指定地址的网页
        /// </summary>
        /// <param name="url"></param>
        public static void Start(string url)
        {
            var uriBuilder = new UriBuilder(url);

            if (uriBuilder.Scheme == Uri.UriSchemeHttp || uriBuilder.Scheme == Uri.UriSchemeHttps)
            {
                Process.Start("explorer.exe", url); // 使用 explorer.exe 调用默认浏览器打开对应地址
            }
            else
            {
                throw new UriFormatException();
            }
        }
    }
}
