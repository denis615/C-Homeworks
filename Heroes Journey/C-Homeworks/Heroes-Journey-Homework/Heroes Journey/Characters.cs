namespace Heroes_Journey
{
    public class Dwarf
    {
        public static string Name = "Dwarf";
        public static string Description = "Dwarf has 100 Health, 6 Strenght, and 2 Agility";
        public static int Health = 100;
        public static int Strength = 6;
        public static int Agility = 2;
    }




    public class Elf
    {
        public static string Name = "Elf";
        public static string Description = "Elf Has 60 Healht, 4 Strenth, and 6 Agility";
        public static int Health = 60;
        public static int Strength = 4;
        public static int Agility = 6;


    }

    public class Human
    {
        public static string Name = "Human";
        public static string Description = "Human has 80 Health, 5 Strenth, and 4 Agility";
        public static int Health = 80;
        public static int Strength = 5;
        public static int Agility = 4;
    }

    public class CharacterBuilt
    {
        public static string Name;
        public static string Description;
        public static int Health;
        public static int Strength;
        public static int Agility;
    }


    public class Event1
    {
        public static string Description = "Bandits Attack you out of nowheere they seem very dangerous";
        public static int HealthEvent = 20;
    }
    public class Event2
    {
        public static string Description = "You Bump in to one of the Guards in the nearby village. They attack you without warning";
        public static int HealthEvent = 30;
    }
    public class Event3
    {
        public static string Description = "A Land Shark Appears. It starts chasing you down to eat you...";
        public static int HealthEvent = 50;
    }
    public class Event4
    {
        public static string Description = "You Accidentally step on a rat. His friends are not happy. They Attack";
        public static int HealthEvent = 10;
    }
    public class Event5
    {
        public static string Description = "You find a huge rock. It comes alive somehow and tries to smash you..";
        public static int HealthEvent = 30;
    }
}

