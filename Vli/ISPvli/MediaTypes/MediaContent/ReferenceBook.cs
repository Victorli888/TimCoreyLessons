using System;

namespace MediaTypes
{
    /// <summary>
    /// A Reference Book such like an encyclopedia or a World Atlas, These are things in our library but not something
    /// you would checkout.
    /// </summary>
    public class ReferenceBook: IBook
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}