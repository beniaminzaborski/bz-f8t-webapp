namespace Bz.F8t.WebApp.ApiClients.Dtos;

public sealed record CompetitionDto(
    Guid Id,
    DateTime StartAt,
    DistanceDto Distance,
    CompetitionPlaceDto Place,
    int MaxCompetitors,
    string Status,
    IEnumerable<CheckpointDto> Checkpoints)
{ }
