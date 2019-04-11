using System;
namespace dp.Structural.Proxy
{
    public class BookParser : IBookParser
    {
        public BookParser()
        {
        }

        public void ParseBook(string book)
        {
            //Realy long and expensive operation
        }
    }
}
