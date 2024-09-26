namespace Clean.Architecture.Core.ContributorAggregate;

public class Contributor
{
    public int Id { get; set; }
    public Contributor(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
    public ContributorStatus Status { get; private set; } = ContributorStatus.NotSet;
    public PhoneNumber? PhoneNumber { get; private set; }

}

public class PhoneNumber(string countryCode,
  string number,
  string? extension) //: ValueObject
{
    public string CountryCode { get; private set; } = countryCode;
    public string Number { get; private set; } = number;
    public string? Extension { get; private set; } = extension;

}
