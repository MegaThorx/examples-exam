namespace _02_bridge;

public class BridgeCrossEventArgs : EventArgs
{
    public DateTime DateTime { get; }

    public string BikeName { get; }

    public BridgeCrossEventArgs(DateTime dateTime, string bikeName)
    {
        DateTime = dateTime;
        BikeName = bikeName;
    }
}