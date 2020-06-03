using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedorovAD_Pz4
{
    interface Database
    {
        /// <summary>
        /// Функция создания таблицы в БД
        /// </summary>
        bool CreateTable();
        /// <summary>
        /// Функция изменения таблицы в БД
        /// </summary>
        bool AlterTable();
        /// <summary>
        /// Функция удаления таблицы из БД
        /// </summary>
        bool DropTable();
        /// <summary>
        /// Функция для создания представления
        /// </summary>
        bool CreateView();
        /// <summary>
        /// Функция для изменения представления
        /// </summary>
        bool AlterView();
        /// <summary>
        /// Функция для удаления представления
        /// </summary>
        bool DropView();
        /// <summary>
        /// Функция для создания индекса
        /// </summary>
        bool CreateIndex();
        /// <summary>
        /// Функция для удаления индекса
        /// </summary>
        bool DropIndex();
        /// <summary>
        /// Функция для добавления ограничения
        /// </summary>
        bool AddConstraint();
        /// <summary>
        /// Функция для удаления ограничения
        /// </summary>
        bool DeleteConstraint();
    }

    /// <summary>
    /// Класс для работы с MySQL
    /// </summary>
    class MySQL : Database
    {
        public bool CreateTable()
        {
            Console.WriteLine("MySQL | CreateTable() is done!");
            return true;
        }
        public bool AlterTable()
        {
            Console.WriteLine("MySQL | AlterTable() is done!");
            return true;
        }
        public bool DropTable()
        {
            Console.WriteLine("MySQL | DropTable() is done!");
            return true;
        }
        public bool CreateView()
        {
            Console.WriteLine("MySQL | CreateView() is done!");
            return true;
        }
        public bool AlterView()
        {
            Console.WriteLine("MySQL | AlterView() is done!");
            return true;
        }
        public bool DropView()
        {
            Console.WriteLine("MySQL | DropView() is done!");
            return true;
        }
        public bool CreateIndex()
        {
            Console.WriteLine("MySQL | CreateIndex() is done!");
            return true;
        }
        public bool DropIndex()
        {
            Console.WriteLine("MySQL | DropIndex() is done!");
            return true;
        }
        public bool AddConstraint()
        {
            Console.WriteLine("MySQL | AddConstraint() is done!");
            return true;
        }
        public bool DeleteConstraint()
        {
            Console.WriteLine("MySQL | DeleteConstraint() is done!");
            return true;
        }
    }

    /// <summary>
    /// Класс для работы с Oracle
    /// </summary>
    class Oracle : Database
    {
        public bool CreateTable()
        {
            Console.WriteLine("Oracle | CreateTable() is done!");
            return true;
        }
        public bool AlterTable()
        {
            Console.WriteLine("Oracle | AlterTable() is done!");
            return true;
        }
        public bool DropTable()
        {
            Console.WriteLine("Oracle | DropTable() is done!");
            return true;
        }
        public bool CreateView()
        {
            Console.WriteLine("Oracle | CreateView() is done!");
            return true;
        }
        public bool AlterView()
        {
            Console.WriteLine("Oracle | AlterView() is done!");
            return true;
        }
        public bool DropView()
        {
            Console.WriteLine("Oracle | DropView() is done!");
            return true;
        }
        public bool CreateIndex()
        {
            Console.WriteLine("Oracle | CreateIndex() is done!");
            return true;
        }
        public bool DropIndex()
        {
            Console.WriteLine("Oracle | DropIndex() is done!");
            return true;
        }
        public bool AddConstraint()
        {
            Console.WriteLine("Oracle | AddConstraint() is done!");
            return true;
        }
        public bool DeleteConstraint()
        {
            Console.WriteLine("Oracle | DeleteConstraint() is done!");
            return true;
        }
    }

    /// <summary>
    /// Класс для работы с PostgreSQL
    /// </summary>
    class PostgreSQL : Database
    {
        public bool CreateTable()
        {
            Console.WriteLine("PostgreSQL | CreateTable() is done!");
            return true;
        }
        public bool AlterTable()
        {
            Console.WriteLine("PostgreSQL | AlterTable() is done!");
            return true;
        }
        public bool DropTable()
        {
            Console.WriteLine("PostgreSQL | DropTable() is done!");
            return true;
        }
        public bool CreateView()
        {
            Console.WriteLine("PostgreSQL | CreateView() is done!");
            return true;
        }
        public bool AlterView()
        {
            Console.WriteLine("PostgreSQL | AlterView() is done!");
            return true;
        }
        public bool DropView()
        {
            Console.WriteLine("PostgreSQL | DropView() is done!");
            return true;
        }
        public bool CreateIndex()
        {
            Console.WriteLine("PostgreSQL | CreateIndex() is done!");
            return true;
        }
        public bool DropIndex()
        {
            Console.WriteLine("PostgreSQL | DropIndex() is done!");
            return true;
        }
        public bool AddConstraint()
        {
            Console.WriteLine("PostgreSQL | AddConstraint() is done!");
            return true;
        }
        public bool DeleteConstraint()
        {
            Console.WriteLine("PostgreSQL | DeleteConstraint() is done!");
            return true;
        }
    }
}
