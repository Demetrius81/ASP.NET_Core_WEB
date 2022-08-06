using Newtonsoft.Json;
using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ServiceRepo : IServiceRepo
    {
        private static List<Service> _instance = new List<Service>()
        {
            new Service()
            {
                Id= Guid.Parse("519220A2-A4C4-E15E-51BE-B2168662B5D8"),
                Name="nulla vulputate"
            },
            new Service()
            {
                Id= Guid.Parse("511B6779-6670-85D9-43A6-1C3AD9E01B5E"),
                Name="vitae sodales"
            },
            new Service()
            {
                Id= Guid.Parse("B8BED00B-0885-DB75-53C7-32353FB745AA"),
                Name="adipiscing elit."
            },
            new Service()
            {
                Id= Guid.Parse("B83BC95E-553C-7F39-53AD-6469BB1E415D"),
                Name="sagittis placerat."
            },
            new Service()
            {
                Id= Guid.Parse("63749B81-8302-C173-3BEC-0C1CB55956EA"),
                Name="montes, nascetur"
            },
            new Service()
            {
                Id= Guid.Parse("9425B9B0-B461-9952-0639-BD7EA79D387B"),
                Name="augue ac"
            }
        };

        public void Add(Service Item)
        {
            throw new NotImplementedException();
        }

        public Service GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Service> GetItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Service> GetItems(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Service item)
        {
            throw new NotImplementedException();
        }
    }
}
