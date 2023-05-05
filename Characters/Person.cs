namespace UltimateChampionship.Characters
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Experience Experience { get; set; }

        public Person(string name, int age, Experience experience)
        {
            Name = name;
            Age = age;
            Experience = experience;
        }

        public virtual void ShowInformation()
        {
            Console.WriteLine($"Name: {Name}, age: {Age}, experience: {Experience}");
        }
    }

}
