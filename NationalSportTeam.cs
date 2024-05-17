using System;
using System.Collections.Generic;

public class NationalSportTeam : ProfessionalSportTeam
{
    public string CountryRepresented { get; set; }

    public NationalSportTeam(string name, string city, string country, string league, string stadium, string history, List<string> players, string coach, string owner, double budget, List<string> staff, string countryRepresented)
        : base(name, city, country, league, stadium, history, players, coach, owner, budget, staff)
    {
        CountryRepresented = countryRepresented;
    }
}
