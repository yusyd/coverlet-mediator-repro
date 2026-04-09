using Mediator;

namespace Repro.Application;

public sealed class PingQueryHandler : IRequestHandler<PingQuery, string>
{
    public ValueTask<string> Handle(PingQuery request, CancellationToken cancellationToken)
    {
        return ValueTask.FromResult(request.Value);
    }
}
