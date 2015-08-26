using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSellingDesktopApplication
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }

        public Employee()
        {
            this.Id = Guid.NewGuid();
        }

    }
}
