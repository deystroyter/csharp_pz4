using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FedorovAD_Pz4
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterBD();
            Console.ReadLine();
        }

        /// <summary>
        /// Функиция выбора БД
        /// </summary>
        static void EnterBD()
        {
           EnterBDStart:
            Console.WriteLine("Выберите СУБД для работы (Oracle, MySQL, PostgreSQL):");
            string database = Console.ReadLine();
            Database userDatabase;
            try
            {
                switch (database.ToLower())
                {
                    case "oracle":
                        userDatabase = new Oracle();
                        EnterOperations(userDatabase);
                        break;
                    case "mysql":
                        userDatabase = new MySQL();
                        EnterOperations(userDatabase);
                        break;
                    case "postgresql":
                        userDatabase = new PostgreSQL();
                        EnterOperations(userDatabase);
                        break;
                    case "":
                        Console.WriteLine("Вы ввели пустую строку!\n");
                        goto EnterBDStart;
                    default:
                        Console.WriteLine("Вы ввели явно что-то не то...Попробуйте ещё раз!\n");
                        goto EnterBDStart;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        /// <summary>
        /// Функция выбора операций с БД
        /// </summary>
        /// <param name="userDb">Выбранная пользователем БД</param>
        static void EnterOperations(Database userDb)
        {
            EnterOperationsStart:

            Console.WriteLine("Введите номера операций через пробел:");
            Console.WriteLine("1.---Создать таблицу\n2.---Изменить таблицу\n3.---Удалить таблицу\n4.---Создать представление\n5.---Изменить представление\n6.---Удалить представление\n7.---Создать индекс\n8.---Удалить индекс\n9.---Добавить ограничение\n10.---Удалить ограничение\n");
            Console.ResetColor();
            string operationsStr = Console.ReadLine();
            if (operationsStr.Length < 1)
            {
                Console.WriteLine("Вы ввели пустую строку!\n");
                goto EnterOperationsStart;
   
            }
            string[] operationsArr = operationsStr.Split(' ');
            foreach (string operation in operationsArr)
            {
                switch (operation)
                {
                    case "1":
                        userDb.CreateTable();
                        break;
                    case "2":
                        userDb.AlterTable();
                        break;
                    case "3":
                        userDb.DropTable();
                        break;
                    case "4":
                        userDb.CreateView();
                        break;
                    case "5":
                        userDb.AlterView();
                        break;
                    case "6":
                        userDb.DropView();
                        break;
                    case "7":
                        userDb.CreateIndex();
                        break;
                    case "8":
                        userDb.DropIndex();
                        break;
                    case "9":
                        userDb.AddConstraint();
                        break;
                    case "10":
                        userDb.DeleteConstraint();
                        break;
                    default:
                        throw new ArgumentException($"Команды под номером ({int.Parse(operation)}) не существует!");
                }

            }

        }

    }
}
