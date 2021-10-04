using HTMLParser.Core;
using HTMLParser.Core.Habr;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace HTMLParser
{
	public partial class HabrTitleSearch : Form
	{
		ParserWorker<IEnumerable<HabrItem>> parser;
		IEnumerable<HabrItem> HabrItems;
		public HabrTitleSearch()
		{
			InitializeComponent();
			parser = new ParserWorker<IEnumerable<HabrItem>>(new HabrParser());

			progressBar.Minimum = 0;
			progressBar.Maximum = 100;

			parser.OnCompleted += Parser_OnCompleted;
			parser.OnNewData += Parser_OnNewData;
		}

		private void Parser_OnNewData(object arg1, IEnumerable<HabrItem> items)
		{
			HabrItems = items;
			foreach (var item in items)
			{
				ListTitles.Items.Add(item.TextContent);
				progressBar.Value = (ListTitles.Items.Count / items.Count()) * 100;
			}
		}

		private void Parser_OnCompleted(object obj)
		{
			progressBar.Value = 100;
		}

		private void ButtonStart_Click(object sender, EventArgs e)
		{
			parser.ParserSettings = new HabrSettings((int)numericStart.Value, (int)numericEnd.Value);
			parser.Start();
		}

		private void ButtonStop_Click(object sender, EventArgs e)
		{
			parser.Abort();
		}

		private void ListTitles_SelectedIndexChanged(object sender, EventArgs e)
		{
			var item = HabrItems.FirstOrDefault(x => x.TextContent == ListTitles.SelectedItem.ToString());
			Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", item?.Link ?? "https://google.com"); //ToSettings, edit default path
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			progressBar.Value = 0;
			ListTitles.Items.Clear();
			progressBar.Value = 100;
		}
	}
}