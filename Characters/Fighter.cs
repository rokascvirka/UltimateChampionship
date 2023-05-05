namespace UltimateChampionship.Characters
{
    public class Fighter : Person
    {
        public FightStyle FightStyle { get; set; }
        public Enum SubStyle { get; set; }

        public static int TotalFighters { get; private set; }

        public Fighter(string name, int age, Experience xp, FightStyle fightStyle, Enum subStyle) : base(name, age, xp)
        {
            FightStyle = fightStyle;
            SubStyle = subStyle;
            TotalFighters++;
        }

        public void Train()
        {
            Random random = new Random();
            Console.WriteLine($"{Name} trains {random.Next(1,10)} days per week");
        }

        public void ShowFightStyle()
        {
            Console.WriteLine($"Fighter's fighting style is based on {SubStyle}");
        }
    }

}
