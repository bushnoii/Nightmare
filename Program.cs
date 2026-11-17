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
        }



        }
    }

