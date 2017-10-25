using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day03BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day03BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("Simba")]
        public IActionResult Index()
        {
            BankAccount bankAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = AnimalType.Lion
            };
            return View(bankAccount);
        }

        [Route("Animals")]
        public IActionResult ListOfAnimals()
        {
            BankAccounts bankAccounts = new BankAccounts();
            bankAccounts.Accounts.Add(new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = AnimalType.Lion
            });
            bankAccounts.Accounts.Add(new BankAccount()
            {
                Name = "Zumba",
                Balance = 1000,
                AnimalType = AnimalType.Mandrill
            });
            bankAccounts.Accounts.Add(new BankAccount()
            {
                Name = "Samba",
                Balance = 5000,
                AnimalType = AnimalType.Warthog
            });
            bankAccounts.Accounts.Add(new BankAccount()
            {
                Name = "Mamba",
                Balance = 4000,
                AnimalType = AnimalType.Meerkat
            });
            bankAccounts.Accounts.Add(new BankAccount()
            {
                Name = "Bamba",
                Balance = 3000,
                AnimalType = AnimalType.KingLion
            });

            return View(bankAccounts);
        }
    }
}
