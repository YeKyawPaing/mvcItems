using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcItem.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public decimal ItemPrice { get; set; }
        public int ItemCount { get; set; }
    }

    public class ItemDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}