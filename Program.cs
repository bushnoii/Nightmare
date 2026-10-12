using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightmare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int heroHealth = 50, heroDamage = 5, enemyHealth = 50,
                enemyDamage = 5, posX = 0, posY = 0;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  Добро пожаловать в Кошмар!   |");
            Console.WriteLine("|                               |");
            Console.WriteLine("|                               |");
            Console.WriteLine("|                               |");
            Console.WriteLine("|       Хотите начать?          |");
            Console.WriteLine("|                               |");
            Console.WriteLine("---------------------------------");
            Console.ReadLine();

            Console.SetCursorPosition(posX, posY);
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("|                               |");
            Console.Write($"{"|", -8}");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("На вас напали!");               
            Console.ResetColor();
            Console.WriteLine($"{"|", 11}");
            Console.WriteLine("|                               |");
            Console.WriteLine("| Здоровье Противника: " + enemyHealth + $"{"|", 8}");
            Console.WriteLine("|                               |");
            Console.WriteLine("| Ваше здоровье: " + heroHealth + $"{"|", 14}");
            Console.WriteLine("| Ваш урон: "  + heroDamage  + $"{"|", 20}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Хотите напасть? Да/Нет");
            string answer = Console.ReadLine();
            if (answer == "да")
            {
                enemyHealth -= heroDamage;
                Console.SetCursorPosition(23, 4);
                Console.WriteLine(enemyHealth);
                Console.SetCursorPosition(0, 15);
            }
            else if (answer == "нет")
            {
                heroHealth -= enemyDamage;
                Console.SetCursorPosition(17, 6);
                Console.WriteLine(heroHealth);
                Console.SetCursorPosition (0, 15);
            }



        }
    }
}
