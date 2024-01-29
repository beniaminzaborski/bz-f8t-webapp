namespace Bz.F8t.WebApp.ApiClients.Dtos;

public sealed record RegistrationRequestDto(
    Guid CompetitionId,
    string FirstName,
    string LastName,
    DateTime BirthDate,
    string City,
    string PhoneNumber,
    string ContactPersonNumber)
{
}
