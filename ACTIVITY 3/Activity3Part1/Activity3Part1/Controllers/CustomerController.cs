using Activity3Part1.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity3Part1.Controllers
{
    public class CustomerController : Controller
    {
        
        public List<CustomerModel> customer = new List<CustomerModel>();

        public CustomerController()
        {
            customer.Add(new CustomerModel(1, "Tim James", 28));
            customer.Add(new CustomerModel(2, "Bob Builder", 36));
            customer.Add(new CustomerModel(3, "Harry Potter", 32));
            customer.Add(new CustomerModel(4, "Biblo Baggins", 38));
            customer.Add(new CustomerModel(5, "Jerry Seinfeld", 25));
            customer.Add(new CustomerModel(6, "Nick Miller", 43));
        }

        // GET: Customer
        public ActionResult Index()
        { 
            Tuple<List<CustomerModel>, CustomerModel> tuple = 
                new Tuple<List<CustomerModel>, CustomerModel>(customer, customer.ElementAtOrDefault(0));

            return View("Customer", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string radioButton)
        {

            CustomerModel model;

            model = customer.ElementAt(Int32.Parse(radioButton));

            Tuple<List<CustomerModel>, CustomerModel> tuple =
                new Tuple<List<CustomerModel>, CustomerModel>(customer, model);

            return View("Customer", tuple);
        }
        

        [HttpPost]
        public string GetMoreInfo(string radioButton)
        {

            return ("ok");
        }
    }
}