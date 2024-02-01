namespace Bz.F8t.WebApp.Notifications;

public class CompetitorRegistered
{
    public Guid CompetitorId { get; set; }
    public Guid CompetitionId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public string Number { get; set; }
}
