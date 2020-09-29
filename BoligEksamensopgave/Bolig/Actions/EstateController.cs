using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Bolig.Actions
{
    public class EstateController
    {
        public static Boolean CreateEstate(int SellerID, int AgentID, Estate estate)
        {
            estate.isSold = false;
            Entities Context = new Entities();
            Estate Query = Context.Estates.Where(x => x.Adress == estate.Adress).FirstOrDefault();
            Seller s = Context.Sellers.Where(X => X.ID == SellerID).FirstOrDefault();
            Agent a = Context.Agents.Where(X => X.ID == AgentID).FirstOrDefault();

            if (Query != null || s == null || a == null)
            {
                return false;
            }

            Context.Estates.Add(estate);
            Context.SaveChangesAsync();

            Entities Context2 = new Entities();
            var Query2 = Context2.Estates.Where(x => x.Adress == estate.Adress).FirstOrDefault();

            EstateLine Line = new EstateLine();
            Line.EstateID = Query2.ID;
            Line.SellerID = SellerID;
            Line.AgentID = AgentID;

            Context2.EstateLines.Add(Line);
            Context2.SaveChanges();

            return true;
        }

        public static Boolean UpdateEstate(int ID, Estate estate)
        {
            Entities Context = new Entities();
            var Query = Context.Estates.Where(X => X.ID == ID).FirstOrDefault();
            if(Query == null)
            {
                return false;
            }

            Query.Adress = estate.Adress;
            Query.City = estate.City;
            Query.isSold = estate.isSold;
            Query.Postal = estate.Postal;
            Query.Price = estate.Price;
            Query.SpaceM2 = estate.SpaceM2;
            Query.Image = estate.Image;
            Context.SaveChanges();
            return true;
        }

        public static Estate GetEstate(int ID)
        {
            Entities Context = new Entities();
            Estate e = Context.Estates.Where(X => X.ID == ID).FirstOrDefault();

            return e;
        }

        public static List<Estate> GetEstatesAsList()
        {
            Entities Context = new Entities();
            var estate = from Estate in Context.Estates select Estate;

            return estate.ToList();
        }

        public static Boolean DeleteEstate(int ID)
        {
            var Context = new Entities();
            try
            {
                var e = Context.Estates.Where(X => X.ID == ID).FirstOrDefault();
                Context.Estates.Remove(e);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // UC9
        public static int GetPrice(String City, int SpaceM2)
        {
            Entities Context = new Entities();
            List<Estate> Estates = Context.Estates.Where(X => X.City == City && 
                (X.SpaceM2 - 10 < SpaceM2 &&
                X.SpaceM2 + 10 > SpaceM2)).ToList<Estate>();

            int price = 0;
            int rounds = 0;
            foreach(Estate item in Estates)
            {
                price = price + item.Price;
                rounds++;
            }

            price = price / rounds;
            return price;
        }

        public static Boolean SellEstate(string Adress, int CustomerID, int agentID)
        {
            Entities Context = new Entities();
            Estate Estate = Context.Estates.Where(X => X.Adress == Adress).FirstOrDefault();
            Customer Customer = Context.Customers.Where(X => X.ID == CustomerID).FirstOrDefault();
            if (Estate == null || Customer == null)
                return false;

            Estate.isSold = true;
            History h = new History();
            h.CustomerID = CustomerID;
            h.EstateID = Estate.ID;
            h.Date = DateTime.Now;
            h.Paid = Estate.Price;
            h.AgentID = agentID;

            Context.Histories.Add(h);
            Context.SaveChangesAsync();
            return true;
        }

        public static List<Estate> GetNotSoldEstates()
        {
            var Context = new Entities();
            List<Estate> estates = Context.Estates.Where(x => x.isSold == false).ToList<Estate>();
            if (estates == null)
                return null;
            return estates;
        }
        public static List<Estate> Search(string City, int Space)
        {
            var Context = new Entities();
            List<Estate> e = Context.Estates.Where(X => X.City == City &&
                (Math.Abs(X.SpaceM2 - Space) < 25)
            ).ToList<Estate>();

            return e;
        }

        public static List<History> GetEstatedFromPeriod(DateTime fromDate, DateTime toDate)
        {
            var Context = new Entities();

            List<History> query = Context.Histories.Where(X => X.Date > fromDate &&
            X.Date < toDate).ToList<History>();

            /*List <Estate> estates = new List<Estate>();
            Estate estateGetter = new Estate();
            foreach(History item in Query)
            {
                estateGetter = Context.Estates.Where(X => X.ID == item.EstateID).FirstOrDefault();
                if (estateGetter != null)
                    estates.Add(estateGetter);
            }*/

            return query;
        }
        public static History[,] ConvertListTo2DArray(List<History> soldHouses)
        {
            List<int> sellers = new List<int>();
            List<int> estates = new List<int>();
            foreach(History h in soldHouses)
            {
                if (!estates.Contains(h.EstateID))
                {
                    estates.Add(h.EstateID);
                }
                if (!sellers.Contains(h.AgentID))
                {
                    sellers.Add(h.AgentID);
                }
            }
            History[,] array = new History[sellers.Count, estates.Count];

            foreach (History h in soldHouses)
            {
                int sellerIndex = sellers.FindIndex(x => x == h.AgentID);
                int estateIndex = estates.FindIndex(y => y == h.EstateID);
                array[sellerIndex, estateIndex] = h;
            }
            return array;

        }
    }
}
