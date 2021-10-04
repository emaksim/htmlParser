using System.Net.Http;
using System.Threading.Tasks;

namespace HTMLParser.Core
{
	class HtmlLoader
	{
		readonly HttpClient client;
		readonly string url;

		public HtmlLoader(IParserSettings settings)
		{
			client = new HttpClient();
			url = $"{settings.BaseUrl}/{settings.Prefix}CurrentId/";
		}

		public async Task<string> GetSourceByPageId(int ID)
		{
			var currentUrl = url.Replace("CurrentId", ID.ToString());
			var response = await client.GetAsync(currentUrl);
			string source = "";

			if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				source = await response.Content.ReadAsStringAsync();
			}
			return source;
		}
	}
}