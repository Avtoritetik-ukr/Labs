using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalRoom
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; private set; } 
        public List<Patient> Patients { get; } = new List<Patient>();
        public HospitalRoom(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
        }

        public void AddPatient(Patient patient)
        {
            if (Patients.Count < Capacity)
            {
                Patients.Add(patient);
                Console.WriteLine($"Пацієнт {patient.Name} доданий у палату {RoomNumber}\n");
            }
            else
            {
                Console.WriteLine($"Палата {RoomNumber} переповнена! Неможливо додати пацієнта.\n");
            }
        }
    }
}
