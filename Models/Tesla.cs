namespace Garage;

public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla with {MaximumOccupancy} people in it just zoomed past you. Vrooooom!");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Tesla turns left and then goes straight.");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla never stops. It just keeps driving forever.");
    }

}