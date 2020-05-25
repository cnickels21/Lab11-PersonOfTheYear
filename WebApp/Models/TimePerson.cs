using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WebApp.Models
{
	public class TimePerson : IEnumerable // Don't thing we need this
	{
		// Time Person Properties
		public int Year { get; set; }
		public string Honor { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public int BirthYear { get; set; }
		public int DeathYear { get; set; }
		public string Title { get; set; }
		public string Category { get; set; }
		public string Context { get; set; }

		public static List<TimePerson> GetPersons(int yearOne, int yearTwo)
		{
			string[] allOfThePeople = File.ReadAllLines("../WebApp/CSVFile/personOfTheYear.csv");

			// 3. Refactor this return to suit your needs for the lab
			// 4. Need this method producing data to print to the view
			// 5. Needs a filter

			try
			{
				return allOfThePeople
				.Skip(1)
				.Select(eachPerson => eachPerson.Split(","))
				.Select(eachColumn =>
				{
					TimePerson timePerson = new TimePerson()
					{
						Year = (int)Enum.Parse(typeof(int), eachColumn[0]),
						Honor = (string)Enum.Parse(typeof(string), eachColumn[1]),
						Name = (string)Enum.Parse(typeof(string), eachColumn[2]),
						Country = (string)Enum.Parse(typeof(string), eachColumn[3]),
						BirthYear = (int)Enum.Parse(typeof(int), eachColumn[4]),
						DeathYear = (int)Enum.Parse(typeof(int), eachColumn[5]),
						Title = (string)Enum.Parse(typeof(string), eachColumn[6]),
						Category = (string)Enum.Parse(typeof(string), eachColumn[7]),
						Context = (string)Enum.Parse(typeof(string), eachColumn[8]),
					};
					return timePerson;
				})
				.ToList();
			}
			catch (ArgumentNullException ex)
			{

				throw;
			}
		}

		// Don't think we need this
		public IEnumerator GetEnumerator()
		{
			return default;
		}
	}
}
