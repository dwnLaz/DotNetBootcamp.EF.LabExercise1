using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WorkScheduleSolution.Entities
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string? Contact { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }

        public ICollection<PlacementContract> PlacementContracts { get; set; }
    }
}
