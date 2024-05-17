using System;
using System.Collections.Generic;

public class UniversitySportTeam : AmateurSportTeam
{
    public string University { get; set; }
    public double ScholarshipAmount { get; set; }

    public UniversitySportTeam(string name, string city, string country, string league, string stadium, string history, List<string> players, string coach, string financing, string levelOfPlay, string university, double scholarshipAmount)
        : base(name, city, country, league, stadium, history, players, coach, financing, levelOfPlay)
    {
        University = university;
        ScholarshipAmount = scholarshipAmount;
    }
}
