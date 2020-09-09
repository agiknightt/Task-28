using System;

namespace Task_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(1000, 76, 50);

            player.ShowStats();

            Console.ReadKey();
        }
    }
    class Player
    {
        private int _health;
        private int _damage;
        private int _armor;

        public Player(int health, int damage, int armor)
        {
            _health = health;
            _damage = damage;
            _armor = armor;
        }        
        public void ShowStats()
        {
            Console.WriteLine($"Кол-во жизней - {_health}\nУрон -  {_damage}\nСкорость атаки - {_armor}\n");
        }
    }
}
