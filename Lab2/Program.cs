using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        public int _age;
        static void Main(string[] args)
        {
            Program program = new Program();
            program._age = 4;
            int age = program._age;
            Cat cat = new Cat();
            Heir heir = new Heir();
        link:
            Console.WriteLine("Порода кошки: " + heir.BreedMetod());
            Console.WriteLine("Срок жизни: " + heir.TermLifeMetod());
            Console.WriteLine("Текущий возраст: " + age);
            Console.WriteLine("Прибавить '1' к возрасту?  y/n");
            var userVariable = Convert.ToString(Console.ReadLine());
            if (CheckMetod(userVariable) == 1)
            {
                age++;
                goto link;
            }
            if (CheckMetod(userVariable) == 0)
                goto link;
            if (CheckMetod(userVariable) == 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введенная строка имела неверный формат");
                Console.ResetColor();
                goto link;
            }
        }
        static int CheckMetod(string userVariable)
        {
            if (userVariable == "y")
                return 1;
            if (userVariable == "n")
                return 0;
            else
                return 10;
        }
    }
    class Cat
    {
        #region поля и инкапсуляция
        public string _breed; // порода
        public int _termLife; // срок жизни
        #region инкасулирование
        public string breed
        {
            get; set;
        }
        public int termLife
        {
            get; set;
        }
        #endregion
        #endregion
        #region перегруженные конструкторы
        public Cat() { }
        public Cat(string _breed)
        {
            this._breed = _breed;
        }
        public Cat(int _termLife)
        {
            this._termLife = _termLife;
        }
        #endregion
        #region методы (Статичные и виртуальные)
        public virtual string BreedMetod()
        {
            return "Канаани";
        }
        public virtual int TermLifeMetod()
        {
            return 14;
        }
        #endregion
    }
    class Heir : Cat
    {
    }
}
