using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersMvcApp.Models
{
    public struct User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string FullName
        {
            get { return $"{Name} {LastName}"; }
        }

        public string DisplayInfo
        {
            get { return $"{Name} {LastName}, {Age} років"; }
        }

        public User(int id, string name, string lastName, int age)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;
        }
    }
}