using BankAssign_final.EFModels;
using System;
using System.Collections.Generic;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Linq;

namespace BankAssign_final.Persistant_Layer
{
	public class AccountContext
	{
		internal static  void CreateAccount(Account account)
		{
			string s = "Server=(localdb)\\Ruhith;Database=BankAssign;User Id=Ruhith;Password=1234;encrypt=false";
			try
			{
				DbContextOptionsBuilder<BankAssignContext> options = new DbContextOptionsBuilder<BankAssignContext>();
				options.UseSqlServer(s);
				BankAssignContext ac = new BankAssignContext(options.Options);
				ac.Accounts.Add(account);
				ac.SaveChanges();

			}
			catch (Exception ex)
			{
				throw;
			}
		}

        internal static Account GetAccountByID(int id)
		{
			string s = "Server=(localdb)\\Ruhith;Database=BankAssign;User Id=Ruhith;Password=1234;encrypt=false";
			try
			{
				DbContextOptionsBuilder<BankAssignContext> options = new DbContextOptionsBuilder<BankAssignContext>();
				options.UseSqlServer(s);
				BankAssignContext ac = new BankAssignContext(options.Options);
				Account a = ac.Accounts.Find(id);

				return a;
			}
			catch (Exception ex) {

				throw;
			}
		}

		internal static List<Account> GetAllAccounts()
		{
			string s = "Server=(localdb)\\Ruhith;Database=BankAssign;User Id=Ruhith;Password=1234;encrypt=false";
			try
			{
				DbContextOptionsBuilder<BankAssignContext> options = new DbContextOptionsBuilder<BankAssignContext>();
				options.UseSqlServer(s);
				BankAssignContext ac = new BankAssignContext(options.Options);
				List<Account> accounts = ac.Accounts.ToList();
				return accounts;


			}
			catch (Exception ex)
			{
				throw;
			}


		}

	}
}
