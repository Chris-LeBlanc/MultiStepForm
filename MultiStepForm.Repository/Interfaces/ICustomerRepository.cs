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
        public Task<Customer> Insert();
    }
}
