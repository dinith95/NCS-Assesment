using Ardalis.Result;
using CafeInfoApp.Core.Interfaces;
using Clean.Architecture.Core.ContributorAggregate;
using MediatR;

namespace Clean.Architecture.UseCases.Contributors.Update;

public class UpdateContributorHandler(IRepository<Contributor> _repository)
  :  IRequestHandler<UpdateContributorCommand, Result<ContributorDTO>>
{
  public async Task<Result<ContributorDTO>> Handle(UpdateContributorCommand request, CancellationToken cancellationToken)
  {
        var existingContributor = await _repository.GetByIdAsync(request.ContributorId, cancellationToken);
        if (existingContributor == null)
        {
            return Result.NotFound();
        }

        return new ContributorDTO(123, "name", "mobile");
    }
}
