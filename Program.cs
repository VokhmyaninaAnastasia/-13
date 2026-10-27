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
            if (text.Length == 0)
            {
                return "";
            }

            char firstChar = text[0];
            string result = $"{firstChar}{firstChar}";

            return result + DoubleLettersRecursive(text.Substring(1));
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Практическая работа 13";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("---Программа удвоения символов---");
            Console.WriteLine("Здравствуйте!");

            string userInput = "";

            try
            {
                while (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.Write("Введите строку: ");
                    userInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ошибка! Строка не должна быть пустой.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Попробуйте еще раз.");

                        userInput = "";
                    }
                }

                string result = DoubleLettersRecursive(userInput);

                Console.WriteLine($"Результат: {result}");
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