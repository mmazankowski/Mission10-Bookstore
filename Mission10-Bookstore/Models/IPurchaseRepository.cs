using System;
using System.Linq;
using Mission10_Bookstore.Models;

namespace Mission10_Bookstore.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; }

        public void SavePurchase(Purchase purchase);
    }
}
