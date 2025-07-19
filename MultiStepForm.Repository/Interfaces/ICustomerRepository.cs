using MultiStepForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiStepForm.Repository
{
    public interface ICustomerRepository
    {
        Task<Customer> InsertAsync(Customer customer);

        Task<bool> DoesEmailExistAsync(string email);
    }
}
