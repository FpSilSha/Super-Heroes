using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroes.Models
{
    public class HeroesNHeroines
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SuperName { get; set; }
        [Required]
        public string Alter_Ego_Name { get; set; }
        [Required]
        public string Primary_SuperAbility { get; set; }
        public string Secondary_SuperAbility { get; set; }
        public string CatchPhrase { get; set; }
    }
}