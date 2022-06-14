using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2._4
{
    abstract class Doctor 
    {
        protected int duration_of_study;
        private int work_experience;
        private int salary;
        int TEST;
        private int privateTest;
        public int publicTest;

        public void RefresherCourses() => Console.WriteLine("+ Курси пiдвищення квалiфiкацiї: кожнi 5 рокiв");
        public abstract void TreatmentProcess();
        public abstract void ProfessionFeatures();
        public virtual void ExtraMoney() { }

        public Doctor(int salary, int work_experience)
        {
            this.salary = salary;
            this.work_experience = work_experience;
        }

        public string GetDoctor()
        {
            string[] i = GetType().ToString().Split('.');
            return i[2];
        }
        public void ShowInfo()
        {
            Console.WriteLine(GetDoctor());
            Console.WriteLine($"Salary: {salary}");
            ExtraMoney();
            Console.WriteLine($"Work experience: {work_experience} рокiв");
            Console.WriteLine($"Must study: {duration_of_study} рокiв");
            RefresherCourses();
            Console.Write("Treatment process: ");
            TreatmentProcess();
            Console.Write("Profession features: ");
            ProfessionFeatures();
        }

    }
}
