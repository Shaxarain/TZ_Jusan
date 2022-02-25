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
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<T>));
                using (FileStream fs = new FileStream($"{typeof(T).Name}.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, a);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<T> ReadXML<T>(List<T> a)
        {
            try
            {
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
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
            

            var sortedFiz = from f in test1
                            orderby f.Surname, f.Name, f.Midname
                            select f;
            foreach (var sf in sortedFiz)
            {
                Console.WriteLine($"Sorted Fizlica: \n{sf.Id} | {sf.Idn} | {sf.CreateDate} | {sf.CreateAuthor} | {sf.EditDate} | {sf.EditAuthor} | " +
                $"{sf.Address} | {sf.Surname} | {sf.Name} | {sf.Midname}");
            }
            Console.ReadLine();
        }
    }
}
