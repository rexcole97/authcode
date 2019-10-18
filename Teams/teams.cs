using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Authpractice.Pages.Teams
{
    public class teams
    { 
        [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int teamid { get; set; }
    public string tname { get; set; }
    public string tcity { get; set; }
    public int value { get; set; }
}
}
