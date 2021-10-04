﻿using AngleSharp.Html.Parser;
using System;

namespace HTMLParser.Core
{
	class ParserWorker<T> where T : class
	{
		IParser<T> parser;
		IParserSettings parserSettings;
		HtmlLoader htmlLoader;
		bool isActive;

		#region Properties 
		public bool IsActive
		{
			get { return isActive; }
		}

		public IParser<T> Parser
		{
			get { return parser; }
			set { parser = value; }
		}
		public IParserSettings ParserSettings
		{
			get { return parserSettings; }
			set
			{
				parserSettings = value;
				htmlLoader = new HtmlLoader(value);
			}
		}

		#endregion

		public event Action<object, T> OnNewData;
		public event Action<object> OnCompleted;

		public ParserWorker(IParser<T> parser)
		{
			this.parser = parser;
		}

		public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
		{
			this.parserSettings = parserSettings;
		}

		public void Start()
		{
			isActive = true;
			Worker();
		}

		public void Abort()
		{
			OnCompleted?.Invoke(this);
			isActive = false;
		}

		private async void Worker()
		{
			for (int i = parserSettings.StarPoint; i < parserSettings.EndPoint; i++)
			{
				if (!isActive)
				{
					OnCompleted?.Invoke(this);
					return;
				}

				var source = await htmlLoader.GetSourceByPageId(i);
				var domParser = new HtmlParser();
				var document = await domParser.ParseDocumentAsync(source);
				var result = parser.Parse(document);

				OnNewData?.Invoke(this, result);
			}

			OnCompleted?.Invoke(this);
			isActive = false;
		}
	}
}