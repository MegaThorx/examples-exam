namespace _02_bridge;

public class BridgeLogEntry
{
    public string BridgeName { get; }
    
    public string BikeName { get; }
    
    public DateTime DateTime { get; }

    public BridgeLogEntry(string bridgeName, string bikeName, DateTime dateTime)
    {
        BridgeName = bridgeName;
        BikeName = bikeName;
        DateTime = dateTime;
    }

    public override string ToString()
    {
        return $"Bridge: {BridgeName}, Bike: {BikeName}, DateTime: {DateTime}";
    }
}