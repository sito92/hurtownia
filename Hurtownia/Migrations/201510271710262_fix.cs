namespace Hurtownia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        HomeNumber = c.Int(nullable: false),
                        FlatNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        CompanyContactInfoId = c.Int(nullable: false),
                        ClientContactInfoId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                        ClientType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.ClientContactInfoes", t => t.ClientContactInfoId, cascadeDelete: true)
                .ForeignKey("dbo.CompanyContactInfoes", t => t.CompanyContactInfoId, cascadeDelete: true)
                .Index(t => t.CompanyContactInfoId)
                .Index(t => t.ClientContactInfoId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.ClientContactInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TelephoneNumber = c.String(nullable: false),
                        EMail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyContactInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NIP = c.String(maxLength: 10),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        TelephoneNumber = c.String(nullable: false),
                        EMail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        PaymentTypeId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentTypeId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.PaymentTypeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UnitId = c.Int(nullable: false),
                        ProductTypeID = c.Int(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductTypes", t => t.ProductTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.UnitId)
                .Index(t => t.ProductTypeID);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        MinimalAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductLists", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "UnitId", "dbo.Units");
            DropForeignKey("dbo.Products", "ProductTypeID", "dbo.ProductTypes");
            DropForeignKey("dbo.ProductLists", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "PaymentTypeId", "dbo.PaymentTypes");
            DropForeignKey("dbo.Orders", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Clients", "CompanyContactInfoId", "dbo.CompanyContactInfoes");
            DropForeignKey("dbo.Clients", "ClientContactInfoId", "dbo.ClientContactInfoes");
            DropForeignKey("dbo.Clients", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Products", new[] { "ProductTypeID" });
            DropIndex("dbo.Products", new[] { "UnitId" });
            DropIndex("dbo.ProductLists", new[] { "OrderId" });
            DropIndex("dbo.ProductLists", new[] { "ProductId" });
            DropIndex("dbo.Orders", new[] { "EmployeeId" });
            DropIndex("dbo.Orders", new[] { "PaymentTypeId" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropIndex("dbo.Clients", new[] { "AddressId" });
            DropIndex("dbo.Clients", new[] { "ClientContactInfoId" });
            DropIndex("dbo.Clients", new[] { "CompanyContactInfoId" });
            DropTable("dbo.Units");
            DropTable("dbo.ProductTypes");
            DropTable("dbo.Products");
            DropTable("dbo.ProductLists");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.Orders");
            DropTable("dbo.Employees");
            DropTable("dbo.CompanyContactInfoes");
            DropTable("dbo.ClientContactInfoes");
            DropTable("dbo.Clients");
            DropTable("dbo.Addresses");
        }
    }
}
