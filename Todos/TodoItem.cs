using System;
using System.Collections.Generic;
using System.Text;

namespace Todos
{
    public class TodoItem
    {
        public string Title { get; }

        public TodoItem(string title)
        {
            Title = title;
        }
    }
}
