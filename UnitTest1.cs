namespace KursovaRabota.Tests
{
    [TestClass]
    public class SportTeamTests
    {
        [TestMethod]
        public void CanAddPlayer()
        {
            var team = new SportTeam("Team A", "City A", "Country A", "League A", "Stadium A", "History A", new List<string>(), "Coach A");
            team.AddPlayer("Player 1");
            CollectionAssert.Contains(team.Players, "Player 1");
        }

        [TestMethod]
        public void CanRemovePlayer()
        {
            var team = new SportTeam("Team A", "City A", "Country A", "League A", "Stadium A", "History A", new List<string> { "Player 1" }, "Coach A");
            team.RemovePlayer("Player 1");
            CollectionAssert.DoesNotContain(team.Players, "Player 1");
        }
    }
    [TestClass]
    public class ProfessionalSportTeamTests
    {
        [TestMethod]
        public void CanCreateProfessionalSportTeam()
        {
            var staff = new List<string> { "Coach B", "Doctor A", "Physio C" };
            var team = new ProfessionalSportTeam("Pro Team", "City B", "Country B", "League B", "Stadium B", "History B", new List<string> { "Pro Player 1" }, "Coach B", "Owner A", 1000000, staff);
            Assert.AreEqual("Pro Team", team.Name);
            Assert.AreEqual(1000000, team.Budget);
            CollectionAssert.Contains(team.Staff, "Coach B");
        }
    }
    [TestClass]
    public class AmateurSportTeamTests
    {
        [TestMethod]
        public void CanCreateAmateurSportTeam()
        {
            var team = new AmateurSportTeam("Amateur Team", "City C", "Country C", "League C", "Stadium C", "History C", new List<string> { "Amateur Player 1" }, "Coach C", "Sponsorship", "Local");
            Assert.AreEqual("Amateur Team", team.Name);
            Assert.AreEqual("Sponsorship", team.Financing);
            Assert.AreEqual("Local", team.LevelOfPlay);
        }
    }
    [TestClass]
    public class UniversitySportTeamTests
    {
        [TestMethod]
        public void CanCreateUniversitySportTeam()
        {
            var team = new UniversitySportTeam("University Team", "City D", "Country D", "League D", "Stadium D", "History D", new List<string> { "Uni Player 1" }, "Coach D", "Membership Fees", "Regional", "University A", 5000);
            Assert.AreEqual("University Team", team.Name);
            Assert.AreEqual("University A", team.University);
            Assert.AreEqual(5000, team.ScholarshipAmount);
        }
    }
    [TestClass]
    public class SchoolSportTeamTests
    {
        [TestMethod]
        public void CanCreateSchoolSportTeam()
        {
            var team = new SchoolSportTeam("School Team", "City E", "Country E", "League E", "Stadium E", "History E", new List<string> { "School Player 1" }, "Coach E", "Membership Fees", "Local", "School A");
            Assert.AreEqual("School Team", team.Name);
            Assert.AreEqual("School A", team.School);
        }
    }
    [TestClass]
    public class NationalSportTeamTests
    {
        [TestMethod]
        public void CanCreateNationalSportTeam()
        {
            var staff = new List<string> { "Coach F", "Doctor B", "Physio D" };
            var team = new NationalSportTeam("National Team", "City F", "Country F", "League F", "Stadium F", "History F", new List<string> { "National Player 1" }, "Coach F", "Owner B", 2000000, staff, "Country G");
            Assert.AreEqual("National Team", team.Name);
            Assert.AreEqual("Country G", team.CountryRepresented);
        }
    }
}