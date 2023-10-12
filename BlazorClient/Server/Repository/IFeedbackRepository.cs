using BlazorClient.Shared;

namespace BlazorClient.Server.Repository;

public interface IFeedbackRepository

{
    Task<List<Feedback>> GetAllFeetback(int id);
}
