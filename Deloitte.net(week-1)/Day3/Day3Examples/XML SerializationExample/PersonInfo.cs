using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_SerializationExample
{
    [Serializable]
    [XmlRoot]
   public class PersonInfo
    {
        [XmlElement]
        public string name { get; set; }

        [XmlElement]
        public int age { get; set; }

        public PersonInfo(string n,int a)
        {
            name = n;
            age = a;
        }
        public PersonInfo()
        {

        }
        public void ShowData()
        {
            Console.WriteLine("name:"+name);
            Console.WriteLine("age:"+age);
        } 
    }
}
