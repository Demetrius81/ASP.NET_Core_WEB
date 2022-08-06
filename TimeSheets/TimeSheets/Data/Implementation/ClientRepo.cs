using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ClientRepo : IClientRepo
    {
        private static List<Client> _instance = new List<Client>()
        {
            


            new Client()
            {
                UserId = Guid.Parse("C8382A98-C3BB-54A0-92A8-1E6B563ABDCB"),
                Id = Guid.Parse("055368AB-A1E4-E054-46A7-D05D2B94C6D1")
            },
            new Client()
            {
                UserId = Guid.Parse("EEC3D70A-5E41-869D-B105-E1FCCE25E55A"),
                Id = Guid.Parse("8DE283B8-9AE3-E5A3-7D9B-033C2B7E34F3")
            },
            new Client()
            {
                UserId = Guid.Parse("FB0A5D1D-C122-D69E-433F-9C12EC99AFBF"),
                Id = Guid.Parse("21125763-17C7-D143-0E87-4218E3EB5DCE")
            },
            new Client()
            {
                UserId = Guid.Parse("11DC0EA3-0F47-EB35-4134-66B50E25944A"),
                Id = Guid.Parse("27D84CAE-88A1-30A6-E248-3005EB346612")
            }
        };

        public void Add(Client Item)
        {
            throw new NotImplementedException();
        }

        public Client GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetItems(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Client item)
        {
            throw new NotImplementedException();
        }
    }
}
