using Bz.F8t.WebApp.ApiClients.Dtos;
using Refit;

namespace Bz.F8t.WebApp.ApiClients;

public interface IRegistrationApi
{
    [Post("/api/registration")]
    Task<IApiResponse> RegisterAsync(RegistrationRequestDto dto);

    [Get("/api/competitor/{competitionId}")]
    Task<ApiResponse<IEnumerable<CompetitorDto>>> GetCompetitorsAsync(Guid competitionId);
}
