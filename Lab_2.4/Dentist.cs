using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2._4
{
    class Dentist : Doctor
    {
        private int n_people;
        private const float percent = 1.05f;
        public override void TreatmentProcess()
        {
            Console.WriteLine("Стоматолог займається лiкуванням зубiв, щелепи, м'яких тканин та iнших органiв ротової порожнини.");
        }
        public override void ProfessionFeatures()
        {
            Console.WriteLine("Спецiалiзацiя на роботi з ротовою порожниною");
        }

        public override void ExtraMoney()
        {
            Console.WriteLine("*Залежно вiд кiлькостi вiдвiдувачiв стоматолог може отримувати додатковi кошти.\n" +
                $"При кiлькостi людей {n_people}, додатковий заробіток буде {n_people * percent}");
        }

        public Dentist(int salary, int work_experience, int n_people)
            : base(salary, work_experience)
        {
            this.n_people = n_people;
            duration_of_study = 6;
        }
    }
}
