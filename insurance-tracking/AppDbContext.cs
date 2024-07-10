using insurance_tracking.Class;
using insurance_tracking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace insurance_tracking
{
    public class AppDbContext
    {
        private readonly UserService _userService;
        private readonly CustomerService _customerService;
        private readonly InsuranceServices _insuranceServices;
        private readonly OfferService _offerService;
        public AppDbContext()
        {
            var httpClient = new HttpClient();
            var apiUrl = "http://localhost:3000/insurance";

            _userService = new UserService(httpClient, apiUrl);
            _customerService = new CustomerService(httpClient, apiUrl);
            _insuranceServices = new InsuranceServices(httpClient, apiUrl);
            _offerService = new OfferService(httpClient, apiUrl);
        }

        public async Task<User> Login(string email, string password)
        {
            return await _userService.Login(email, password);
        }

        public async Task<List<Customer>> GetCustomerList()
        {
            return await _customerService.Customers();
        }

        public async Task<Customer> GetCustomer(int customer_id)
        {
            return await _customerService.GetCustomer(customer_id); 
        }

        public async Task<bool> AddCustomer(Customer customer)
        {
            return await _customerService.AddCustomer(customer);
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            return await _customerService.UpdateCustomer(customer);
        }

        public async Task<bool> DeleteCustomer(int customer_id)
        {
            return await _customerService.DeleteCustomer(customer_id);
        }

        public async Task<bool> AddInsurence(Insure insure)
        {
            return await _insuranceServices.AddInsurance(insure);
        }

        public async Task<List<Insure>> GetInsureList(int customer_id)
        {
            return await _insuranceServices.GetInsureListByCustomerId(customer_id);
        }

        public async Task<List<Insure>> GetInsureList()
        {
            return await _insuranceServices.GetInsureList();
        }

        public async Task<bool> AddOffer(Offer offer)
        {
            return await _offerService.AddOffer(offer);
        }

        public async Task<List<Offer>> GetOfferList()
        {
            return await _offerService.GetOfferList();
        }


    }
}
