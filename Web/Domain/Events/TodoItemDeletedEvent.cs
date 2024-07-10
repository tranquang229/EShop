using Domain.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Events
{
    public class TodoItemDeletedEvent : BaseEvent
    {
        public TodoItemDeletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }

}
