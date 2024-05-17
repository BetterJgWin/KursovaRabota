using System;
using System.Collections.Generic;

public class SchoolSportTeam : AmateurSportTeam
{
    public string School { get; set; }

    public SchoolSportTeam(string name, string city, string country, string league, string stadium, string history, List<string> players, string coach, string financing, string levelOfPlay, string school)
        : base(name, city, country, league, stadium, history, players, coach, financing, levelOfPlay)
    {
        School = school;
    }
}
