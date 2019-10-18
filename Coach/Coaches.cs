using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Authpractice.Pages.Coach
{
    public class Coaches
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cid { get; set; }
        public string CFN{ get; set; }
        public string CLN { get; set; }
        public string team { get; set; }
    }
}
