using Open_Closed_Examples.Models.Roles;

namespace Open_Closed_Ex1.Models.Roles
{
    public class AircraftMechanic : TeamRole
    {
        const string roleName = "Aircraft Mechanic";
        public override string Description => "some aircraft mechanic role description";

        public override string GetRole()
        {
            return roleName;
        }
    }
}