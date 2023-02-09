using _3_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2_Services.Models
{
    public enum Gender
    {
        Male, Female
    }
    public enum HMO
    {
        Meuchedet, Leumit, Clalit, Macabi
    }
    public class ParentModel
    {

        public int Id { get; set; }
        public string ParentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Child> Children { get; set; }
        public Gender GenderType { get; set; }
        public HMO HMOType { get; set; }
        public DateTime BirthDate { get; set; }
        public ParentModel()
        {

        }
        public ParentModel(int id,string parentId, string firstName, string lastName,List<Child> children, Gender genderType, HMO hMOType, DateTime birthDate )
        {
            Id = id;
            ParentId= parentId;
            FirstName = firstName;
            LastName = lastName;
            Children = children;
            GenderType = genderType;
            HMOType = hMOType;
            BirthDate = birthDate;
        }
    }
}
