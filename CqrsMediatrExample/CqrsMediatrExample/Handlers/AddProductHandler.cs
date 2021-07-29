using CqrsMediatrExample.Commands;
using CqrsMediatrExample.DataStore;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsMediatrExample.Handlers
{
	public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
	{
		private readonly FakeDataStore _fakeDataStore;

		public AddProductHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

		public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
		{
			await _fakeDataStore.AddProduct(request.Product);
			
			return request.Product;
		}
	}
}
