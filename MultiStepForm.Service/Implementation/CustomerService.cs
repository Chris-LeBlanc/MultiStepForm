using Microsoft.AspNetCore.Mvc.Diagnostics;
using MultiStepForm.Model;
using MultiStepForm.Repository;
using MultiStepForm.Types;

namespace MultiStepForm.Service
{
    public class CustomerService(ICustomerRepository repo) : ICustomerService
    {
        public async Task<Customer> InsertAsync(Customer customer)
        {
            if (await ValidateAsync(customer))
            {
                return await repo.InsertAsync(customer);
            }

            return customer;
        }

        public async Task<bool> DoesEmailExist(string email)
        {
            return await repo.DoesEmailExistAsync(email);
        }

        public async Task<bool> ValidateAsync(Customer customer)
        {
            await ValidateBusinessRules(customer);

            return customer.Errors.Count == 0;
        }

        public async Task ValidateBusinessRules(Customer customer)
        {
            var emailExists = await DoesEmailExist(customer.Email);

            if (emailExists)
            {
                customer.AddError(new("Email already exists", ErrorType.Business));
            }
        }
    }
}