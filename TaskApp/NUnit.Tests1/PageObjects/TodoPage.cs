using System;
using Xamarin.UITest.Queries;

namespace NUnit.Tests1.PageObjects
{
    public class TodoPage
    {
        public Func<AppQuery, AppQuery> FrameLayout => x => x.Id("content");
        public Func<AppQuery, AppQuery> AddTaskButton => x => x.Id("AddButton");
        public Func<AppQuery, AppQuery> TaskNameInput => x => x.Id("NameText");
    }
}