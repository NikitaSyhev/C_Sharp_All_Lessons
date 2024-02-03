using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Комментарий по заданию
//1.Вынести класс Gamers в отдельный файл.   - готово
//2. Добавить параметр "везучесть" (определяется случайным образом).   - готово
//3.Сформировать метод набора до 8 игроков - готово
//4. Создать метод, объединяющий игроков в команды. При объединении формируется имя команды, складываются монеты и доблесть, перемножается везучесть.
// готово
//5. Программа должна сэмулировать столкновение 2-х команд и сравнить их суммарные параметры. При прочих равных сравнивается везучесть.
// - готово


namespace Homework8

{
    internal class Program

    {
      
        public List<Gamers> createGamers(int _numberOfGamers)  // класс создания геймеров, который возвразает List, чтобы использовать в дальнейшем 
        {
            List<Gamers> gamers = new List<Gamers>(); // создали list для записи игроков
            
            if (_numberOfGamers > 0 && _numberOfGamers < 9)
            {
               
                for (int i = 1; i <= _numberOfGamers; i++)
                {
                    Gamers gamer = new Gamers();
                    gamers.Add(gamer); 
                };
                return gamers;
            }
            else

                Console.WriteLine("Мы можем создать максимум 8 игроков");
            return gamers;
        }

        static void Main(string[] args)
        {

            string name01, name02;
            try // если имена передаем аргументами
            {
                name01 = args[0];
                name02 = args[1];
            }
            catch // имена вводим через консоль
            {
                Console.WriteLine("Введите имя 1-го игрока");
                name01 = Console.ReadLine();
                Console.WriteLine("Введите имя 2-го игрока");
                name02 = Console.ReadLine();
            }

            Gamers gamer01 = new Gamers(); // создаем объект класса
            gamer01._name = name01; // присваиваем имя
            Gamers gamer02 = new Gamers();
            gamer02._name = name02;
            Console.WriteLine(



                "1-й игрок {0} имеет {2} монет, {4} доблести\n" + // добавил вывод доблести
                "2-й игрок {1} имеет {3} монет, {5} доблести",
                gamer01._name, gamer02._name, gamer01._coin, gamer02._coin, gamer01._honor, gamer02._honor); ;
            if (gamer01 > gamer02)
            {
                Console.WriteLine("Игрок {0} успешней игрока {1}", gamer01._name, gamer02._name);
            }
            else
            {
                if (gamer01 < gamer02)
                {
                    Console.WriteLine("Игрок {1} успешней игрока {0}", gamer01._name, gamer02._name);
                }
                else
                {
                    Console.WriteLine("Игрок {1} равен игроку {0}", gamer01._name, gamer02._name);
                }
                Console.WriteLine("\n");
                Console.WriteLine("Дополнительные задания: создать игроков и команду.\n");

                Console.WriteLine("Введите количество игроков: ");
                string input = Console.ReadLine(); ;
                int numberOfPlayers = Convert.ToInt32(input); // считали строку и преобразовали ее в int
                Program program = new Program();
                List<Gamers> gamers = new List<Gamers>(program.createGamers(numberOfPlayers)); // сюда записали игроков

                {
                        if (numberOfPlayers > 0 && numberOfPlayers < 9)
                        {
                            Console.WriteLine($"Сейчас мы создадим {numberOfPlayers} игроков");
                            foreach (Gamers gamer in gamers)
                            {
                                Console.WriteLine($"Мы создали {gamer._name}");
                            }
                        }
                       else
                        {
                            Console.WriteLine("Мы можем создать максимум 8 игроков.\n Введите число еще раз.");
                        }


                    Teams team1 = new Teams(); // создали объекты класса команд
                    Teams team2 = new Teams();
                    team1.createTeams(gamers);
                    team1.buttleTeams();



                    Console.ReadLine();
                }
            }

        }

    }
}