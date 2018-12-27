using NUnit.Framework;
using NUnit.Tests1.PageObjects;
using Xamarin.UITest;

namespace NUnit.Tests1
{
    [TestFixture(Platform.Android)]
    public class TestClass
    {
        private IApp app { get; set; }
        private Platform platform { get; set; }

        private TodoPage page;

        public TestClass(Platform platform)
        {
            this.platform = platform;
            page = new TodoPage();
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void TestMethod()
        {
            app.Tap(page.AddTaskButton);
            app.WaitForElement(page.FrameLayout);
            app.Tap(page.TaskNameInput);
            app.EnterText("First task");
            app.Repl();
            Assert.Pass("Your first passing test");
        }
    }
}