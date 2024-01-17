using Bz.F8t.WebApp.ApiClients.Dtos;
using Refit;

namespace Bz.F8t.WebApp.ApiClients;

//[Headers("Access-Control-Allow-Origin: *", "Access-Control-Allow-Headers: Origin, X-Requested-With, Content-Type, Accept", "Access-Control-Request-Headers: content-type")]
public interface ICompetitionApi
{
    [Get("/api/competition")]
    Task<IEnumerable<CompetitionDto>> GetAllCompetitionsAsync();

    [Get("/api/competition/{id}")]
    Task<IEnumerable<CompetitionDto>> GetCompetitionAsync(Guid id);

    [Post("/api/competition/{id}/registration/open")]
    Task OpenCompetitionRegistrationAsync(Guid id);

    [Post("/api/competition/{id}/registration/complete")]
    Task CompleteCompetitionRegistrationAsync(Guid id);

    //[Post("api/competition")]
    //Task CreateCompetitionAsync(CreateCompetitionDto dto);
}
