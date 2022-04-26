using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }
        
        // Foreign Key
        public int PlacementContractID { get; set; }
        public PlacementContract PlacementContracts { get; set; }

        public int DayOfWeek { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfEmployees { get; set; }
        public bool Active { get; set; }
        public string? Notes { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
