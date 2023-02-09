using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Entities
{
    public enum Gender
    {
        Male, Female
    }
    public enum HMO
    {
        Meuchedet, Leumit, Clalit, Macabi
    }
    public class Parent
    {
        [Key]
        public int Id { get; set; }
        public string ParentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Child> Children { get; set; }
        public Gender GenderType { get; set; }
        public HMO HMOType { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
