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
                        AwayTeamGoals = 4
                    },

                    new Game
                    {
                        HomeTeamName = "Leicester",
                        HomeTeamGoals = 1,
                        AwayTeamName = "Burnley",
                        AwayTeamGoals = 0
                    },

                    new Game
                    {
                        HomeTeamName = "Southampton",
                        HomeTeamGoals = 1,
                        AwayTeamName = "Newcastle",
                        AwayTeamGoals = 1
                    },

                    new Game
                    {
                        HomeTeamName = "West Ham",
                        HomeTeamGoals = 2,
                        AwayTeamName = "Norwich",
                        AwayTeamGoals = 0
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
