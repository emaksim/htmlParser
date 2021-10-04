using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;

namespace HTMLParser.Core.Habr
{
	internal class HabrParser : IParser<IEnumerable<HabrItem>>
	{
		IEnumerable<HabrItem> IParser<IEnumerable<HabrItem>>.Parse(IHtmlDocument document)
		{
			var list = new List<HabrItem>();
			var items = document.QuerySelectorAll("a").Where(items => items.ClassName != null && items.ClassName.Contains("tm-article-snippet__title-link"));

			foreach (var item in items)
			{
				var index = item.OuterHtml.IndexOf("/ru/post") + 9; // 9 - количество /ru/post/
				var postNumber = item.OuterHtml.Substring(index, 100).Split('/')[0]; // Узкое место
				list.Add(new HabrItem(item.TextContent, $"/ru/post/{postNumber}/"));
			}
			return list;
		}
	}
}