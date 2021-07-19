using System;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers 
{

    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}
