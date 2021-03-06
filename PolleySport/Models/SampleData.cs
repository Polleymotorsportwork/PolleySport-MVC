﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PolleySport.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<PolleySportEntities>
    {
        protected override void Seed(PolleySportEntities context)
        {
            var categories = new List<Category>
            {
                new Category {CategoryName = "Yokohama Tyres",},
                new Category {CategoryName = "Wheels"},
                new Category {CategoryName = "Trans/Suspension"},
                new Category {CategoryName = "Oval Racing Parts"},
                new Category {CategoryName = "Car Fabrication"},
                new Category {CategoryName = "DP Car Hire"},
                new Category {CategoryName = "Toyo Tyres"}
            };

            var subCategories = new List<SubCategory>
            {
                new SubCategory {CategoryId = 1, CategoryName = "Yokohama Tyres", SubCategoryName = "Racing Tyres"},
                new SubCategory {CategoryId = 1, CategoryName = "Yokohama Tyres", SubCategoryName = "Road Legal Race/Track Day Tyres"},
                new SubCategory {CategoryId = 1, CategoryName = "Yokohama Tyres", SubCategoryName = "Rally Tyres"},
                new SubCategory {CategoryId = 1, CategoryName = "Yokohama Tyres", SubCategoryName = "Oval Racing Tyres"},
                new SubCategory {CategoryId = 1, CategoryName = "Yokohama Tyres", SubCategoryName = "4 x 4 Off Road Tyres"},
                new SubCategory {CategoryId = 1, CategoryName = "Yokohama Tyres", SubCategoryName = "Van Tyres"},
                new SubCategory {CategoryId = 1, CategoryName = "Yokohama Tyres", SubCategoryName = "Road Legal Sports Tyres"},
                new SubCategory {CategoryId = 1, CategoryName = "Yokohama Tyres", SubCategoryName = "Sports Tyres - Track Use Only"},
                new SubCategory {CategoryId = 1, CategoryName = "Yokohama Tyres", SubCategoryName = "Race Series Tyres"},

                new SubCategory {CategoryId = 2, CategoryName = "Wheels", SubCategoryName = "Compomotive"},
                new SubCategory {CategoryId = 2, CategoryName = "Wheels", SubCategoryName = "Weller Wheels"},

                new SubCategory {CategoryId = 3, CategoryName = "Trans/Suspension", SubCategoryName = "Transmission"},
                new SubCategory {CategoryId = 3, CategoryName = "Trans/Suspension", SubCategoryName = "Suspension"},

                new SubCategory {CategoryId = 4, CategoryName = "Oval Racing Parts", SubCategoryName = "Engine"},
                new SubCategory {CategoryId = 4, CategoryName = "Oval Racing Parts", SubCategoryName = "Seats/Harnesses"},
                new SubCategory {CategoryId = 4, CategoryName = "Oval Racing Parts", SubCategoryName = "Steering Wheels & Components"},
                new SubCategory {CategoryId = 4, CategoryName = "Oval Racing Parts", SubCategoryName = "Electrical Components"},
                new SubCategory {CategoryId = 4, CategoryName = "Oval Racing Parts", SubCategoryName = "Body Panels"},
                new SubCategory {CategoryId = 4, CategoryName = "Oval Racing Parts", SubCategoryName = "Exhaust/Silencers"},
                new SubCategory {CategoryId = 4, CategoryName = "Oval Racing Parts", SubCategoryName = "Fuel Components"},
                new SubCategory {CategoryId = 4, CategoryName = "Oval Racing Parts", SubCategoryName = "Oils & Lubricants"},
                new SubCategory {CategoryId = 4, CategoryName = "Oval Racing Parts", SubCategoryName = "Miscellaneous"}

            };

            var productAttributes = new List<ProductAttributes>
            {
                new ProductAttributes {
                    //Name = "",
                    Value = "165/65R13",
                    Price = 81M,
                    ProductId = 1
                },
                new ProductAttributes {
                    //Name = "",
                    Value = "185/70R13",
                    Price = 90M,
                    ProductId = 1
                },
                new ProductAttributes {
                    //Name = "",
                    Value = "175/65R14",
                    Price = 92M,
                    ProductId = 1
                },
                new ProductAttributes {
                    //Name = "",
                    Value = "185/60R15",
                    Price = 99M,
                    ProductId = 1
                },
                new ProductAttributes {
                    //Name = "",
                    Value = "185/65R15",
                    Price = 104M,
                    ProductId = 1
                },
                new ProductAttributes {
                    //Name = "",
                    Value = "195/65R15",
                    Price = 113M,
                    ProductId = 1
                }
            
            };

            new List<Products>
            {
                new Products
                {
                    Name = "A035",
                    Description =
                        "The Yokohama A035 is multi purpose gravel/forest rally tyre that is suitable for a wide range of conditions. It features a directional tread pattern with a choice of compounds (must be used in matching pairs to balance the vehicle). This directional tread pattern offers stability under braking and maximum traction out of corners. The stability and durability of the tyre is helped further by reinforced sidewalls, helping to protect the tyre, and reducing the chance of cuts or objects puncturing t",
                    Price = 81.00M,
                    ImageURL = "ProductImages/a035 (200 x 200).jpg",
                    Stock = 9,
                    ShippingCost = 12.50M,
                    Category = categories.Single(c => c.CategoryName == "Yokohama Tyres"),
                    //SubCategoryId = 3, Trans/Suspension
                    SubCategory = subCategories.Single(s => s.SubCategoryName == "Rally Tyres"),
                    Attributes = productAttributes.Where(pa => pa.ProductId == 1).ToList()
                },
                new Products
                {
                    Name = "A006-T",
                    Description =
                        "YOKOHAMA has an excellent reputation for asphalt tyres and this latest addition offers superb performance for tarmac rallying. It is FIA approved and can be cut to a wet pattern if required. Available in various compounds to compete in all weather conditions.",
                    Price = 162.00M,
                    ImageURL = "ProductImages/a006t (200 x 200).jpg",
                    Stock = 10,
                    ShippingCost = 10.42M,
                    Category = categories.Single(c => c.CategoryName == "Yokohama Tyres"),
                    //SubCategoryId = 3,
                    SubCategory = subCategories.Single(s => s.SubCategoryName == "Rally Tyres")
                },
                new Products
                {
                    Name = "A005",
                    Description = "Radial Slick Tyre",
                    Price = 126.00M,
                    ImageURL = "ProductImages/a005 (200 x 200).jpg",
                    Stock = 10,
                    Category = categories.Single(c => c.CategoryName == "Yokohama Tyres"),
                    //SubCategoryId = 1,
                    SubCategory = subCategories.Single(s => s.SubCategoryName == "Racing Tyres")
                },
                new Products
                {
                    Name = "A006",
                    Description = "Radial Wet Tyre",
                    Price = 140.00M,
                    ImageURL = "ProductImages/a006 (1) (200 x 178).jpg",
                    Stock = 10,
                    Category = categories.Single(c => c.CategoryName == "Yokohama Tyres"),
                    //SubCategoryId = 1,
                    SubCategory = subCategories.Single(s => s.SubCategoryName == "Racing Tyres")
                },
                new Products
                {
                    Name = "A053",
                    Description =
                        "The A053 is becoming increasingly popular on the Brisca F1 Stock Cars, available in Super Soft, Soft and Medium Compounds.",
                    Price = 125.00M,
                    ImageURL = "ProductImages/A053 (200 x 200).jpg",
                    Stock = 10,
                    Category = categories.Single(c => c.CategoryName == "Yokohama Tyres"),
                    //SubCategoryId = 4,
                    SubCategory = subCategories.Single(s => s.SubCategoryName == "Oval Racing Tyres")
                }

            }.ForEach(a => context.Products.Add(a));
        }
    }
}