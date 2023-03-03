using MediatR;

namespace CqrsMediatrExample.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
