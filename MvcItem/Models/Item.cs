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

        [StringLength(60, MinimumLength = 3)]
        public string ItemName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string ItemCategory { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal ItemPrice { get; set; }
        public int ItemCount { get; set; }
    }

    public class ItemDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}