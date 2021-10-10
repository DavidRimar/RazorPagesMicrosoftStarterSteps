using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesTemplate.Data;
using System;
using System.Linq;

namespace RazorPagesTemplate.Model
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesGamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesGamesContext>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        HomeTeamName = "Wolverhampton",
                        HomeTeamGoals = 2,
                        AwayTeamName = "Chelsea",
                        AwayTeamGoals = 4,
                        Referee = "Cesar Soto Grado"
                    },

                    new Game
                    {
                        HomeTeamName = "Everton",
                        HomeTeamGoals = 1,
                        AwayTeamName = "Stoke",
                        AwayTeamGoals = 0,
                        Referee = "Cesar Soto Grado"
                    },

                    new Game
                    {
                        HomeTeamName = "Southampton",
                        HomeTeamGoals = 1,
                        AwayTeamName = "Arsenal",
                        AwayTeamGoals = 2,
                        Referee = "Cesar Soto Grado"
                    },

                    new Game
                    {
                        HomeTeamName = "West Brom",
                        HomeTeamGoals = 0,
                        AwayTeamName = "Norwich",
                        AwayTeamGoals = 0,
                        Referee = "Cesar Soto Grado"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
