using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2._4
{
    class Neurosurgeon : Doctor
    {
        public override void TreatmentProcess()
        {
            Console.WriteLine("Нейрохiрург консультує пацiєнтiв, призначає обстеження, робить операцiїна\n" +
                      " головному i спинному мозку, хребтi, займається реабiлiтацiєю пацiєнтiв пiсля операцiї.");
        }
        public override void ProfessionFeatures()
        {
            Console.WriteLine("Лiкар-нейрохiрург займається дiагностикою, лiкуванням\n " +
               "та профiлактикою порушень центральної та периферiйної нервової системи.");
        }
        

        public Neurosurgeon(int salary, int work_experience)
            : base(salary, work_experience)
        {
            //Console.WriteLine("Neurosurgeon");
            duration_of_study = 10;
        }
    }
}
