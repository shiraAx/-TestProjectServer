using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Entities
{
    public class Child
    {
        [Key]
        public int Id { get; set; }
        public string ChildId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
