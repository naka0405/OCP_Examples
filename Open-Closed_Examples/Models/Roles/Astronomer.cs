using Open_Closed_Examples.Interfaces;
using Open_Closed_Examples.Models.Roles;

namespace Open_Closed_Ex1.Models.Roles
{
    public class Astronomer : TeamRole
    {
        public Astronomer(IRoleManager manager) : base(manager)
        {
        }

        public override string Description => "observation and processing the odtained information.";

        public override string GetRole()
        {
            return "Astronomer";
        }
    }
}