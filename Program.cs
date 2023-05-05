using UltimateChampionship.Characters;

namespace UltimateChampionship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FightStyle judo = new Judo();
            Fighter fighter1 = new Fighter("Rokas", 27, Experience.Proffesional, judo, JudoStyles.Russian);

            Judo.GetRuleset();
            fighter1.Train();
            fighter1.ShowInformation();
            fighter1.ShowFightStyle();
            Console.WriteLine(Fighter.TotalFighters);
        }
    }
}