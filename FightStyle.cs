using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateChampionship
{
    public class FightStyle
    {
        public string Name { get; protected set; }
    }
    public class Boxing : FightStyle
    {

        public Boxing()
        {
            Name = "Boxing";
        }

        public static void GetRuleset()
        {
            Console.WriteLine(Rules.HandStrikes.ToString());
        }
    }

    public class MuayThai : FightStyle
    {
        public MuayThai()
        {
            Name = "Muay Thai";
        }
        public static void GetRuleset()
        {
            List<string> rules = new List<string>
            {
                Rules.HandStrikes.ToString(),
                Rules.Elbows.ToString(),
                Rules.Knees.ToString(),
                Rules.Kicks.ToString()
            };
            Console.WriteLine("Allowed: " + string.Join(", ", rules));

        }
    }

    public class RegularWrestling : FightStyle
    {
        public RegularWrestling()
        {
            Name = "Regular Wrestling";
        }

        public static void GetRuleset()
        {
            List<string> rules = new List<string>
            {
                Rules.NoGiThrows.ToString(),
            };
            Console.WriteLine("Allowed: " + string.Join(", ", rules));
        }
    }

    public class Judo : FightStyle
    {
        public Judo()
        {
            Name = "Judo";
        }
        public static void GetRuleset()
        {
            List<string> rules = new List<string>
            {
                Rules.GiThrows.ToString(),
                Rules.ArmBars.ToString(),
                Rules.Chokes.ToString(),
            };
            Console.WriteLine("Allowed: " + string.Join(", ", rules));
        }

    }

    public class JuJitsu : FightStyle
    {
        public JuJitsu()
        {
            Name = "Ju-Jitsu";
        }
        public static void GetRuleset()
        {
            List<string> rules = new List<string>
            {
                Rules.Chokes.ToString(),
                Rules.LegLocks.ToString(),
                Rules.ArmBars.ToString(),
                Rules.NoGiThrows.ToString(),
                Rules.GiThrows.ToString()
            };
            Console.WriteLine("Allowed: " + string.Join(", ", rules));
        }
    }

}
