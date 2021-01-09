using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace SeewoHelper.Features
{
    /// <summary>
    /// 定义更新器
    /// </summary>
    public class Updater
    {
        /// <summary>
        /// 最新 Release 信息
        /// </summary>
        public ReleaseInfo Release { get; private set; }

        /// <summary>
        /// 最新 Pre-Release 信息
        /// </summary>
        public ReleaseInfo Prerelease { get; private set; }

        public async Task GetInfo()
        {
            Program.Logger.Add("开始获取 Release 信息");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.50 Safari/537.36 Edge/88.0.705.29"); // 添加 User-Agent 头信息

            var res = await client.GetAsync(Constants.ReleasesLink); // 获取信息
            res.EnsureSuccessStatusCode(); // 当获取状态码为失败时抛出异常

            string content = await res.Content.ReadAsStringAsync(); // 读取内容
            var infos = JsonSerializer.Deserialize<ReleaseInfo[]>(content); // 序列化信息

            Release = infos.FirstOrDefault(x => !x.IsPrerelese); // 赋值 Release 为符合 !IsPrerelease 第一个元素
            Prerelease = infos.FirstOrDefault(x => x.IsPrerelese); // 赋值 Prerelease 为符合 IsPrerelease 第一个元素
            Program.Logger.Add("Release 信息获取完成");
        }

        public Updater()
        {
        }
    }
}
