using Microsoft.AspNetCore.Mvc;
using BankAssign_final.EFModels;
using BankAssign_final.Persistant_Layer;
using System.Collections.Generic;

namespace BankAssign_final.Controllers
{
	public class AccountController : Controller
	{
		[HttpGet]
		public IActionResult Create()
		{

			return View();
		}
		[HttpPost]
		public IActionResult Create(Account account)
		{
			AccountContext.CreateAccount(account);


			return RedirectToAction("CreateBalance");

		}

		[HttpGet]
		public IActionResult CreateBalance()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateBalance(Balance b)
		{
			BalanceContext.AddBalance(b);
			return RedirectToAction("List");
		}


        [HttpGet]
		public IActionResult List()
		{
			List<Account> account = AccountContext.GetAllAccounts();
			return View(account);

		}
		[HttpGet]
		public IActionResult Balance(int id)
		{
			Balance bal = BalanceContext.GetBalance(id);
			//Account account = AccountContext.GetAccountByID(id);
			return View(bal);


		}
		[HttpGet]
		public IActionResult Deposit(int id)
		{

			Balance bal = BalanceContext.GetBalance(id);
			return View(bal);

		}

		[HttpPost]
		public IActionResult Deposit(Balance b)
		{
			BalanceContext.AddDeposit(b);
			return RedirectToAction("List");


		}
		[HttpGet]
		public IActionResult Withdraw(int id) {

			Balance b =BalanceContext.GetBalance(id);
			return View(b);
		}
		[HttpPost]
		public IActionResult Withdraw(Balance b)
		{
			BalanceContext.WithdrawAmount(b);
			return RedirectToAction("List");
		}
	}
}
