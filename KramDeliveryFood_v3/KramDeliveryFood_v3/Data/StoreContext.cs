using KramDeliveryFood_v3.Interfaces;
using System;
using System.Collections.Generic;

namespace KramDeliveryFood_v3.Models
{
    public class StoreContext : IData
    {
        public IList<Product> BaseProducts { get; set; }
        public IList<Order> Orders { get; set; }
        public Order Order { get; set; }
        public IList<Product> OrderProducts { get; set; }
        public IList<Provider> Providers { get; set; }
        public IList<Categorie> Categories { get; set; }

        public StoreContext()
        {
            BaseProducts = new List<Product>();
            Providers = new List<Provider>();
            Categories = new List<Categorie>();
        }

        public void InitProducts()
        {
            BaseProducts.Add(
                new Product { ProductID = Guid.Parse("db7fc833-bed5-4dab-b220-dc54a769839b"), Name = "Big Mac", Price = 60.00M, Specifications = "221 ккал. б15 ,ж14 ,у5", Description = "яйцо, молоко,зелень,приправы", CategoryId = Guid.Parse("e4bcf5dc-c988-4072-927d-e4259ee0ac76"), ProviderId = Guid.Parse("880e63a0-c3a5-4afe-bf01-277a3da15da6"), ProductType = "Burger"}
            );
            BaseProducts.Add(
                new Product { ProductID = Guid.Parse("4f176a75-f45b-41fd-95b4-8ea1b1521889"), Name = "McDouble", Price = 80.00M, Specifications = "221 ккал. б15 ,ж14 ,у5", Description = "яйцо, молоко,зелень,приправы, бургеры", CategoryId = Guid.Parse("e4bcf5dc-c988-4072-927d-e4259ee0ac76"), ProviderId = Guid.Parse("880e63a0-c3a5-4afe-bf01-277a3da15da6"), ProductType = "Burger" }
            );
            BaseProducts.Add(
                new Product { ProductID = Guid.Parse("3a236768-58fd-4bb9-bc8a-a986df3ff94a"), Name = "Hamburger", Price = 85.00M, Specifications = "278 ккал. б22 ,ж11 ,у19", Description = "творог, яйцо, мука, сметана", CategoryId = Guid.Parse("e4bcf5dc-c988-4072-927d-e4259ee0ac76"), ProviderId = Guid.Parse("c797ed97-cc0c-47c5-8ab3-b92aac8cb024"), ProductType = "Burger" }
                );
            BaseProducts.Add(
               new Product { ProductID = Guid.Parse("3a236768-58fd-4bb9-bc8a-a986df3ff94a"), Name = "Hamburger", Price = 85.00M, Specifications = "278 ккал. б22 ,ж11 ,у19", Description = "творог, яйцо, мука, сметана", CategoryId = Guid.Parse("e4bcf5dc-c988-4072-927d-e4259ee0ac76"), ProviderId = Guid.Parse("c797ed97-cc0c-47c5-8ab3-b92aac8cb024"), ProductType = "Burger" }
               );
            BaseProducts.Add(
                new Product { ProductID = Guid.Parse("2361e2c1-51b3-4dbb-af95-3adfcbfd3fdd"), Name = "Cappuccino", Price = 85.00M, Specifications = "278 ккал. б22 ,ж11 ,у19", Description = "творог, яйцо, мука, сметана", CategoryId = Guid.Parse("ce9cfd84-067f-4a2c-a210-0e066b22507b"), ProviderId = Guid.Parse("c797ed97-cc0c-47c5-8ab3-b92aac8cb024"), ProductType = "Coffe" }
                );
            BaseProducts.Add(
                new Product { ProductID = Guid.Parse("dc5df95a-16ef-4dd2-9ebf-68c2074388db"), Name = "Vanila Cone", Price = 95.00M, Specifications = "315 ккал. б11, ж10, у45", Description = "молоко, рис, масло сливочное, соль, сахар", CategoryId = Guid.Parse("388cb626-260f-4551-9a03-03c26399d16a"), ProviderId = Guid.Parse("fafcc8dd-54ba-408d-8ed7-677ccb2169b4"), ProductType = "Coffe" }
                );
            BaseProducts.Add(
                new Product { ProductID = Guid.Parse("b747c7e1-dc31-4969-9221-8b01d464bb71"), Name = "Dr.Pepper", Price = 95.00M, Specifications = "315 ккал. б11, ж10, у45", Description = "молоко, рис, масло сливочное, соль, сахар", CategoryId = Guid.Parse("388cb626-260f-4551-9a03-03c26399d16a"), ProviderId = Guid.Parse("fafcc8dd-54ba-408d-8ed7-677ccb2169b4"), ProductType = "Soda" }
                );
            BaseProducts.Add(
                new Product { ProductID = Guid.Parse("dc5df95a-16ef-4dd2-9ebf-68c2074388db"), Name = "Chocolate Shake", Price = 95.00M, Specifications = "315 ккал. б11, ж10, у45", Description = "молоко, рис, масло сливочное, соль, сахар", CategoryId = Guid.Parse("388cb626-260f-4551-9a03-03c26399d16a"), ProviderId = Guid.Parse("f5ea11aa-5c42-4ca3-8a9a-c1e5c11eba83"), ProductType = "Soda" }
                );

            Providers.Add(
                new Provider { ProdviderId = Guid.Parse("880e63a0-c3a5-4afe-bf01-277a3da15da6"), Name = "Lucas", Address = "ul.Ulichnaya 1", PhoneNumber = "123456789" });
            Providers.Add(
                new Provider { ProdviderId = Guid.Parse("c797ed97-cc0c-47c5-8ab3-b92aac8cb024"), Name = "Tomas", Address = "ul.Centralnaya", PhoneNumber = "987654321" });
            Providers.Add(
                new Provider { ProdviderId = Guid.Parse("fafcc8dd-54ba-408d-8ed7-677ccb2169b4"), Name = "Jhon", Address = "ul.Mira", PhoneNumber = "147258369" });
            Providers.Add(
                new Provider { ProdviderId = Guid.Parse("f5ea11aa-5c42-4ca3-8a9a-c1e5c11eba83"), Name = "Steve", Address = "ul.Mira", PhoneNumber = "147258369" });

            Categories.Add(
                new Categorie { CategoryId = Guid.Parse("e4bcf5dc-c988-4072-927d-e4259ee0ac76"), Name = "Burgers" });
            Categories.Add(
                new Categorie { CategoryId = Guid.Parse("ce9cfd84-067f-4a2c-a210-0e066b22507b"), Name = "Drinks" });
            Categories.Add(
                new Categorie { CategoryId = Guid.Parse("388cb626-260f-4551-9a03-03c26399d16a"), Name = "Desserts & Shakes" });

        }
    }
}
