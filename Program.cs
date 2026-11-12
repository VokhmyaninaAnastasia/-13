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

            char firstChar = text[0]; // получение первого символа
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
            bool repeat = true;

            do
            {
                try
                {
                    userInput = String.Empty; // сбрасываем перед новым вводом
                    while (String.IsNullOrWhiteSpace(userInput)) 
                    {
                        Console.Write("Введите строку: ");
                        userInput = Console.ReadLine();

                        if (String.IsNullOrWhiteSpace(userInput))
                        {
                            throw new ArgumentException("Строка не должна быть пустой.");
                        }
                    }
                    string result = DoubleLettersRecursive(userInput);
                    Console.WriteLine($"Результат: {result}"); 
                }
                catch (ArgumentException aex)
                {
                    HandleError(aex);
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
                Console.Write("\nХотите продолжить выполнять программу? (да/нет) ");
                string answer = Console.ReadLine();
                repeat = (answer == "да" || answer == "д");

            } while (repeat);

            Console.ReadKey();
        }
        static void HandleError(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Ошибка: " + ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
