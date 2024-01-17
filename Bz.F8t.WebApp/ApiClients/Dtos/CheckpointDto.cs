namespace Bz.F8t.WebApp.ApiClients.Dtos;

public sealed record CheckpointDto(
    Guid Id,
    decimal TrackPointAmount,
    string TrackPointUnit
    ) { }
