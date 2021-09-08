using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesTemplate.Model
{
    public class Game
    {

        /////// PROPERTIES (Corresponding to the columns of the DB) /////

        // ID
        public int GameID { get; set; }

        // HomeTeamName
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string HomeTeamName { get; set; }

        // AwayTeamName
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string AwayTeamName { get; set; }


        // HomeTeamGoals
        [Range(1, 20)]
        [Required]
        public int HomeTeamGoals { get; set; }

        // AwayTeamGoals
        [Range(1, 20)]
        [Required]
        public int AwayTeamGoals { get; set; }

    }
}
