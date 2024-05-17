using System;
using System.Collections.Generic;

namespace KursovaRabota
{
    class Program
    {
        static void Main(string[] args)
        {
            var staff = new List<string> { "Coach B", "Doctor A", "Physio C" };
            var professionalTeam = new ProfessionalSportTeam("Pro Team", "City B", "Country B", "League B", "Stadium B", "History B", new List<string> { "Pro Player 1", "Pro Player 2" }, "Coach B", "Owner A", 1000000, staff);
            Console.WriteLine($"Professional Team: {professionalTeam.Name}, Budget: {professionalTeam.Budget}");

            var amateurTeam = new AmateurSportTeam("Amateur Team", "City C", "Country C", "League C", "Stadium C", "History C", new List<string> { "Amateur Player 1" }, "Coach C", "Sponsorship", "Local");
            Console.WriteLine($"Amateur Team: {amateurTeam.Name}, Level of Play: {amateurTeam.LevelOfPlay}");

            var universityTeam = new UniversitySportTeam("University Team", "City D", "Country D", "League D", "Stadium D", "History D", new List<string> { "Uni Player 1" }, "Coach D", "Membership Fees", "Regional", "University A", 5000);
            Console.WriteLine($"University Team: {universityTeam.Name}, University: {universityTeam.University}");

            var schoolTeam = new SchoolSportTeam("School Team", "City E", "Country E", "League E", "Stadium E", "History E", new List<string> { "School Player 1" }, "Coach E", "Membership Fees", "Local", "School A");
            Console.WriteLine($"School Team: {schoolTeam.Name}, School: {schoolTeam.School}");

            var nationalTeam = new NationalSportTeam("National Team", "City F", "Country F", "League F", "Stadium F", "History F", new List<string> { "National Player 1" }, "Coach F", "Owner B", 2000000, staff, "Country G");
            Console.WriteLine($"National Team: {nationalTeam.Name}, Country Represented: {nationalTeam.CountryRepresented}");
        }
    }
}
