using System.Diagnostics;
using System.Linq;

namespace SeewoHelper.Utilities
{
    /// <summary>
    /// 提供 <see cref="System"/> 命名空间下相关的方法
    /// </summary>
    public static class SystemUtilities
    {
        /// <summary>
        /// 判断一个或多个字符串是否为 <see langword="null"/> 或为空或仅存在空格符
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(params string[] strs) => strs.Any(string.IsNullOrWhiteSpace);

        /// <summary>
        /// 反转 <see cref="bool"/>
        /// </summary>
        /// <param name="isReverse">是否反转</param>
        /// <param name="b">指定 bool</param>
        /// <returns></returns>
        public static bool ReverseBool(bool isReverse, bool b) => isReverse ? !b : b;

        public static void RunCmdProcess(string str)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.WriteLine(str);
            process.StandardInput.WriteLine("exit");
            process.WaitForExit();
            process.Close();
        }
    }
}
