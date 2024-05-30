using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick.Models
{
    internal class ClickInfo
    {
        public int Point_x {  get; set; }
        public int Point_y {  get; set; }
        public DateTime TimeDelay { get; set; }
        public string TypeButton { get; set; }
    }
}
