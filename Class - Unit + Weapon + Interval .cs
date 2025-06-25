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
            Armor = 0.6f;
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
        private int MinDamage { get; set; }
        private int MaxDamage { get; set; }
        public float Durability { get; } // Durability в задании указано свойство, но дальше оно никак не используется. Лишняя строка в задаче???


        public Weapon( string name = "Weapon")
        {
            Name = name;
        }
        public Weapon(int minDamag, int maxDamag, string name) : this(name)
        {
            MinDamage = minDamag;
            MaxDamage = maxDamag;
            Name = name; 
        }
            public Weapon SetDamageParams(int minDamag, int maxDamag) // ошибка не все пути к коду возвращают значение, не понимаю почему так, распишите пожалуйста подробнее
        {
            if (minDamag > maxDamag)
            {
                MaxDamage = minDamag;
                MinDamage = maxDamag;
                Console.WriteLine("Введены некорректные данные урона оружия Weapon");

            }
            if (minDamag > 1) // изменила условие, тз оно не противоречит, но мне так более понятно 
            {
                {
                    MinDamage = minDamag;
                }
                    minDamag = (int)1f;
                    Console.WriteLine("Введены дефолтные значения минимального урона");
            }
            if (maxDamag <= 1)
            { 
                maxDamag = 10;
                Console.WriteLine("Введены дефолтные значения максимального урона");
            }
            MaxDamage = maxDamag;
        }
        public Weapon GetDamage(int realdamag) // ошибка не все пути к коду возвращают значение, не понимаю почему так, распишите пожалуйста подробнее
        {
           realdamag = (MinDamage + MaxDamage) / 2;
        }


    }
    
}







using Class;

    struct Interval // зачем эта структура, какая ее функция в целом в данном коде? почему нельзя без нее?
    {
        private double min;
        private double max;
        private Random get;

        public double Min => min;
        public double Max => max;
        public double Get => get.NextDouble() * (max - min) + min;
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
    }

    struct Room
    {
    public Unit Unit { get; }
    public Weapon Weapon { get;}

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
                Console.WriteLine($"Weapon: {rooms[i].Weapon.Name}, Damage: {rooms[i].Weapon.Damage}");
            }
        }
}
