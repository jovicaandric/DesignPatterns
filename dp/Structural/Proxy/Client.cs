using System;
namespace dp.Structural.Proxy
{
    public class Client
    {
        string book = "Complete book represented as a string";
        IBookParser parser;
        public Client()
        {
            this.parser = new BookProxy(book);
            //to get number of pages we call proxy instead of real BookParser
           Console.WriteLine(parser.GetNumberOfPages());
            
        }

    }
}
