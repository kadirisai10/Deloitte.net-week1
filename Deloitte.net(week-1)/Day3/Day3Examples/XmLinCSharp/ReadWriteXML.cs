using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmLinCSharp
{
    class ReadWriteXML
    {
        List<BookInfo> blist = new List<BookInfo>();

        public ReadWriteXML()
        {
            blist.Add(new BookInfo { BookID = 1, Title = "Around the world in 70days", Genre = "Fiction", Price = 400 });
            blist.Add(new BookInfo { BookID = 22, Title = "malgudi Days", Genre = "Story", Price = 200 });
            blist.Add(new BookInfo { BookID = 3, Title = "c Programming", Genre = "Technology", Price = 250 });

        }

        public void WriteXML()
        {
            XmlWriter w = XmlWriter.Create(@"c:\Files\BookInfo.xml");
            w.WriteStartDocument();
            w.WriteStartElement("BookInfo");
            foreach(var i in blist)
            {
                w.WriteStartElement("Books");
                w.WriteAttributeString("BookId", i.BookID.ToString());
                w.WriteStartElement("Description");
                w.WriteElementString("Title", i.Title);
                w.WriteElementString("category", i.Genre);
                w.WriteEndElement();//closes description
                w.WriteElementString("Price", i.Price.ToString());
                w.WriteEndElement();//closes books
            }
            w.WriteEndElement();//closes book info
            w.WriteEndDocument();
            w.Close();
            Console.WriteLine("XML Created");
        }

        public void ReadXML()
        {
            XElement xe = XElement.Load(@"c:\Files\BookInfo.xml");
            var data = xe.Elements();//retrive all the elements

            foreach(var d in data)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("*********************");

            //read element data
           
            foreach(var d in data)
                Console.WriteLine(d.Element("Description").Element("Title").Value+" "+d.Element("Price").Value);
            Console.WriteLine("*********************");

            var data2 = from t in xe.Elements("Books")
                        where (int)t.Element("Price") > 200
                        select t;
            foreach(var d in data2)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("*********************");
        }
    }
}
