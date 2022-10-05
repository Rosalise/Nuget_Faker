internal class Program
{
    private static void Main(string[] args)
    {
        var name = Faker.Name.FullName();
        var city = Faker.Address.City();
        var address = Faker.Address.StreetAddress();
        
        var random = new Random();
        var letter = Convert.ToChar(random.Next('A', 'Z')); 

       var tunnus = Faker.RandomNumber.Next(0, 100000000);
    
        
        Console.WriteLine($"Name: {name}. Osoite: {city} {address}. Henkilötunnus: {letter} {tunnus}");
    }
}