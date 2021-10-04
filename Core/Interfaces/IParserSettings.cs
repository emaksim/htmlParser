namespace HTMLParser.Core
{
	internal interface IParserSettings
	{
		string BaseUrl { get; set; }
		string Prefix { get; set; }
		int StarPoint { get; set; }
		int EndPoint { get; set; }
	}
}