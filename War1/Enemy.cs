namespace War1
{
    class EnemyOrk : Player
    {
       public EnemyOrk()
        {
            name = "Орк";
            health = 50;
            damage = 5;
            power = 5;
            dexterity = 2;
            intelligence = 1;
            defence = 5;
        }
        public void Attack(Player player, EnemyOrk ork)
        {
            Console.WriteLine($"Атакует {this.Name} наносит {this.damage} урона!"); ;
            if (player.defence >= ork.damage) Console.WriteLine("Весь урон заблокирован!");
            else
            {
                player.health -= ork.damage - player.defence;
            }
        }
    }

}
