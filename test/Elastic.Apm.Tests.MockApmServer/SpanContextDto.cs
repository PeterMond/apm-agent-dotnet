using System.Collections.Generic;
using Elastic.Apm.Api;
using Elastic.Apm.Helpers;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global


namespace Elastic.Apm.Tests.MockApmServer
{
	internal class SpanContextDto: IDto
	{
		public Database Db { get; set; }
		public Http Http { get; set; }
		public Dictionary<string, string> Labels { get; set; }

		public override string ToString() => new ToStringBuilder(nameof(SpanContextDto))
		{
			{ "Db", Db },
			{ "Http", Http },
			{ "Labels", Labels },
		}.ToString();

		public void AssertValid()
		{
			Db?.AssertValid();
			Http?.AssertValid();
			Labels?.LabelsAssertValid();
		}
	}
}