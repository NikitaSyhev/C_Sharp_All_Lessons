using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Gamers
    {
        
        static private int myRandom()   //метод рандомайзера
        {
            Random random = new Random();
            var currentTime = DateTime.Now.Millisecond;
            int Number = currentTime;
            Number *= Number;
            int _myRandom = 1 + random.Next(Number) % 100;
            return _myRandom;

        }

        static private int myRandomNumberTeams()   //метод рандомайзера для номера команды ( от 0 до 1 )
        {
            Random random = new Random();
            var currentTime = DateTime.Now.Millisecond;
            int Number = currentTime;
            Number *= Number;
            int _myRandom = 0 + random.Next(Number) % 1;  
            return _myRandom;

        }
        public Gamers()  //конструктор
        {
            name = "Gamer_NoName";
            coin =  myRandom();
            honor = 100;
            luckiness = myRandom();
            teamNumber = myRandomNumberTeams(); // по умолчанию назначаем номер либо 0 либо 1 и там распределяем по командам
            // сюда добавялем параметр, который относит человека к команде, а затем в методе CreateGamers мы просто рандомно разобьем по командам
        }
        //

        private int teamNumber;

        public int _teamNumber // свойства
        {
            get { return teamNumber; }
            set { teamNumber = value; }
        }

        private string name;
        public string _name // свойства
        {
            get { return name; }
            set { name = value; } 
        }
        private int coin;

        public int _coin // свойство
        {
            get { return coin; }
            set { coin = value; }
        }
        private int honor;

        public int _honor// свойство
        {
            get { return honor; }
            set { honor = value; }
        }
        public int luckiness; //добавили параметр "везучесть"

        public int _luckiness
        {
            get { return luckiness; }
            set { luckiness = value; }
        }

        public static bool operator <(Gamers player1, Gamers player2) // перегрузка операторо
        {
            if (player1._coin == player2._coin)
            {
                return player1._honor < player2._honor;
            }
            else if (player1._honor == player2._honor)
            {
                return player1._coin < player2._coin;
            }
            else if (player1._coin < player2._coin)
                return player1._honor > player2._honor;
            else if (player1._coin > player2._coin)
            {
                return player1._honor < player2._honor;
            }
            else
                return player1._coin * player1._honor < player2._coin * player2._honor;
        }
        public static bool operator >(Gamers player1, Gamers player2) // перегрузка операторо
        {
            if (player1._coin == player2._coin)
            {
                return player1._honor > player2._honor;
            }
            else if (player1._honor == player2._honor)
            {
                return player1._coin > player2._coin;
            }
            else if (player1._coin < player2._coin)
                return player1._honor < player2._honor;
            else if (player1._coin > player2._coin)
            {
                return player1._honor > player2._honor;
            }
            else
                return player1._coin * player1._honor > player2._coin * player2._honor;
        }

       
    }
}
