using Mediator;

namespace Repro.Application;

public sealed record PingQuery(string Value) : IRequest<string>;
