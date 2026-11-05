//*************************************************************************************
//*Практическая работа №13                                                            *
//* Выполнила: Вохмянина А.Р., группа 2-ИСП                                           *
//* Задание: разработка программ с применением рекурсивных функций                    *
//*************************************************************************************
using System;

namespace работа_13
{
    class Program
    {
        static string DoubleLettersRecursive(string text)
        {
            if (text.Length == 0) // условие остановки рекурсии
            {
                return "";
            }

            char firstChar = text[0]; // полуячение первого символа
            string result = $"{firstChar}{firstChar}"; // удвоение символа

            return result + DoubleLettersRecursive(text.Substring(1)); // рекурсивный вызов
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Практическая работа 13";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("---Программа удвоения символов---");
            Console.WriteLine("Здравствуйте!");

            string userInput = String.Empty; 

            try
            {
                while (String.IsNullOrWhiteSpace(userInput)) // проверка ввода
                {
                    Console.Write("Введите строку: ");
                    userInput = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(userInput))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ошибка! Строка не должна быть пустой.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Попробуйте еще раз.");

                        userInput = String.Empty;
                    }
                }

                string result = DoubleLettersRecursive(userInput); // вызов рекурсивной функции

                Console.WriteLine($"Результат: {result}"); // вывод результата
            }
            catch (ArgumentException aex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка аргумента: " + aex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Непредвиденная ошибка: " + ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ReadKey();
        }
    }
}

}
