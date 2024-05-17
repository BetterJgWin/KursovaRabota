using System;
using System.Collections.Generic;

public class AmateurSportTeam : SportTeam
{
    public string Financing { get; set; } // Sponsorship, membership fees
    public string LevelOfPlay { get; set; } // Local, regional, national

    public AmateurSportTeam(string name, string city, string country, string league, string stadium, string history, List<string> players, string coach, string financing, string levelOfPlay)
        : base(name, city, country, league, stadium, history, players, coach)
    {
        Financing = financing;
        LevelOfPlay = levelOfPlay;
    }
}
