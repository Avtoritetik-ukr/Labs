using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Hospital
    {
        public List<Doctor> Doctors { get; } = new List<Doctor>();
        public List<Patient> Patients { get; } = new List<Patient>();
        public List<HospitalRoom> Rooms { get; } = new List<HospitalRoom>();
        public List<MedicalRecord> Records { get; } = new List<MedicalRecord>();


        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine($"Лікар {doctor.Name} ({doctor.Specialization}) доданий до системи");
        }

        public void RegisterPatient(Patient patient)
        {
            Patients.Add(patient);
            Console.WriteLine($"Пацієнт {patient.Name}, {patient.Age} років, зареєстрований");
        }

        public void CreateRoom(HospitalRoom room)
        {
            Rooms.Add(room);
            Console.WriteLine($"Палата {room.RoomNumber} створена (місткість: {room.Capacity})");
        }

        public void AddMedicalRecord(MedicalRecord record)
        {
            Records.Add(record);
            Console.WriteLine($"Медичний запис створено: {record.Patient.Name} -> {record.Doctor.Name}");
        }
        public void HospitalizePatient(int patientId, int roomNumber)
        {
            Patient patient = Patients.FirstOrDefault(p => p.Id == patientId);
            HospitalRoom room = Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            if (patient == null)
            {
                Console.WriteLine($"Пацієнт з ID {patientId} не знайдений!");
                return;
            }
            if (room == null)
            {
                Console.WriteLine($"Палата {roomNumber} не знайдена!");
                return;
            }

            room.AddPatient(patient);
        }

        public List<MedicalRecord> GetPatientHistory(int patientId)
        {
            return Records.Where(r => r.Patient.Id == patientId).ToList();
        }

        public string GetStatistics()
        {
            int totalDoctors = Doctors.Count;
            int totalPatients = Patients.Count;
            int totalRooms = Rooms.Count;
            int totalPatientsInRooms = Rooms.Sum(room => room.Patients.Count);
            int totalRecords = Records.Count;

            return
                "=== СТАТИСТИКА ЛІКАРНІ ===\n" +
                $"Кількість лікарів: {totalDoctors}\n" +
                $"Кількість зареєстрованих пацієнтів: {totalPatients}\n" +
                $"Кількість палат: {totalRooms}\n" +
                $"Кількість пацієнтів у палатах: {totalPatientsInRooms}\n" +
                $"Кількість медичних записів: {totalRecords}";
        }
    }
}
