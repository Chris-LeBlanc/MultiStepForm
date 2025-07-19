using DAL;
using MultiStepForm.Model;
using MultiStepForm.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiStepForm.Repository
{
    public class CustomerRepository(IDataAccess db) : ICustomerRepository
    {
        public async Task<Customer> InsertAsync(Customer customer)
        {
            List<Parm> parms = new()
            {
                new("@Id", System.Data.SqlDbType.Int, customer.Id, 0, System.Data.ParameterDirection.Output),
                new("@FirstName", System.Data.SqlDbType.NVarChar, customer.FirstName, 50),
                new("@LastName", System.Data.SqlDbType.NVarChar, customer.LastName, 50),
                new("@Email", System.Data.SqlDbType.NVarChar, customer.Email, 50),
                new("@PhoneNumber", System.Data.SqlDbType.NVarChar, customer.PhoneNumber, 50),
                new("@Plan", System.Data.SqlDbType.Int, customer.Plan),
                new("AddOn", System.Data.SqlDbType.Int, customer.AddOn),
                new("@BillingType", System.Data.SqlDbType.Bit, customer.BillingType)
            };

            if (await db.ExecuteNonQueryAsync("spInsertCustomer", parms) > 0)
            {
                customer.Id = (int?)parms.FirstOrDefault(p => p.Name == "@Id")!.Value ?? 0;
            }
            else
            {
                throw new InvalidDataException("There was a problem creating a new customer");
            }

            return customer;
        }

        public async Task<bool> DoesEmailExistAsync(string email)
        {
            string sql = @"spEmailExist";

            List<Parm> parms = new()
            {
                new("@email", System.Data.SqlDbType.NVarChar, email)
            };

            var result = await db.ExecuteScalarAsync(sql, parms);
            return Convert.ToBoolean(result);
        }
    }
}