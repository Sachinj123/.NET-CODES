using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOwnAttributes;

namespace POCO
{
	[Table(TableName = "Employee")] 
    public class Emp
    {
		private int _No;
        private string _Name;

        [Column(ColumnName = "Empid", ColumnType = "int")]
        public int No
		{
			get { return _No; }
			set { _No = value; }
		}

		[Column(ColumnName = "Empname", ColumnType ="varchar(20)")]
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}





	}


	public class Book
	{
		private int _Bookid;

		private string _Name;

		private string _Author;

        [Column(ColumnName = "AuthorName ", ColumnType = "varchar(20)")]
        public string Author
		{
			get { return _Author; }
			set { _Author = value; }
		}

        [Column(ColumnName = "BookName", ColumnType = "varchar(20)")]
        public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

        [Column(ColumnName = "BookId", ColumnType = "int")]
        public int Bookid
		{
			get { return _Bookid; }
			set { _Bookid = value; }
		}

	}
}
