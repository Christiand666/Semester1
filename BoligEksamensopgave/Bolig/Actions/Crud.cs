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

        public static Boolean UpdateSeller(int id, Seller seller)
        {
            Entities Context = new Entities();
            Seller Query = Context.Sellers.Where(x => x.ID == id).FirstOrDefault();

            if(Query == null)
            {
                return false;
            }

            Query.Email = seller.Email;
            Query.Name = seller.Name;
            Query.Phone = seller.Phone;

            Context.SaveChangesAsync();
            return true;
        }

        public static Seller GetSeller(int? id, string email)
        {
            Entities Context = new Entities();
            Seller s;
            if (id != null)
                s = Context.Sellers.Where(x => x.ID == id).FirstOrDefault();
            else if (email != null)
                s = Context.Sellers.Where(x => x.Email == email).FirstOrDefault();
            else
                s = null;

            return s;
        }

        public static Boolean DeleteSeller(int ID)
        {
            var Context = new Entities();
            var Query = Context.Sellers.Where(X => X.ID == ID).FirstOrDefault();
            if (Query == null)
                return false;
            Context.Sellers.Remove(Query);
            Context.SaveChanges();
            return true;
        }

        public static Boolean CreateAgent(Agent agent)
        {
            Entities Context = new Entities();

            Agent Query = Context.Agents.Where(x => x.Email == agent.Email || x.Phone == agent.Phone).FirstOrDefault();
            if (Query != null)
            {
                return false;
            }

            Context.Agents.Add(agent);
            Context.SaveChangesAsync();
            return true;
        }

        public static Boolean UpdateAgent(int id, Agent agent)
        {
            Entities Context = new Entities();
            Agent Query = Context.Agents.Where(x => x.ID == id).FirstOrDefault();

            if (Query == null)
            {
                return false;
            }

            Query.Email = agent.Email;
            Query.Name = agent.Name;
            Query.Phone = agent.Phone;

            Context.SaveChangesAsync();
            return true;
        }

        public static Agent GetAgent(int? id, string email)
        {
            Entities Context = new Entities();
            Agent a;
            if (id != null)
                a = Context.Agents.Where(x => x.ID == id).FirstOrDefault();
            else if (email != null)
                a = Context.Agents.Where(x => x.Email == email).FirstOrDefault();
            else
                a = null;

            return a;
        }

        public static Boolean DeleteAgent(int ID)
        {
            var Context = new Entities();
            var Query = Context.Agents.Where(X => X.ID == ID).FirstOrDefault();
            if (Query == null)
                return false;
            Context.Agents.Remove(Query);
            Context.SaveChanges();
            return true;
        }
        public static Boolean CreateCustomer(Customer customer)
        {
            Entities Context = new Entities();

            Customer Query = Context.Customers.Where(x => x.Email == customer.Email || x.Phone == customer.Phone).FirstOrDefault();
            if (Query != null)
            {
                return false;
            }

            Context.Customers.Add(customer);
            Context.SaveChangesAsync();
            return true;
        }

        public static Boolean UpdateCustomer(int id, Customer customer)
        {
            Entities Context = new Entities();
            Customer Query = Context.Customers.Where(x => x.ID == id).FirstOrDefault();

            if (Query == null)
            {
                return false;
            }

            Query.Email = customer.Email;
            Query.Name = customer.Name;
            Query.Phone = customer.Phone;

            Context.SaveChangesAsync();
            return true;
        }

        public static Customer GetCustomer(int? id, string email)
        {
            Entities Context = new Entities();
            Customer c;
            if (id != null)
                c = Context.Customers.Where(x => x.ID == id).FirstOrDefault();
            else if (email != null)
                c = Context.Customers.Where(x => x.Email == email).FirstOrDefault();
            else
                c = null;

            return c;
        }

        public static Boolean DeleteCustomer(int ID)
        {
            var Context = new Entities();
            var Query = Context.Customers.Where(X => X.ID == ID).FirstOrDefault();
            if (Query == null)
                return false;
            Context.Customers.Remove(Query);
            Context.SaveChanges();
            return true;
        }

        //Methods for getting tables as lists//
        public static List<Agent> GetAgentDBAsList()
        {
            Entities Context = new Entities();
            var agent = from Agent in Context.Agents select Agent;

            return agent.ToList();
        }
        public static List<Seller> GetSellerDBAsList()
        {
            Entities Context = new Entities();
            var seller = from Seller in Context.Sellers select Seller;

            return seller.ToList();
        }
        public static List<Customer> GetCostumerDBAsList()
        {
            Entities Context = new Entities();
            var customer = from Customer in Context.Customers select Customer;

            return customer.ToList();
        }
    }

}
