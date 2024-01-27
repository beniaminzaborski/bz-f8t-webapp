using Bz.F8t.WebApp.ApiClients.Dtos;
using Refit;

namespace Bz.F8t.WebApp.ApiClients;

//[Headers("Access-Control-Allow-Origin: *", "Access-Control-Allow-Headers: Origin, X-Requested-With, Content-Type, Accept", "Access-Control-Request-Headers: content-type")]
public interface ICompetitionApi
{
    [Get("/api/competition")]
    Task<ApiResponse<IEnumerable<CompetitionDto>>> GetAllCompetitionsAsync();

    [Get("/api/competition/{id}")]
    Task<ApiResponse<CompetitionDto>> GetCompetitionAsync(Guid id);

    [Post("/api/competition/{id}/registration/open")]
    Task<IApiResponse> OpenCompetitionRegistrationAsync(Guid id);

    [Post("/api/competition/{id}/registration/complete")]
    Task<IApiResponse> CompleteCompetitionRegistrationAsync(Guid id);

    [Post("/api/competition")]
    Task<IApiResponse> CreateCompetitionAsync(CreateCompetitionDto dto);

    [Patch("/api/competition/{id}")]
    Task<IApiResponse> ChangeMaxCompetitorsAsync(Guid id, ChangeMaxCompetitorsRequestDto dto);
}
