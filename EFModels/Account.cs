using System;
using System.Collections.Generic;

#nullable disable

namespace BankAssign_final.EFModels
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AccountId { get; set; }

        public virtual Balance Balance { get; set; }
    }
}
