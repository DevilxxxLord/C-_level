using System;

namespace level_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Задание:
            Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%». 
            Имя пользователя сохранить из консоли в промежуточную переменную. 
            Поставить точку останова и посмотреть значение этой переменной в режиме отладки. 
            Запустить исполняемый файл через системный терминал.
             */
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + ", сегодня " + DateTime.Now.ToString("MM.dd.yyyy"));
        }
    }
}
