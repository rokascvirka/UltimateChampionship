using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateChampionship.Characters
{
    public class Referee : Person
    {
        public List<FightStyle> Certificates {  get; set; }
        public Referee(string name, int age, Experience xp, List<FightStyle> certificates) : base(name, age, xp) 
        {
            Certificates = certificates;
        }

        public void ShowCertificates()
        {
            Console.WriteLine("Referee is certified in: " + String.Join(", ", Certificates));
        }
    }
}
