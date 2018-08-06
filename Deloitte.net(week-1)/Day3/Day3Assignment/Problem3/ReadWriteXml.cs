using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Problem3
{
    public class ReadWriteXml
    {
        List<PartsInfo> Parts = new List<PartsInfo>();
        public  ReadWriteXml()
        {
          Parts.Add (new PartsInfo {Item="Motherboard",Manufacture="ASUS",Model="P3B-F",Cost=123.15 });
          Parts.Add(new PartsInfo { Item = "VideoCard", Manufacture = "ATI", Model = "All-in-Wonder Pro", Cost = 160.00 });
            Parts.Add(new PartsInfo { Item = "SoundCard", Manufacture = "Creative Labs", Model = "Sound Blaster Live", Cost = 80.00 });
            Parts.Add(new PartsInfo { Item = "inch monitor", Manufacture = "LG Electronics", Model = "995E", Cost = 290.00 });
        }
        public void Write()
        {
            XmlWriter xml = XmlWriter.Create(@"c:\Files\PartsInfo.xml");
            xml.WriteStartDocument();
            xml.WriteStartElement("PARTS");
            
            foreach(var i in Parts )
            {
                xml.WriteStartElement("PART");
                xml.WriteElementString("ITEM", i.Item);
                xml.WriteElementString("MANUFACTURER", i.Item);
                xml.WriteElementString("MODEL", i.Model);
                xml.WriteElementString("COST", i.Cost.ToString());
                xml.WriteEndElement();//CLOSES PART

            }

            xml.WriteEndElement();
            xml.WriteEndDocument();
            xml.Close();
            Console.WriteLine("xmL Created");

        }

        public void read()
        {
            XElement xe  = XElement.Load(@"c:\Files\PartsInfo.xml");
            var data = xe.Elements();

            foreach (var i in data)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("******************");
        }
    }
}
