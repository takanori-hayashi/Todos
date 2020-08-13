using System;
using System.Collections.Generic;
using System.Text;

namespace Todos
{
    public class TodoItem
    {
        public string Title { get; }

        public bool IsCompleted;

        public TodoItem(string title)
        {
            Title = title;
        }

        public void ToggleCompleted()
        {
            IsCompleted = !IsCompleted;
        }
    }
}
