using Ardalis.Result;
using CafeInfoApp.Core.Interfaces;
using Clean.Architecture.Core.ContributorAggregate;
using MediatR;

namespace Clean.Architecture.UseCases.Contributors.Create;

public class CreateContributorHandler(IRepository<Contributor> _repository)
  : IRequestHandler<CreateContributorCommand, Result<int>>
{
    public async Task<Result<int>> Handle(CreateContributorCommand request,
      CancellationToken cancellationToken)
    {
        var newContributor = new Contributor(request.Name);

        var createdItem = await _repository.AddAsync(newContributor, cancellationToken);

        return createdItem.Id;
    }
}
