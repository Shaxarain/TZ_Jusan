using System;
using System.Linq;

namespace TZ_Jusan.Models
{
    [Serializable]
    public class FizLico : ContrAgent, IPrintable
    {
        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Any(char.IsNumber))
                {
                    Console.WriteLine($"Incorrectly entered surname with ID: {this.Id}");
                }
                else
                {
                    _surname = value;
                }
            }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Any(char.IsNumber))
                {
                    Console.WriteLine($"Incorrectly entered name with ID: {this.Id}");
                }
                else
                {
                    _name = value;
                }
            }
        }
        private string _midname;
        public string Midname
        {
            get { return _midname; }
            set
            {
                if (value.Any(char.IsNumber))
                {
                    Console.WriteLine($"Incorrectly entered middle name with ID: {this.Id}");
                }
                else
                {
                    _midname = value;
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"{Id} | {Idn} | {CreateDate} | {CreateAuthor} | {EditDate} | {EditAuthor} | " +
                $"{Address} | {Surname} | {Name} | {Midname}");
        }
        public FizLico() { }
        public FizLico(int id, string idn, DateTime createDate, string createAuthor, DateTime editDate,
            string editAuthor, string address, string surname, string name, string midname)
            : base (id, idn, createDate, createAuthor, editDate, editAuthor, address)
        {
            _surname = surname;
            _name = name;
            _midname = midname;
        }
    }
}
