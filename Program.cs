using System;

namespace ProgrammUnderThePassword
{
    class Program
    {
        static void Main(string[] args) {
            string savePassword = "pass";
            string inputPassword;
            int quantityOfTry = 3;
            string secretMassge = "Будь клевым!";

            for (int i = 0; i < quantityOfTry; i++)
            {
                Console.Write("Введите пароль: ");
                inputPassword = Console.ReadLine();

                if (inputPassword == savePassword)
                {
                    Console.WriteLine(secretMassge);
                    i = int.MaxValue;
                }
            }
        }
    }
}
