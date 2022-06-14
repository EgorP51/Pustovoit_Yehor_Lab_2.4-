using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2._4
{
    class Surgeon : Doctor
    {

        public override void TreatmentProcess()
        {
            Console.WriteLine("Хiрург використовує хiрургiчнi операцiї, суть яких складається \n" +
                         "з оперативного доступу(оголення органу або його частини) та способу \n" +
                    "(власне хiрургiчної маніпуляцiї) та виходу (вiдновлення цiлiсностi органiзму");
        }
        public override void ProfessionFeatures()
        {
            Console.WriteLine("Хiрургiчний метод вiдрiзняється тим, що окрiм вираженого лiкувального\n" +
                             " ефекту, його застосування завжди супроводжується операцiйною травмою.");
        }

        public Surgeon(int salary, int work_experience)
            : base(salary, work_experience)
        {
            //Console.WriteLine("Surgeon");
            duration_of_study = 9;
        }

    }
}
