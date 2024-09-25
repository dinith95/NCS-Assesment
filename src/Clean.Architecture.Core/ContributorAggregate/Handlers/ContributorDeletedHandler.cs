﻿using Clean.Architecture.Core.ContributorAggregate.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Clean.Architecture.Core.ContributorAggregate.Handlers;

/// <summary>
/// NOTE: Internal because ContributorDeleted is also marked as internal.
/// </summary>
internal class ContributorDeletedHandler(ILogger<ContributorDeletedHandler> logger) : INotificationHandler<ContributorDeletedEvent>
{
  public Task Handle(ContributorDeletedEvent domainEvent, CancellationToken cancellationToken)
  {
    logger.LogInformation("Handling Contributed Deleted event for {contributorId}", domainEvent.ContributorId);
  }
}
