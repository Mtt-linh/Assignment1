using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Acc_DealContext:DbContext 
    {
        public Acc_DealContext():base("name=Asignment1Context")
        {

        }
        public  DbSet<Account> Accounts { get; set; }
        public  DbSet<Deal> Deals { get; set; }
    }
}