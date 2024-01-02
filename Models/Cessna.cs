namespace Garage;

public class Cessna : Vehicle// Propellor light aircraft
{
    public double FuelCapacity { get; set; }
    

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna with {MaximumOccupancy} people in it just zoomed past you. Whooooosh!");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Cessna turns around because its going the wrong way!");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Cessna comes to a complete stop on the runway");
    }
}