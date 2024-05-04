namespace _02_bridge;

public class BridgeLogger
{
    private List<BridgeLogEntry> _logEntries = new List<BridgeLogEntry>();

    public IEnumerable<BridgeLogEntry> LogEntries => _logEntries;
    
    public void Register(Bridge bridge)
    {
        bridge.BridgeCross += BridgeOnBridgeCross;
    }
    
    public void Unregister(Bridge bridge)
    {
        bridge.BridgeCross -= BridgeOnBridgeCross;
    }

    private void BridgeOnBridgeCross(object? sender, BridgeCrossEventArgs eventArgs)
    {
        if (sender is Bridge)
        {
            Bridge bridge = (Bridge)sender;
            
            _logEntries.Add(new BridgeLogEntry(bridge.Name, eventArgs.BikeName, eventArgs.DateTime));   
        }
    }
}