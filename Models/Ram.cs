namespace Garage;

public class Ram  : Vehicle// Gas powered truck
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram with {MaximumOccupancy} people in it just zoomed past you. Rrrrrrummmbbllleee!");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Ram turns left and then right and then left and then right.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Ram rolls to a stop after these confusing directions.");
    }
}