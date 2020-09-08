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
        public int Health;
        public int Damage;
        public int Armor;

        public Player(int health, int damage, int armor)
        {
            Health = health;
            Damage = damage;
            Armor = armor;
        }        
        public void ShowStats()
        {
            Console.WriteLine($"Кол-во жизней - {Health}\nУрон -  {Damage}\nСкорость атаки - {Armor}\n");
        }
    }
}
