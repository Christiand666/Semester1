using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Bolig.Actions
{
    public class Crud
    {
        public static Boolean CreateSeller(Seller seller)
        {
            Entities Context = new Entities();

            Seller Query = Context.Sellers.Where(x => x.Email == seller.Email || x.Phone == seller.Phone).FirstOrDefault();
            if (Query != null)
            {
                return false;
            }

            Context.Sellers.Add(seller);
            Context.SaveChangesAsync();
            return true;
        }

    }
}
