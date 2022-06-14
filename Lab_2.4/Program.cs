using System;
using System.Collections.Generic;

//Проаналізувати завдання, виділити інформаційні об’єкти та дії. Визначити правильну ієрархію об’єктів
//Створити базовий суперклас (абстрактний клас або інтерфейс) і визначити загальні методи для даного класу. Створити підкласи, в які додати специфічні властивості та методи.
//Частину методів перевизначити. 
//Розробити програму з використанням абстрактних класів та інтерфейсів. Чітко розуміти, де доцільно використати суперклас, а де звичайний. 
//При розробці використовувати наслідування та поліморфізм
//У всіх класах повинні бути реалізовані доцільні для класу методи, навіть якщо це не вказано у завданні
//Використовувати об’єкти підкласів для моделювання реальних ситуацій на об’єктів


//Створити суперклас Лікар і підкласи Хірург, Нейрохірург, Дантист, Зубний технік.
//За допомогою конструктора задати заробітну плату кожного лікаря.
//Вивести на екран кількість досвіду в роках кожного лікаря.
//Порахувати оплату, яку отримує лікар стоматологічного напрямку від клієнта.

namespace Lab_2._4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Doctor> doctorsTeam = new List<Doctor>();

            for (int i = 0; i < 3; i++)
            {
                doctorsTeam.Add(new Surgeon(2000, 12));
            }

            for (int i = 0; i < 4; i++)
            {
                doctorsTeam.Add(new Dentist(2000, 12, 200));
            }

            doctorsTeam.Add(new DentalMechanic(1500, 5));

            doctorsTeam.Add(new Neurosurgeon(3500, 10));

            foreach (var doc in doctorsTeam)
            {
                doc.ShowInfo();
                Console.WriteLine(new string('-', 70));
            }

        }
    }
}



 //Doctor h = new Surgeon(2000,15);
            //h.ShowInfo();

            //Console.WriteLine(new string('-',70));

            //Doctor nh = new Neurosurgeon(2500, 12);
            //nh.ShowInfo();

            //Console.WriteLine(new string('-', 70));

            //Doctor d = new Dentist(1500, 5,200);
            //d.ShowInfo();

            //Console.WriteLine(new string('-', 70));

            //Doctor t = new DentalMechanic(1000, 3);
            //t.ShowInfo();

            //Console.ReadKey();

            //List<Doctor> doctorsTeam = new List<Doctor>();

            //for (int i = 0; i < 3; i++)
            //{
            //    doctorsTeam.Add(new Surgeon(2000, 12));
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    doctorsTeam.Add(new Dentist(2000, 12,200));
            //}

            //doctorsTeam.Add(new DentalMechanic(1500, 5));

            //doctorsTeam.Add(new Neurosurgeon(3500, 10));

            //foreach(var doc in doctorsTeam)
            //{
            //    doc.ShowInfo();
            //    Console.WriteLine(new string('-', 70));
            //}