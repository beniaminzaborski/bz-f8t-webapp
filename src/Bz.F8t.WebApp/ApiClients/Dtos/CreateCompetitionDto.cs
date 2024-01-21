namespace Bz.F8t.WebApp.ApiClients.Dtos;

public sealed record CreateCompetitionDto(
    DateTime StartAt,
    DistanceDto Distance,
    CompetitionPlaceDto Place,
    int MaxCompetitors)
{
}
