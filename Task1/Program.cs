var person = new Person();
person.FirstName = "Mustafo";
person.LastName = "Barotov";
person.Address = "33";
person.Age = 16;
person.GetFullName();
person.GetBirthYear();

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string GetFullName()
    {
        return $"My name is {FirstName} {LastName}";
    }
    public int GetBirthYear()
    {
        return 2024 - Age;
    }
}