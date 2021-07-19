using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers 
{

    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Verifica se o cliente já existe
            //Valida os dados
            //Insere o cliente
            //Envia e-mail de boas vindas

            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Felipe Amaral",
                Email = "Felipe@vh-bit",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
