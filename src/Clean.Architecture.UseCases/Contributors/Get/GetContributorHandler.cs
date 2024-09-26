using Ardalis.Result;
using CafeInfoApp.Core.Interfaces;
using Clean.Architecture.Core.ContributorAggregate;
using MediatR;

namespace Clean.Architecture.UseCases.Contributors.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetContributorHandler(IRepository<Contributor> _repository)
  : IRequestHandler<GetContributorQuery, Result<ContributorDTO>>
{
  public async  Task<Result<ContributorDTO>> Handle(GetContributorQuery request, CancellationToken cancellationToken)
  {
        //var spec = new ContributorByIdSpec(request.ContributorId);
        var entity = await _repository.GetByIdAsync(request.ContributorId);
        //if (entity == null) return Result.NotFound();

        //return new ContributorDTO(entity.Id, entity.Name, entity.PhoneNumber?.Number ?? "");
        throw new NotImplementedException();
  }
}
