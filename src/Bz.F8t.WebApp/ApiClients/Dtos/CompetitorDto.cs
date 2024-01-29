namespace Bz.F8t.WebApp.ApiClients.Dtos;

public sealed record CompetitorDto(
    Guid Id,
    Guid CompetitionId,
    string Number,
    string FirstName,
    string LastName,
    DateTime BirthDate,
    string City,
    TimeSpan? NetTime) { }
