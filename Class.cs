namespace Class
{
    public class Unit
    {

        private float _health;
        public int _damage;
        public string Name { get; }
        public float Health => _health;
        public int Damage { get; }


        public Unit() : this(name: "Unknown Unit")
        {
        }
           public Unit(string name)
            {
            Name = name;
            }

        public float RealHealth()
        {
            return Health * (1 + Armor);
        }
        public float Armor
        {
            get { return 0.6f;}
        }
        public float SetDamage(int damage)
        {
            if (Health <= 0f)
            {
               Console.WriteLine("Мертв");
               return Health;
            }
            else
            {
                var newHealth = Health - damage + Armor;
                if(newHealth <= 0f)
                {
                    Console.WriteLine("Мертв");
                }
                return newHealth;
            }

        }
        
       
    }
}
