namespace HTMLParser.Core.Habr
{
	public class HabrSettings : IParserSettings
	{
		public string BaseUrl { get; set; } = "https://habr.com";
		public string Prefix { get; set; } = "ru/all/page";
		public int StarPoint { get; set; }
		public int EndPoint { get; set; }

		public HabrSettings(int startPont, int endPoint)
		{
			StarPoint = startPont;
			EndPoint = endPoint;
		}
	}
}