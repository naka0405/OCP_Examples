using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.Roles
{
    public abstract class TeamRole
    {
        public abstract string Description { get; }
        public abstract string GetRole();

        IRoleManager? manager { get; }

        public TeamRole()
        {
        }

        public TeamRole(IRoleManager manager)
        {
            this.manager = manager;
        }
    }
}