using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===");

            Hospital hospital = new Hospital();

            Console.WriteLine("\n--- Додавання лікарів ---");
            hospital.AddDoctor(new Doctor(1, "Тетяна Кармаза", "Кардіолог"));
            hospital.AddDoctor(new Doctor(2, "Богдан Сивоглаз", "Хірург-ортопед"));
            hospital.AddDoctor(new Doctor(3, "Олексій Агров", "Педіатр"));

            Console.WriteLine("\n--- Реєстрація пацієнтів ---");
            hospital.RegisterPatient(new Patient(1, "Петро Дід", 65));
            hospital.RegisterPatient(new Patient(2, "Максим Незнайко", 28));
            hospital.RegisterPatient(new Patient(3, "Карім Федорченко", 4));

            Console.WriteLine("\n--- Створення палат ---");
            hospital.CreateRoom(new HospitalRoom(101, 2));
            hospital.CreateRoom(new HospitalRoom(102, 1));

            Console.WriteLine("\n--- Госпіталізація ---");
            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 102);
            hospital.HospitalizePatient(99, 101);
            hospital.HospitalizePatient(1, 999);
            hospital.HospitalizePatient(1, 102);

            Console.WriteLine("\n--- Медичні записи ---");
            Patient petro = hospital.Patients.FirstOrDefault(p => p.Id == 1);
            Patient maksim = hospital.Patients.FirstOrDefault(p => p.Id == 2);
            Doctor tanya = hospital.Doctors.FirstOrDefault(d => d.Id == 1);
            Doctor bogdan = hospital.Doctors.FirstOrDefault(d => d.Id == 2);
            hospital.AddMedicalRecord(new MedicalRecord(petro, tanya, DateTime.Now, "ГРВІ"));
            hospital.AddMedicalRecord(new MedicalRecord(maksim, bogdan, DateTime.Now, "Апендектомія"));
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА (Незнайко Максим) ---");
            List<MedicalRecord> history = hospital.GetPatientHistory(2);

            if (history.Count == 0)
            {
                Console.WriteLine("Історія пацієнта не знайдена.");
            }
            else
            {
                foreach (var record in history)
                {
                    Console.WriteLine($"  Дата: {record.Date.ToString("yyyy-MM-dd")}");
                    Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                    Console.WriteLine($"  Опис: {record.Description}");
                    Console.WriteLine("------------------------------------------");
                }
            }
            Console.WriteLine("\n--- СТАТИСТИКА ---");
            Console.WriteLine(hospital.GetStatistics());
        }
    }

}
