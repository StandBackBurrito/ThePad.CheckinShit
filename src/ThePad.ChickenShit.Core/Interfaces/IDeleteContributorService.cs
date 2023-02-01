using Ardalis.Result;

namespace ThePad.ChickenShit.Core.Interfaces;

public interface IDeleteContributorService
{
    public Task<Result> DeleteContributor(int contributorId);
}
