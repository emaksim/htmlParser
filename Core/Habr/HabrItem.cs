namespace HTMLParser.Core.Habr
{
	public class HabrItem : BaseItem
	{
		public HabrItem(string textContent, string link)
		{
			TextContent = textContent;
			Link = $"https://habr.com{link}"; // ToEdit
		}
	}
}