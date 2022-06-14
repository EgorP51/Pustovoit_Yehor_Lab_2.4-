using System;
using System.Collections.Generic;
using System.Text;


namespace Lab_2._4
{
    class DentalMechanic : Doctor
    {
        public override void TreatmentProcess()
        {
            Console.WriteLine("Зубний технiк безпосередньо виготовляє рiзнi протези \n" +
                "зубiв,частин особи та лицьового скелета, найчастiше це протези зубiв,\n" +
                " рiдше протези особи або частин лицьового скелета, ортодонтичних та\n" +
                " щелепно-лицьових апаратiв,якi надалi встановлюють пацiєнтам лiкарi-стоматологи");
        }
        public override void ProfessionFeatures()
        {
            Console.WriteLine("Зубний технiк не зустрiчається з пацiєнтами. \n" +
                "Iнодi у виняткових випадках така зустрiч необхiдна. ");
        }


        public DentalMechanic(int salary, int work_experience)
            : base(salary, work_experience)
        {
            //Console.WriteLine("DentalMechanic");
            duration_of_study = 4;
        }
    }
}
