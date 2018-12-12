using System;
using System.Collections.Generic;

namespace ObjProgBibH1
{
	class Program
	{
		static void Main(string[] args)
		{

		}
	}

	class Book
	{
		public string Title { get; set; }
		public int LoanPeriod { get; set; }
		
		public Book(string title)
		{
			Title = title;
		}
	}

	class Library
	{
		public List<Book> availableList = new List<Book>();
		public List<Book> loanedList = new List<Book>();
		private readonly int normalPeriod = 45;
		private readonly int extendedPeriod = 90;

		public void LoanBook(string title)
		{
			foreach (var book in availableList)
			{
				if (book.Title == title)
				{
					book.LoanPeriod = normalPeriod;
					loanedList.Add(book);
				}
			}
		}

		public void ReturnBook(string title)
		{
			foreach (var book in loanedList)
			{
				if (book.Title == title)
				{
					availableList.Add(book);
				}
			}
		}

		public void CheckBook(string title)
		{
			foreach (var book in availableList)
			{
				if (book.Title == title)
				{
					Console.WriteLine("That book is available");
				}
				else
				{
					Console.WriteLine("That book is not currently available");
				}
			}
		}

		public void ExtendLoan(string title)
		{
			foreach (var book in loanedList)
			{
				if (book.Title == title)
				{
					book.LoanPeriod = extendedPeriod;
				}
				else
				{
					Console.WriteLine("That book is overdue, please return it");
				}
			}
		}
		
		public void PassADay()
		{
			foreach (var book in loanedList)
			{
				book.LoanPeriod -= 1;
			}
		}

		public void PassTenDays()
		{
			foreach (var book in loanedList)
			{
				book.LoanPeriod -= 10;
			}
		}

		public void PassAllDays()
		{
			foreach (var book in loanedList)
			{
				book.LoanPeriod -= book.LoanPeriod;
			}
		}
	}
}
