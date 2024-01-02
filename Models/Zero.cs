namespace Garage;

public class Zero : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero with {MaximumOccupancy} people in it just zoomed past you. Zoooooooom!");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Zero turns left.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Zero stops after about a quarter of a mile down the road.");
    }

}