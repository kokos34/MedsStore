using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MedsStore.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Balms and creams"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Pills and capsules"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Inhalers and sprays"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Liquids and drops"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Others"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Litocid",
                    Description = "Used to treat a kidney stone condition called renal tubular acidosis",
                    ImagePath = "litocid.png",
                    UnitPrice = 48.50,
                    CategoryID = 2
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Fastum Gel",
                    Description = "For local relief of pain and inflammation associated with rheumatic and muscular " +
                                  "disorders and soft tissue injuries such as acute strains and sprains.",
                    ImagePath="fastum.png",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Neosporin",
                    Description = "Antibiotic cream that contains neomycin",
                    ImagePath= "neosporin.png",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Tiger balm",
                    Description = "A high quality analgesic cream specially formulated for active people. It is non-greasy, easy to apply and does not stain clothes. Fast relief.",
                    ImagePath="tigerbalm.png",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Tabcin",
                    Description = "Antiflamatory medcine used during flu and cold",
                    ImagePath="tabcin.png",
                    UnitPrice = 7.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Ketonal",
                    Description = "Strong non-opioidal painkiller",
                    ImagePath="ketonal.png",
                    UnitPrice = 15.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Asthma inhaler",
                    Description = "Inhaler used during asthma outbreaks",
                    ImagePath="asthmainhaler.png",
                    UnitPrice = 20.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Azasteline",
                    Description = "Seasonal allergic rhinitis (hay fever) in children and adults ",
                    ImagePath="azesteline.png",
                    UnitPrice = 18.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Lipomal",
                    Description = "Dry cough syrup",
                    ImagePath="lipomal.png",
                    UnitPrice = 13.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Pini compositum",
                    Description = "Herbal syrup for dry and wet cough.",
                    ImagePath="pini.png",
                    UnitPrice = 15.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Dexoftyal",
                    Description = "Eye drops for regeneration of tired eye-ball",
                    ImagePath="dexoftyal.png",
                    UnitPrice = 26.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Bobolen",
                    Description = "Ear inflamation drops.",
                    ImagePath="bobolen.png",
                    UnitPrice = 19.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Knee pad",
                    Description = "Pads used to stabilize knee",
                    ImagePath="kneepad.png",
                    UnitPrice = 35.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Medium syringe",
                    Description = "10cm length, 2cm diameter syringe",
                    ImagePath="med_syringe.png",
                    UnitPrice = 4.95,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Needle",
                    Description = "Universal size needle",
                    ImagePath="needle.png",
                    UnitPrice = 0.25,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Thermometer",
                    Description = "Alcohol-based thermometer",
                    ImagePath="thermometer.png",
                    UnitPrice = 12.95,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}