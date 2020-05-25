using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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

		public TimePerson(
			int year,
			string honor,
			string name,
			string country,
			int birthYear,
			int deathYear,
			string title,
			string category,
			string context)
		{
			Year = year;
			Honor = honor;
			Name = name;
			Country = country;
			BirthYear = birthYear;
			DeathYear = deathYear;
			Title = title;
			Category = category;
			Context = context;
		}

		public static List<TimePerson> GetPersons(int yearOne, int yearTwo)
		{
			string[] allOfThePeople = File.ReadAllLines("../WebApp/CSVFile/personOfTheYear.csv");

			// 3. Refactor this return to suit your needs for the lab
			// 4. Need this method producing data to print to the view
			// 5. Needs a filter

			try
			{
				for (int i = 1; i < allOfThePeople.Length; i++)
				{
					allOfThePeople
					.Skip(1)
					.Select(eachPerson => eachPerson.Split(","))
					.Select(eachColumn =>
					{
						TimePerson timePerson = new TimePerson(
							int.Parse(eachColumn[0]),
							eachColumn[1],
							eachColumn[2],
							eachColumn[3],
							(eachColumn[4] == "") ? 0 : int.Parse(eachColumn[4]),
							(eachColumn[5] == "") ? 0 : int.Parse(eachColumn[5]),
							eachColumn[6],
							eachColumn[7],
							eachColumn[8]
						);
						return timePerson;
					})
					.ToList();
				}
				return default;
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
