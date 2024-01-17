namespace Bz.F8t.WebApp.ApiClients.Dtos;

public sealed record CompetitionPlaceDto(
    string City,
    decimal Latitude,
    decimal Longitute
    ) { }
