var car = new Car("BMW","M5 F90",2023);
car.Make = "BMW";
car.Model = "M5 F90";
car.Year = 2023;
car.Mileage = 150;
car.Fuel = 3;
car.Drive(100);
car.AddFuel(60);


public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Mileage { get; set; }
    public double Fuel { get; set; }
    public Car(string make,string model,int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    public void Drive(double miles)
    {
        if(Mileage < 10)
        {
            System.Console.WriteLine("Zapravka kardan darkor");
        }
        else
        {
            Mileage ++;
        }
    }
    public void AddFuel(double gallons)
    {
        Fuel += gallons;
    }



}