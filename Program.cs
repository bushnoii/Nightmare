using System;
using System.Collections.Generic;
using System.Data;
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
            int gameWight = 20, gameHeight = 60;
            string probel = "";
            string playerName = "";

            //отрисовываю рамку для игры

            for (int i = 0; i < gameHeight; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for (int j = 0; j < gameWight; j++)
            {
                Console.WriteLine($"| {probel,-56} |");
            }
            for (int i = 0; i < gameHeight; i++)
            {
                Console.Write("-");
            }

            Console.SetCursorPosition(17, 3);
            Console.WriteLine("Добро пожаловать в Кошмар!");

            //когда научимся делать рисунки, тут в пустом пространстве что-то будет
            Console.SetCursorPosition(23, 15);
            Console.WriteLine("Хотите начать?");

            Console.SetCursorPosition(20, 17);
            Console.WriteLine("Да [А]      Нет [D]");

            Console.SetCursorPosition(0, gameWight + 2);

            //выбор кнопок

            bool gamestarted = false;
            bool choice = true;
            while (choice)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.SetCursorPosition(20, 17);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Да [А]");
                        Console.ResetColor();
                        gamestarted = true;
                        choice = false;
                        break;

                    case ConsoleKey.D:
                        Console.SetCursorPosition(30, 17);
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Нет [D]");
                        Console.ResetColor();
                        gamestarted = false;
                        choice = false;
                        break;
                }


            }
            if (!gamestarted)
            {
                Console.Clear();
                for (int i = 0; i < gameHeight; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                for (int j = 0; j < gameWight; j++)
                {
                    Console.WriteLine($"| {probel,-56} |");
                }
                for (int i = 0; i < gameHeight; i++)
                {
                    Console.Write("-");
                }

                Console.SetCursorPosition(17,9);
                Console.Write("Возвращайтесь,");

                Console.SetCursorPosition(18, 10);
                Console.Write("когда будете готовы");

                Console.SetCursorPosition(19, 11);
                Console.Write("взглянуть кошмару в глаза");

                Console.SetCursorPosition(0, gameWight + 2);
                return;
            }

            //игрок вводит своё имя

            Console.Clear();
            for (int i = 0; i < gameHeight; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for (int j = 0; j < gameWight; j++)
            {
                Console.WriteLine($"| {probel,-56} |");
            }
            for (int i = 0; i < gameHeight; i++)
            {
                Console.Write("-");
            }

            Console.SetCursorPosition (17,9);
            Console.WriteLine("Назови своё имя, человек: ");
            Console.SetCursorPosition(30, 10);
            playerName = Console.ReadLine();
            Console.SetCursorPosition(0, gameWight + 2);

            Console.Clear();
            for (int i = 0; i < gameHeight; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for (int j = 0; j < gameWight; j++)
            {
                Console.WriteLine($"| {probel,-56} |");
            }
            for (int i = 0; i < gameHeight; i++)
            {
                Console.Write("-");
            }

            Console.SetCursorPosition(10, 9);
            Console.WriteLine($"Значит, твоё имя {playerName}...ещё увидимся");
            Console.SetCursorPosition(0, gameWight + 2);
















            /*    Console.WriteLine("---------------------------------");
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
                if (answer == "да" || answer=="Да")
                {
                    enemyHealth -= heroDamage;
                    Console.SetCursorPosition(23, 4);
                    Console.WriteLine(enemyHealth);
                    Console.SetCursorPosition(0, 15);
                }
                else if (answer == "нет" || answer == "Нет")
                {
                    heroHealth -= enemyDamage;
                    Console.SetCursorPosition(17, 6);
                    Console.WriteLine(heroHealth);
                    Console.SetCursorPosition (0, 15);*/
        }



        }
    }

