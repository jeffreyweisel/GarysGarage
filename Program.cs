using Garage;


Zero fxs = new Zero
{
    MainColor = "Red",
    MaximumOccupancy = 2
};
Tesla modelS = new Tesla
{
    MainColor = "Blue",
    MaximumOccupancy = 5
};
Cessna mx410 = new Cessna
{
    MainColor = "Black",
    MaximumOccupancy = 98
};
Ram bigHorn = new Ram
{
    MainColor = "White",
    MaximumOccupancy = 6
};

Console.WriteLine("Welcome to Garys Garage!");

fxs.Drive();
fxs.Turn();
fxs.Stop();
Console.WriteLine("");

modelS.Drive();
modelS.Turn();
modelS.Stop();
Console.WriteLine("");

mx410.Drive();
mx410.Turn();
mx410.Stop();
Console.WriteLine("");

bigHorn.Drive();
bigHorn.Turn();
bigHorn.Stop();