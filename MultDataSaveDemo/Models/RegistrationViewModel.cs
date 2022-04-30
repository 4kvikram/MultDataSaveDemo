using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultDataSaveDemo.Models
{
    public class RegistrationViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public DateTime Date { get; set; }
    }
}
