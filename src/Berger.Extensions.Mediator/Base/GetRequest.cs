using MediatR;
using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Mediator
{
    public class GetRequest<T> where T : BaseEntity
    {
        public record GetById(Guid Id) : IRequest<T>;
        public record Get() : IRequest<IQueryable<T>>;
    }
}