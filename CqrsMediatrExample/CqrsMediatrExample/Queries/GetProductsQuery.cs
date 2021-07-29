using MediatR;
using System.Collections.Generic;

namespace CqrsMediatrExample.Queries
{
	public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}
