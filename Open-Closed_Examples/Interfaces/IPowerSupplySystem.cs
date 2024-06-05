namespace Open_Closed_Examples.Interfaces
{
    internal interface IPowerSupplySystem
    {
        string SpecialSwitcher { get; }
        object GetDefinedParameters();
        object GetDefinedParameters(Guid id);
    }
}