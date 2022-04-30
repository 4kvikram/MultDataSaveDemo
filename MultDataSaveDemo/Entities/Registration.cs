using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MultDataSaveDemo.Entities
{
    public class Registration
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
       // public virtual Cities Cities { get; set; }
        public DateTime Date { get; set; }

        public int? CitiesId { get; set; }

        [ForeignKey(nameof(CitiesId))]
        public virtual Cities Cities { get; set; }
    }
}
