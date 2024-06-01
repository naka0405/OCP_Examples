using Helper;
using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples
{
    public class TechicalService
    {
        public void Check(IValidMachine machine)
        {
            machine.IsValid = Utils.GetBoolRandomValue();
        }
    }
}