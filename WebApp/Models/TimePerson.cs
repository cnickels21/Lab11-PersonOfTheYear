using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class TimePersonConstructor
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

		public static GetPerson()
		{

		}

		public static List<TimePersonConstructor> GetPersons(int yearOne, int yearTwo)
		{
			string[] listOfAllPeople = File.ReadAllLines("../CSVFile/personOfTheYear.csv");



			return listOfAllPeople
				.Select(peopleLines => peopleLines.Split(","))
				.Select(eachPerson => new TimePersonConstructor
				{ 

				});
		}

	}
}
