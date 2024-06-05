using Open_Closed_Examples.Interfaces;
namespace Open_Closed_Examples.Models
{
    public class Person : IPerson
    {
        private int age;
        public string Name { get; set; }
        
        public Person(string name, int age)
        {
            this.age = age;
            Name = name;
        }

        public string GetPersonData()
        {
            return $"I'm {Name}. {age} years old.";
        }
    }
}