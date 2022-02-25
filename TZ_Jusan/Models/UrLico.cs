using System;
using System.Collections.Generic;
using System.Linq;

namespace TZ_Jusan.Models
{
    public class UrLico : ContrAgent, IPrintable
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Any(char.IsNumber))
                {
                    Console.WriteLine("Incorrectly entered surname");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public List<FizLico> staff;

        public void Print()
        {
            Console.WriteLine($"UrLica: \n{Id} | {Idn} | {CreateDate} | {CreateAuthor} | {EditDate} | {EditAuthor} | " +
                $"{Name} | Contacts");
        }
        public UrLico() { }
        public UrLico(int id, string idn, DateTime createDate, string createAuthor, DateTime editDate,
            string editAuthor, string address, string name, List<FizLico> st)
            :base(id, idn, createDate, createAuthor, editDate, editAuthor, address)
        {
            _name = name;
            staff = st;
        }
    }
}
