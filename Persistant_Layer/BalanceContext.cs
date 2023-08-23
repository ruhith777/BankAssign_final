using BankAssign_final.EFModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography.X509Certificates;

namespace BankAssign_final.Persistant_Layer
{
	public class BalanceContext
	{
		public static Balance GetBalance(int id)
		{
			string s = "Server=(localdb)\\Ruhith;Database=BankAssign;User Id=Ruhith;Password=1234;encrypt=false";
			try
			{
				DbContextOptionsBuilder<BankAssignContext> options = new DbContextOptionsBuilder<BankAssignContext>();
				options.UseSqlServer(s);
				BankAssignContext ac = new BankAssignContext(options.Options);
				Balance bal = ac.Balances.Find(id);
				//int b = (int)bal.Balance1;
				return bal;
			}
			catch (Exception ex)
			{
				throw;
			}
		}

		internal static void AddBalance(Balance b)
		{
			string s = "Server=(localdb)\\Ruhith;Database=BankAssign;User Id=Ruhith;Password=1234;encrypt=false";
			try
			{
				DbContextOptionsBuilder<BankAssignContext> options = new DbContextOptionsBuilder<BankAssignContext>();
				options.UseSqlServer(s);
				BankAssignContext ac = new BankAssignContext(options.Options);
				ac.Balances.Add(b);
				ac.SaveChanges();

			}
			catch (Exception ex)
			{
				throw;
			}
		}

        internal static void AddDeposit(Balance b)
		{
			string s = "Server=(localdb)\\Ruhith;Database=BankAssign;User Id=Ruhith;Password=1234;encrypt=false";
			try
			{
				DbContextOptionsBuilder<BankAssignContext> options = new DbContextOptionsBuilder<BankAssignContext>();
				options.UseSqlServer(s);
				BankAssignContext ac = new BankAssignContext(options.Options);
				Balance balance = ac.Balances.Find(b.Id);
				int? a = b.Balance1 + balance.Balance1;
				balance.Balance1 = a;

				ac.Balances.Update(balance);
				ac.SaveChanges();

			}
			catch (Exception ex)
			{
				throw;
			}
		}

		internal static void CreateBalance(Balance b)
		{
			string s = "Server=(localdb)\\Ruhith;Database=BankAssign;User Id=Ruhith;Password=1234;encrypt=false";
			try
			{
				DbContextOptionsBuilder<BankAssignContext> options = new DbContextOptionsBuilder<BankAssignContext>();
				options.UseSqlServer(s);
				BankAssignContext ac = new BankAssignContext(options.Options);
				ac.Balances.Add(b);
				ac.SaveChanges();

			}
			catch (Exception ex)
			{
				throw;
			}
		}

        internal static void WithdrawAmount(Balance b)
		{

			string s = "Server=(localdb)\\Ruhith;Database=BankAssign;User Id=Ruhith;Password=1234;encrypt=false";
			try
			{
				DbContextOptionsBuilder<BankAssignContext> options = new DbContextOptionsBuilder<BankAssignContext>();
				options.UseSqlServer(s);
				BankAssignContext ac = new BankAssignContext(options.Options);
				Balance balance = ac.Balances.Find(b.Id);
				int? w = balance.Balance1 - b.Balance1;
				balance.Balance1 = w;
				ac.Balances.Update(balance);
				ac.SaveChanges();

			}
			catch (Exception ex)
			{
				throw;
			}
		}
    }
}
