using _3_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public class ChildModel
    {

        public int Id { get; set; }
        public string ChildId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ChildModel()
        {

        }
        public ChildModel(int id,string childId, string name, DateTime birthDate)
        {
            Id= id;
            ChildId= childId;
            Name= name;
            BirthDate= birthDate;
        }
    }
}
