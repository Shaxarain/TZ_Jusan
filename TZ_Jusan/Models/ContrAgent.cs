using System;
using System.Linq;

namespace TZ_Jusan.Models
{
    [Serializable]
    public class ContrAgent
    {
        private int _id;
		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _idn;
		public string Idn
        {
			get { return _idn; }
			set
            {
				if(value.Any(char.IsLetter) || value.Length != 12)
				{
                    Console.WriteLine($"Incorrectly entered identifier with ID: {this.Id}") ;
                }
                else
                {
                    _idn = value;
                }
            }
        }

		private DateTime _createDate;
		public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

		private string _createAuthor;
		public string CreateAuthor
        {
            get { return _createAuthor; }

            set { _createAuthor = value; }
        }

		private DateTime _editDate;
        public DateTime EditDate
        {
            get { return _editDate; }
            set { _editDate = value; }
        }

        private string _editAuthor;
        public string EditAuthor
        {
            get { return _editAuthor; }
            set { _editAuthor = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public ContrAgent() { }
        public ContrAgent(int id, string idn, DateTime createDate, string createAuthor, DateTime editDate, string editAuthor, string address)
        {
            _id = id;
            _idn = idn;
            _createDate = createDate;
            _createAuthor = createAuthor;
            _editDate = editDate;
            _editAuthor = editAuthor;
            _address = address;
        }
    }
}
