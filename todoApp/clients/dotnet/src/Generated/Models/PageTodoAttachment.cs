// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Todo.Models
{
    /// <summary> The PageTodoAttachment. </summary>
    public partial class PageTodoAttachment
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal PageTodoAttachment(IEnumerable<TodoAttachment> items)
        {
            Items = items.ToList();
        }

        internal PageTodoAttachment(IList<TodoAttachment> items, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Items = items;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> Gets the Items. </summary>
        public IList<TodoAttachment> Items { get; }
    }
}