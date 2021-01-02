using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeewoHelper.Features
{
    public class Updater
    {
        public ReleaseInfo Release { get; private set; }

        public ReleaseInfo Prerelease { get; private set; }

        public async Task GetInfo()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.50 Safari/537.36 Edg/88.0.705.29");

            var res = await client.GetAsync(Constants.ReleasesLink);
            res.EnsureSuccessStatusCode();

            string content = await res.Content.ReadAsStringAsync();
            var infos = JsonConvert.DeserializeObject<ReleaseInfo[]>(content);

            Release = infos.FirstOrDefault(x => !x.IsPrerelese);
            Prerelease = infos.FirstOrDefault(x => x.IsPrerelese);
        }

        public Updater()
        {
        }
    }
}
