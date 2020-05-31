﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace DbManager.Models
{
    [Table("ShopItem")]
    public class ShopItem
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("Price")]
        public double Price { get; set; }
        [Column("Image")]
        public string Image { get; set; }
        [Column("UserId")]
        public Guid UserId { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        [NotMapped]
        public Category Category { get; set; }

        public ShopItem(string name, string description, double price, string image, Guid categoryId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            CategoryId = categoryId;
        }

        public ShopItem(string name, string description, double price, string image, Guid categoryId, Guid userId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
            Image = image;
            CategoryId = categoryId;
            UserId = userId;
        }

        public ShopItem() { }
    }
}