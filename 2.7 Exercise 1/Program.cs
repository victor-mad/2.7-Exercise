using System;
using static System.Console;

namespace _2._7_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Михайлов Виктор Сергеевич";
            byte age = 32;
            string eMail = "fox.promo@gmail.com";

            double pointProg = 83;
            double pointMath = 79.5;
            double pointPhys = 67;

            string pattern = "Ф.И.О.: {0,44} \nВозраст: {1,20} \neMail: {2,39} \nБаллы по программированию: {3} \nБаллы по математике: {4,10} \nБаллы по физике: {5,12}";
                
                    WriteLine(pattern,
                              fullName,
                              age,
                              eMail,
                              pointProg,
                              pointMath,
                              pointPhys);

                    ReadKey();

            double pointSum = pointProg + pointMath + pointPhys;

            double average = pointSum / 3;

            string newPattern = "Сумма баллов: {0,18} \nСредний балл: {1,17}";

                    WriteLine(newPattern,
                              pointSum,
                              average);
            
                    ReadKey();
        }
    }
}
