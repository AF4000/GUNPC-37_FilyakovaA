namespace Class
{
    public class Unit
    {
        private const double V = 0.6;
        private const int F = 5;

        private float _health;
        public float _armor;
        public int _damage;
        public string Name { get; }
        public float Health => _health;
        public int Damage = F;


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
            get { return (float)Math.Round(_armor, 2); }
            set
            {
                if (value >= 0 || value <= 1)
                {
                    _armor = value;
                }
                else
                {
                    _armor = (float) V;
                }
            }
        }
        public bool SetDamage(int damage)  // пришлите пожалуйста правильное решение, не смогла сообразить как сделать
        {
            if (Health - damage <= 0f)
            {
                Console.WriteLine("Мертв");
            }
            else (Health - damage > 0f)
            {
            return Health - value * Armor;
            }
        }
       
    }
}
