using _02_bridge;

BridgeLogger bridgeLogger = new BridgeLogger();
Bridge bridge1 = new Bridge("Bridge 1");
Bridge bridge2 = new Bridge("Bridge 2");
bridgeLogger.Register(bridge1);
bridgeLogger.Register(bridge2);
Bike bike1 = new Bike("Bike 1");
Bike bike2 = new Bike("Bike 2");
Bike bike3 = new Bike("Bike 3");
bridge1.Cross(bike1);
bridge1.Cross(bike2);
bridge1.Cross(bike3);
bridge2.Cross(bike1);
bridgeLogger.Unregister(bridge2);
bridge2.Cross(bike2);
bridge2.Cross(bike3);


Console.WriteLine(string.Join('\n', bridgeLogger.LogEntries));
