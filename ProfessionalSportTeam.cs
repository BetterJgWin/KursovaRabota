using System;
using System.Collections.Generic;

public class ProfessionalSportTeam : SportTeam
{
    public string Owner { get; set; }
    public double Budget { get; set; }
    public List<string> Staff { get; set; } // Coaches, doctors, physiotherapists

    public ProfessionalSportTeam(string name, string city, string country, string league, string stadium, string history, List<string> players, string coach, string owner, double budget, List<string> staff)
        : base(name, city, country, league, stadium, history, players, coach)
    {
        Owner = owner;
        Budget = budget;
        Staff = staff;
    }
}
