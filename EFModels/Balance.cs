using System;
using System.Collections.Generic;

#nullable disable

namespace BankAssign_final.EFModels
{
    public partial class Balance
    {
        public int Id { get; set; }
        public int? Balance1 { get; set; }

        public virtual Account IdNavigation { get; set; }
    }
}
