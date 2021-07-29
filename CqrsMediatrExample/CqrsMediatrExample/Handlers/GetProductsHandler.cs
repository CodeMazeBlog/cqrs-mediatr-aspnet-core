using CqrsMediatrExample.DataStore;
using CqrsMediatrExample.Queries;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsMediatrExample.Handlers
{
	public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
	{
		private readonly FakeDataStore _fakeDataStore;

		public GetProductsHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

		public async Task<IEnumerable<Product>> Handle(GetProductsQuery request,
			CancellationToken cancellationToken) => await _fakeDataStore.GetAllProducts();
	}
}
