using Bz.F8t.WebApp.ApiClients.Dtos;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bz.F8t.WebApp.Models;

public class CompetitionModel
{
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string City { get; set; }

    [Range(-90.0000000, 90.0000000)]
    public decimal Latitude { get; set; }

    [Range(-180.0000000, 180.0000000)]
    public decimal Longitute { get; set; }

    public DateTime StartDate { get; set; } = DateTime.UtcNow;

    public DateTime StartTime { get; set; } = DateTime.UtcNow;

    [Required]
    [Range(0, 1000000)]
    public decimal Distance { get; set; }

    [Required(ErrorMessage = "The Distance Unit field is required.")]
    //[EnumDataType()]
    public string DistanceUnit { get; set; }

    [Required(ErrorMessage = "The Maximum Number Of Competitors field is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The field  Maximum Number Of Competitors must be between {1} and {2}.")]
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
