using System;
using System.Collections.Generic;

public class SportTeam
{
    public string Name { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string League { get; set; }
    public string Stadium { get; set; }
    public string History { get; set; }
    public List<string> Players { get; set; }
    public string Coach { get; set; }

    public SportTeam(string name, string city, string country, string league, string stadium, string history, List<string> players, string coach)
    {
        Name = name;
        City = city;
        Country = country;
        League = league;
        Stadium = stadium;
        History = history;
        Players = players;
        Coach = coach;
    }

    public void AddPlayer(string player)
    {
        Players.Add(player);
    }

    public void RemovePlayer(string player)
    {
        Players.Remove(player);
    }
}
