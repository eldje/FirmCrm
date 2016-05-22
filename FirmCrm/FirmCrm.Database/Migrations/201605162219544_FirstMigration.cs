namespace FirmCrm.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        Number = c.Int(nullable: false),
                        Bus = c.String(),
                        PostalCode = c.Int(nullable: false),
                        City = c.String(),
                        Phone = c.String(),
                        Newsletter = c.Boolean(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.ProductProperties",
                c => new
                    {
                        ProductPropertyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category_CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductPropertyId)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .Index(t => t.Category_CategoryId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CutomerNumber = c.Int(nullable: false),
                        CustomerStatus = c.Int(nullable: false),
                        LastName = c.String(),
                        FirstName = c.String(),
                        ReductionRate = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.OrderRules",
                c => new
                    {
                        OrderRuleId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderRuleId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        CatId = c.Int(nullable: false),
                        ProductStatus = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Photo = c.Binary(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxRate = c.Double(nullable: false),
                        Stock = c.Int(nullable: false),
                        Supplier_SupplierId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_SupplierId)
                .Index(t => t.Supplier_SupplierId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierId)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        TotalPriceExTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPriceIncTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderRules", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "Supplier_SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Suppliers", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.Customers", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.ProductProperties", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Suppliers", new[] { "AddressId" });
            DropIndex("dbo.Products", new[] { "Supplier_SupplierId" });
            DropIndex("dbo.OrderRules", new[] { "ProductId" });
            DropIndex("dbo.Customers", new[] { "AddressId" });
            DropIndex("dbo.ProductProperties", new[] { "Category_CategoryId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
            DropTable("dbo.OrderRules");
            DropTable("dbo.Customers");
            DropTable("dbo.ProductProperties");
            DropTable("dbo.Categories");
            DropTable("dbo.Addresses");
        }
    }
}
