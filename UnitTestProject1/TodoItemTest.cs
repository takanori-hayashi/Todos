using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todos.Tests
{
    [TestClass]
    public class TodoItemTest
    {
        [TestMethod]
        public void titleというタイトルを返す()
        {
            // 準備
            var todoItem = new TodoItem("title");
            // 実行
            var title = todoItem.Title;
            // 検証
            Assert.AreEqual("title", title);
        }

        [TestMethod]
        public void タイトルというタイトルを返す()
        {
            // 準備
            var todoItem = new TodoItem("タイトル");
            // 実行
            var title = todoItem.Title;
            // 検証
            Assert.AreEqual("タイトル", title);
        }
    }
}
