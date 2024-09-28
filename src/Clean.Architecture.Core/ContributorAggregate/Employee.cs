namespace CafeInfoApp.Core.ContributorAggregate;
public class Employee
{
    public string Id { get ; set;  }

    public string Name { get; set; }

    public string EmailAddress { get; set; }

    public string PhoneNumber { get; set; }
    public string Gender { get; set; }

    public Employee(string id, string name, string emailAddress, string phoneNumber, string gender)
    {
        Id = id;
        Name = name;
        EmailAddress = emailAddress;
        PhoneNumber = phoneNumber;
        Gender = gender;
    }
}
