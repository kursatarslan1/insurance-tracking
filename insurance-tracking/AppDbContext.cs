using insurance_tracking.Class;
using insurance_tracking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace insurance_tracking
{
    public class AppDbContext
    {
        private static Dictionary<string, object> _cache = new Dictionary<string, object>();
        private readonly UserService _userService;
        private readonly CustomerService _customerService;
        private readonly InsuranceServices _insuranceServices;
        private readonly OfferService _offerService;


        public AppDbContext()
        {
            var httpClient = new HttpClient();
            var apiUrl = WebConfigurationManager.AppSettings["ApiUrl"];

            _userService = new UserService(httpClient, apiUrl);
            _customerService = new CustomerService(httpClient, apiUrl);
            _insuranceServices = new InsuranceServices(httpClient, apiUrl);
            _offerService = new OfferService(httpClient, apiUrl);

            // Önbellek dictionary'sini başlat
            _cache = new Dictionary<string, object>();
        }

        public async Task<User> Login(string email, string password)
        {
            return await _userService.Login(email, password);
        }

        public async Task<List<Customer>> GetCustomerList()
        {
            // Önbellek kontrolü
            if (_cache.ContainsKey("CustomerList"))
            {
                return (List<Customer>)_cache["CustomerList"];
            }

            var customers = await _customerService.Customers();

            // Önbelleğe alma
            _cache["CustomerList"] = customers;

            return customers;
        }

        public async Task<Customer> GetCustomer(int customer_id)
        {
            return await _customerService.GetCustomer(customer_id);
        }

        public async Task<bool> AddCustomer(Customer customer)
        {
            var result = await _customerService.AddCustomer(customer);

            // Önbelleği temizle
            if (result)
            {
                _cache.Remove("CustomerList");
            }

            return result;
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            var result = await _customerService.UpdateCustomer(customer);

            // Önbelleği temizle
            if (result)
            {
                _cache.Remove("CustomerList");
            }

            return result;
        }

        public async Task<bool> DeleteCustomer(int customer_id)
        {
            var result = await _customerService.DeleteCustomer(customer_id);

            // Önbelleği temizle
            if (result)
            {
                _cache.Remove("CustomerList");
            }

            return result;
        }

        public async Task<bool> AddInsurance(Insure insure)
        {
            return await _insuranceServices.AddInsurance(insure);
        }

        public async Task<bool> CancelInsurance(int insurance_id)
        {
            return await _insuranceServices.CancelInsurance(insurance_id);
        }

        public async Task<List<Insure>> GetInsureList(int customer_id)
        {
            // Önbellek kontrolü
            if (_cache.ContainsKey("InsureList"))
            {
                return (List<Insure>)_cache["InsureList"];
            }

            var insures = await _insuranceServices.GetInsureListByCustomerId(customer_id);

            // Önbelleğe alma
            _cache["InsureList"] = insures;

            return insures;
        }

        public async Task<List<Insure>> GetInsureList()
        {
            // Önbellek kontrolü
            if (_cache.ContainsKey("InsureList"))
            {
                return (List<Insure>)_cache["InsureList"];
            }

            var insures = await _insuranceServices.GetInsureList();

            // Önbelleğe alma
            _cache["InsureList"] = insures;

            return insures;
        }

        public async Task<bool> AddOffer(Offer offer)
        {
            bool result = await _offerService.AddOffer(offer);

            // Önbelleği temizle
            if(result)
            {
                _cache.Remove("OfferList");
            }

            return result;
        }

        public async Task<List<Offer>> GetOfferList()
        {
            // Önbellek Kontrolü
            if (_cache.ContainsKey("OfferList"))
            {
                return (List<Offer>)_cache["OfferList"];
            }

            var offerList = await _offerService.GetOfferList();
            // Önbelleğe alma
            _cache["OfferList"] = offerList;

            return offerList;
        }
    }
}
