using Open_Closed_Examples.Interfaces;
using Open_Closed_Examples.Models.Roles;

namespace Open_Closed_Examples.Models
{
    public class Astronaut : IAstronaut
    {
        private readonly TeamRole role;
        public Person Person { get; set; }

        public Astronaut(Person person, TeamRole role)
        {
            Person = person;
            this.role = role;
        }

        public string GetRole()
        {
            return role.GetRole();
        }
    }
}