using Bz.F8t.WebApp.ApiClients.Dtos;

namespace Bz.F8t.WebApp.Models;

public class CompetitionModel
{
    public Guid Id { get; set; }
    public string City { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitute { get; set; }
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime StartTime { get; set; } = DateTime.UtcNow;
    public decimal Distance { get; set; }
    public string DistanceUnit { get; set; }
    public int MaxNumberOfCompetitors { get; set; }

    public static CompetitionModel FromCompetitionDto(CompetitionDto dto)
    {
        return new CompetitionModel
        { 
            Id = dto.Id,
            City = dto.Place.City,
            Latitude = dto.Place.Latitude,
            Longitute = dto.Place.Longitute,
            StartDate = dto.StartAt,
            StartTime = dto.StartAt,
            Distance = dto.Distance.Amount,
            DistanceUnit = dto.Distance.Unit,
            MaxNumberOfCompetitors = dto.MaxCompetitors
        };
    }

    public CreateCompetitionDto ToCreateCompetitionDto()
    {
        return new CreateCompetitionDto(
            new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, StartTime.Hour, StartTime.Minute, 00),
            new DistanceDto(Distance, DistanceUnit),
            new CompetitionPlaceDto(City, Latitude, Longitute),
            MaxNumberOfCompetitors);
    }
}
