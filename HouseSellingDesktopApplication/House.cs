using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSellingDesktopApplication
{
    public class House
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
        public DateTime EndDate { get; set; }

        public House()
        {
            this.Id = Guid.NewGuid(); 
        }
    }
}
