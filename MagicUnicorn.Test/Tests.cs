using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace MagicUnicorn.Test
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void AppLaunches()
		{
			app.Screenshot("First screen.");
		}
     
        [Test]
        public void NewTest()
        {
            app.Screenshot("Tapped on view with class: AppCompatButton with id: button2 with text: OK");
            app.Tap(x => x.Text("Press me"));
            app.Screenshot("Tapped on view with class: AppCompatButton with text: Press me");
        }
	}
}

