namespace MvcItem.Migrations
{
    using MvcItem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcItem.Models.ItemDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcItem.Models.ItemDBContext";
        }

        protected override void Seed(MvcItem.Models.ItemDBContext context)
        {
            context.Items.AddOrUpdate(i => i.ItemName,
        new Item
        {
            ItemName = "Eraser",
            ItemCategory = "Stationary",
            ItemPrice = 1.25M,
            ItemCount = 30
        },

        new Item
        {
            ItemName = "Orange",
            ItemCategory = "Fruit",
            ItemPrice = 5.00M,
            ItemCount = 24
        },

        new Item
        {
            ItemName = "Table",
            ItemCategory = "Furniture",
            ItemPrice = 30.00M,
            ItemCount = 10
        },

        new Item
        {
            ItemName = "Robot",
            ItemCategory = "Toy",
            ItemPrice = 15.00M,
            ItemCount = 17
        }
        );
        }
    }
}
