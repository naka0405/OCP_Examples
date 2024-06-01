namespace Open_Closed_Examples.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name)
        {
            Name = name;
        }
    }
}
