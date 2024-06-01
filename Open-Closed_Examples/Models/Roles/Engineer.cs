using Open_Closed_Examples.Models.Roles;

namespace Open_Closed_Ex1.Models.Roles
{
    public class Engineer : TeamRole
    {
        public override string Description => "some description";

        public override string GetRole()
        {
            return "Board engineer";
        }
    }
}