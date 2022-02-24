using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TZ_Jusan.Models;
using TZ_Jusan;
using System.Reflection;

namespace TZ_Jusan
{
    class Program
    {
        public static void WriteXML<T>(List<T> a)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream($"{typeof(T).Name}.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, a);
            }
        }

        public static List<T> ReadXML<T>(List<T> a)
        {
            Type t = typeof(T);
            FieldInfo[] fields = t.GetFields(BindingFlags.Public);
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream($"{typeof(T).Name}.xml", FileMode.OpenOrCreate))
            {
                List<T> people = formatter.Deserialize(fs) as List<T>;

                if (people != null)
                {
                    return people;
                }
                return null;
            }
        }
        static void Main(string[] args)
        {
            Enter enterData = new Enter();
            WriteXML<FizLico>(enterData.fizLica);
            var test1 = ReadXML<FizLico>(enterData.fizLica);
            foreach(var t in test1)
            {
                t.Print();
            }
            WriteXML<UrLico>(enterData.urLica);
            var test2 = ReadXML<UrLico>(enterData.urLica);
            foreach (var t in test2)
            {
                t.Print();
            }
            Console.ReadLine();
        }
    }
}
