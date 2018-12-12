using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleProjektH1
{
	class Program
	{
		static void Main(string[] args)
		{
			MyFunctions mf = new MyFunctions();

			List<Person> personList = new List<Person>
			{
				new Person
				{
					Name = "Ole",
					Age = 19,
					Salary = 22000
				},
				new Person
				{
					Name = "Peter",
					Age = 21,
					Salary = 31000
				},
				new Person
				{
					Name = "Jonna",
					Age = 20,
					Salary = 34000
				},
				new Person
				{
					Name = "Finn",
					Age = 22,
					Salary = 27500
				},
				new Person
				{
					Name = "Heidi",
					Age = 23,
					Salary = 29500
				},
			};



			while (true)
			{
				if (!File.Exists(Environment.CurrentDirectory + "\\NameList.txt"))
				{
					File.Create(Environment.CurrentDirectory + "\\NameList.txt").Close();
					
					mf.AppendMyText(personList);					
				}
				else if (File.ReadAllText(Environment.CurrentDirectory + "\\NameList.txt") == "")
				{
					File.Create(Environment.CurrentDirectory + "\\NameList.txt").Close();
					
				    mf.AppendMyText(personList);					
				}


				Console.Write(":>");
				string input = Console.ReadLine().ToLower();

				string[] splitUp = input.Split(null);

				switch (splitUp[0])
				{
					case "showall":
						mf.ShowAll();
						break;
					case "addperson":
						mf.AddPerson(personList, input.Substring("addperson".Length));
						break;
					case "deleteperson":
						mf.DeletePerson(personList, input.Substring("deleteperson".Length));
						break;
					case "changeperson":
						mf.ChangePerson(personList, splitUp[1], splitUp[2]);
						break;
					default:
						break;
				}				
			}
		}
	}

	class MyFunctions
	{
		// Show the entire list
		public void ShowAll()
		{
			List<string> stringList = AlterNameList();

			foreach (var name in stringList)
			{
				if (name != "")
				{
					Console.WriteLine(name);
				}
			}
		}

		// Add a person at the end of the list
		public void AddPerson(List<Person> personList, string b)
		{
			//Console.WriteLine("Please enter their name");
			//string name = Console.ReadLine();
			//Console.WriteLine("Please enter their age");
			//int age = int.Parse(Console.ReadLine());
			//Console.WriteLine("Please enter their salary");
			//int salary = int.Parse(Console.ReadLine());
			personList.Add
			(
				new Person
				{
					Name = b,
					//Age = age,
					//Salary = salary
				}
			);
			
			File.AppendAllText(Environment.CurrentDirectory + "\\NameList.txt", Capitalize(b) /*+ "/" + age + "/" + salary */+ ";");
		}

		// Remove a person with a specific name
		public void DeletePerson(List<Person> personList, string b)
		{
			List<string> stringList = AlterNameList();

			stringList.Remove(Capitalize(b));

			File.WriteAllText(Environment.CurrentDirectory + "\\NameList.txt", "");

			AppendMyText(personList);
		}
		
		// Change the person with a specific name, to another name
		public void ChangePerson(List<Person> personList, string a, string b)
		{
			List<string> stringList = AlterNameList();
			
			stringList[stringList.IndexOf(Capitalize(a))] = Capitalize(b);

			File.WriteAllText(Environment.CurrentDirectory + "\\NameList.txt", "");

			AppendMyText(personList);
		}

		/// <summary>
		/// Capitalizes the first letter of the provided string.
		/// </summary>
		/// <param name="a">The string, that you need capitalized (First letter only)</param>
		/// <returns>String with first letter capitalized</returns>
		public string Capitalize(string a)
		{
			char[] newCharArray = a.ToCharArray();
			if (a != "")
			{
				newCharArray[0] = char.ToUpper(a[0]);
			}		
			return new string(newCharArray);
		}

		/// <summary>
		/// Reads the current list of people in the file, found in your folder. Then creates a list of the people, prepared for alteration.
		/// </summary>
		/// <returns>A list, prepared for alteration, with people.</returns>
		public List<string> AlterNameList ()
		{
			string content = File.ReadAllText(Environment.CurrentDirectory + "\\NameList.txt");
			List<string> stringList = new List<string>();

			foreach (var name in content.Split(';'))
			{
				if (name != "")
				{
					stringList.Add(Capitalize(name));
				}
			}

			return stringList;
		}

		/// <summary>
		/// Fetches the information from your current list of people, and appends it to your file
		/// </summary>
		/// <param name="stringList">List of people</param>
		public void AppendMyText(List<Person> stringList)
		{
			foreach (var person in stringList)
			{
				File.AppendAllText(Environment.CurrentDirectory + "\\NameList.txt", Capitalize(person.Name) /*+ "/" + person.Age + "/" + person.Salary */+";");
			}
		}
	}

	class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public int Salary { get; set; }
	}
}