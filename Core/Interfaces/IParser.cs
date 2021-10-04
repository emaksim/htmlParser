using AngleSharp.Html.Dom;

namespace HTMLParser.Core
{
	internal interface IParser<T> where T : class
	{
		T Parse(IHtmlDocument document);
	}
}