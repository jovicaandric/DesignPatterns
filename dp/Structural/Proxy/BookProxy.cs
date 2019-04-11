using System;
namespace dp.Structural.Proxy
{
    public class BookProxy : IBookParser
    {
        private BookParser _bookParser;
        private string book;

        public BookProxy(string book)
        {
            this.book = book;
        }

        public int GetNumberOfPages()
        {
            //since init of book parser is expensive we call it only if we must
            if (_bookParser == null)
                _bookParser = new BookParser(book);

            return _bookParser.GetNumberOfPages();
        }
    }
}
