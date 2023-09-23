namespace War1
{
    class Player
    {
        public string? nameclass;
        public string? name;
        public string? raca;
        public int health;
        public int damage;
        public int power;
        public int dexterity;
        public int intelligence;
        public int defence;

        public string? NameClass
        {
            get { return nameclass; }
            set { nameclass = value; }
        }
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        public string? Raca
        {
            get { return raca; }
            set { raca=value;  }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Damage 
        {
            get { return damage; }
            set { damage = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public int Dexterity 
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        public int Intelligence 
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        public int Defence
        {
            get { return defence; }
            set { defence = value; }    
        }
        public Player ()
        {
            Name = name;
            NameClass = nameclass;
            Health = 100;
            Damage = 0;
            Power = 0;
            Dexterity = 0;
            Intelligence = 0;
            Defence = 0;
        }
        public void Attack(EnemyOrk enemy, Player player)
        {
            Console.WriteLine($"Атакует {this.Name} наносит {this.damage} урона!"); ;
            if (enemy.defence >= player.damage) Console.WriteLine("Весь урон заблокирован!");
            else
            {
                enemy.Health -= player.damage - enemy.defence;
            }
        }
        public void SpecialAttack()
        {

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя {this.Name}\nРаса { this.Raca}\nКласс {this.NameClass}\nЗдоровье {this.Health}\nЗащита {this.Defence}\nУрон {this.Damage}\nСила {this.Power}\nЛовкость {this.Dexterity}\nИнтелект {this.Intelligence}\n ");
        }
        public void HealthInfo()
        {
            Console.WriteLine($"Здоровье {this.Name} {this.Health}");
        }
    }
}
