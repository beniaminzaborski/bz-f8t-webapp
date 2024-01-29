using Bz.F8t.WebApp.ApiClients.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Bz.F8t.WebApp.Models;

public class CompetitorRegistrationModel
{
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(150)]
    public string LastName { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    [Required]
    [MaxLength(100)]
    public string City { get; set; }

    [Required]
    [MaxLength(17)]
    public string PhoneNumber { get; set; }

    [Required]
    [MaxLength(17)]
    public string ContactPersonNumber { get; set; }

    public RegistrationRequestDto ToRegistrationRequestDto(Guid competitionId)
    {
        return new RegistrationRequestDto(
            competitionId,
            FirstName,
            LastName,
            BirthDate,
            City,
            PhoneNumber,
            ContactPersonNumber);
    }
}
