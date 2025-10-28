using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace HospitalManagementSystem
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Patient(int patientId, string name, int age)
        {
            Id = patientId;
            Name = name;
            Age = age;
        }

    }
}
