using Class;

namespace Class
{
    public class Unit
    {

        private float _health;
        public string Name { get; }
        public float Health => _health;
        public Interval DamageUnit { get; set; }


        public Unit() : this(name: "Unknown Unit")
        {
        }
        public Unit(string name)
        {
            Name = name;
            _health = 100f;
            DamageUnit = new Interval(10);
        }
        public Unit(string name, int damageMax) : this(name)
        {
            DamageUnit = new Interval(0, damageMax);
        }

        public float RealHealth()
        {
            return Health * (1 + Armor);
        }
        public float Armor { get; }
        public bool SetDamage(int damage)
        {
            if (Health <= 0f)
            {
                Console.WriteLine("Мертв");
                return false;
            }
            else
            {
                var newHealth = Health - damage;
                if (newHealth <= 0f)
                {
                    return false;
                }
                _health = newHealth;
                return true;
            }

        }


    }
}






namespace Class
{
    public class Weapon
    {
        public string Name { get; }
        public Interval DamageRange { get; set; }


        public Weapon(string name = "Weapon")
        {
            Name = name;
            DamageRange = new Interval(1, 10);
        }
        public Weapon(int minDamag, int maxDamag, string name) : this(name)
        {
            DamageRange = new Interval(minDamag, maxDamag);
        }
        public Weapon (string name, int MaxDamage)
    	{
            Name = name;
            DamageRange = new Interval(maxDamag);
        }
        public double GetDamage()

        {
            return DamageRange.Get;
        }

    }

}







using Class;

    public struct Interval

    private double min;
    private double max;
    private static Random get = new Random();
    public Interval(int minValue, int maxValue)
    {
    if (minValue < 0)
        {
            Console.WriteLine($"Некорректное значение minValue ({minValue}). Заменено на 0.");
            minValue = 0;
        }
        if (maxValue < 0)
        {
            Console.WriteLine($"Некорректное значение maxValue ({maxValue}). Заменено на 0.");
            maxValue = 0;
        }

        // Если minValue больше maxValue, меняем местами и выводим сообщение
        if (minValue > maxValue)
        {
            Console.WriteLine($"Некорректные значения: minValue ({minValue}) больше maxValue ({maxValue}). Меняем местами.");
            int temp = minValue;
            minValue = maxValue;
            maxValue = temp;
        }

        // Если оба числа равны, увеличиваем max на 10 и выводим сообщение
        if (minValue == maxValue)
        {
            Console.WriteLine($"Значения равны ({minValue}). Увеличиваем максимум на 10.");
            maxValue += 10;
        }

        // Установка границ интервала
        this.min = minValue;
        this.max = maxValue;
    }
        public Interval(int maxValue) : this(0, maxValue)
        {
        }
       public double Get
       {
        get
            {
              return get.NextDouble() * (max - min) + min;
            }
        }
}

struct Room
{
    public Unit Unit { get; }
    public Weapon Weapon { get; }

    public Room(Unit unit, Weapon weapon)
    {
        Unit = unit;
        Weapon = weapon;
    }


    class Dungeon
    {
        private Room[] rooms;
        public Dungeon()
        {
            rooms = new Room[]
            {
            new Room(new Unit("Warrior", 100), new Weapon("Sword", 25)),
            new Room(new Unit("Archer", 80), new Weapon("Bow", 15)),
            new Room(new Unit("Mage", 70), new Weapon("Staff", 20))
            };
        }

        // Для проверки можно добавить метод вывода информации о комнатах
        public void PrintRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                Console.WriteLine($"Room {i + 1}:");
                Console.WriteLine($"Unit: {rooms[i].Unit.Name}, Health: {rooms[i].Unit.Health}");
                Console.WriteLine($"Weapon: {rooms[i].Weapon.Name}, Damage: {rooms[i].Weapon.GetDamage}");
            }
        }
    }
