namespace _02_bridge;

public class Bridge
{
    public string Name { get; }

    public event EventHandler<BridgeCrossEventArgs> BridgeCross; 

    public Bridge(string name)
    {
        Name = name;
    }
    
    public void Cross(Bike bike)
    {
        OnBridgeCross(new BridgeCrossEventArgs(DateTime.Now, bike.Name));
    }

    protected virtual void OnBridgeCross(BridgeCrossEventArgs eventArgs)
    {
        BridgeCross?.Invoke(this, eventArgs);
    }
}