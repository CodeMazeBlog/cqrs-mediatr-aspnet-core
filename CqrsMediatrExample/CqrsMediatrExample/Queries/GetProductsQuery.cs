using MediatR;

namespace CqrsMediatrExample.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}
