// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Todo.Models
{
    /// <summary> The TodoPage. </summary>
    public partial class TodoPage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal TodoPage(IEnumerable<TodoItem> items, TodoPagePagination pagination)
        {
            Items = items.ToList();
            Pagination = pagination;
        }

        internal TodoPage(IList<TodoItem> items, TodoPagePagination pagination, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Items = items;
            Pagination = pagination;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The items in the page. </summary>
        public IList<TodoItem> Items { get; }

        /// <summary> Gets the Pagination. </summary>
        public TodoPagePagination Pagination { get; }
    }
}