using Microsoft.Identity.Client;
using MultiStepForm.Model;

namespace MultiStepForm.Service 
{
    public interface ICustomerService
    {
        Task<Customer> InsertAsync(Customer customer);
    } 
}