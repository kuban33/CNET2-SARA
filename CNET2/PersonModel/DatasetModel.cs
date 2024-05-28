namespace PersonModel;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Address? Address { get; set; }
    public ICollection<Contract> Contracts { get; set; } = new HashSet<Contract>();

    public override string ToString()
    => $"{FirstName} {LastName} {Email} {DateOfBirth.ToString("yyyyMMdd")}";
}

public class LegalEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int RegistrationNumber { get; set; }

    public override string ToString()
    => $"{Name} {RegistrationNumber}";
}

public class Address
{
    public int Id { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
}

public class Contract
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PlateNumber { get; set; }
    public DateTime Signed { get; set; }
    public CarBrand CarBrand { get; set; }
    public string HexColor { get; set; }
}

public enum CarBrand
{
    Skoda,
    Volkswagen,
    MercedesBenz,
    BMW,
    Citroen,
    Peugeot,
    Fiat,
    Ford,
    Toyota,
    Renault,
}