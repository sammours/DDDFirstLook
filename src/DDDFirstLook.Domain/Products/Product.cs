using DDDFirstLook.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDDFirstLook.Domain.Products
{
    public class Product : AggregateEntity<int>
    {
        public Product(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }

        public Product(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public int Total { get; private set; }

        public Address Address { get; private set; }

        public List<Availability> Availabilities { get; private set; }

        private string[] AcceptedCountries = new string[] { "Syria", "Iraq", "Saudi" };

        // Todo: add credit card example
        public void ChangeName(string name)
        {
            this.Name = name;
        }

        public void AddAvailability(string type, int count, bool isActive = true)
        {
            if (this.Availabilities == null)
            {
                this.Availabilities = new List<Availability>();
            }

            var availability = this.Availabilities.FirstOrDefault(x => x.Type == type);
            if (availability == null)
            {
                availability = new Availability();
                availability.Type = type;
                availability.Count = count;
                availability.IsActive = isActive;
                this.Availabilities.Add(availability);
            }
            else
            {
                availability.Count += count;
                availability.IsActive = isActive;
            }

            this.SetTotal();
        }

        public void AddAddress(string street, PostalCode postalCode, string city, string country)
        {
            if (this.AcceptedCountries.All(x => x != country))
            {
                throw new Exception($"{country} Not valid Country");
            }

            this.Address = new Address();
            this.Address.Street = street;
            this.Address.PostalCode = postalCode;
            this.Address.City = city;
            this.Address.Country = country;
        }

        public void ChangePostalCode(PostalCode postalCode)
        {
            if (this.Address == null)
            {
                this.Address = new Address();
            }

            this.Address.PostalCode = postalCode;
        }

        private void SetTotal()
        {
            if (this.Availabilities != null)
            {
                this.Total = this.Availabilities.Sum(x => x.Count);
            }
            else
            {
                this.Total = 0;
            }
        }
    }
}
