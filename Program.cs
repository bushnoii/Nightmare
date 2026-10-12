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
            Console.ReadLine( );

            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("|                               |");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("|        На вас напали!         |");
            Console.ResetColor();
            Console.WriteLine("|                               |");
            Console.WriteLine("| Здоровье Противника: 50       |");
            Console.WriteLine("|                               |");
            Console.WriteLine("| Ваше здоровье: 50             |");
            Console.WriteLine("| Ваш урон: 5                   |");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Хотите напасть? Да/Нет");
            string answer = Console.ReadLine();
            if (answer == "Да")
            {

            }
            else
            {

            }



        }
    }
}
