using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Bolig.Actions
{
    class Cleaner
    {
        public static Boolean CleanDB()
        {

            var Context = new Entities();
            var Lines = Context.EstateLines.Where(X => X.ID != 0).ToList<EstateLine>();

            int connections = 0;
            foreach(var line in Lines)
            {
                var Query = Context.Estates.Where(X => X.ID == line.EstateID).FirstOrDefault();
                if (Query != null)
                    connections++;
                var Query2 = Context.Sellers.Where(X => X.ID == line.SellerID).FirstOrDefault();
                if (Query != null)
                    connections++;
                var Query3 = Context.Agents.Where(X => X.ID == line.AgentID).FirstOrDefault();
                if (Query3 != null)
                    connections++;
                
                if(connections < 2)
                {
                    Context.EstateLines.Remove(line);
                }
            }

            Context.SaveChanges();

            return true;
        }
    }
}
