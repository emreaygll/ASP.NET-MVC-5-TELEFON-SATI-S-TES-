namespace proje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        İsim = c.String(),
                        Acıklama = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        İsim = c.String(),
                        Acıklama = c.String(),
                        image = c.String(),
                        Fiyat = c.Double(nullable: false),
                        Stok = c.Int(nullable: false),
                        Slider = c.Boolean(nullable: false),
                        IsHome = c.Boolean(nullable: false),
                        IsFeatured = c.Boolean(nullable: false),
                        IsApproved = c.Boolean(nullable: false),
                        Kategoriid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Kategoris", t => t.Kategoriid, cascadeDelete: true)
                .Index(t => t.Kategoriid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uruns", "Kategoriid", "dbo.Kategoris");
            DropIndex("dbo.Uruns", new[] { "Kategoriid" });
            DropTable("dbo.Uruns");
            DropTable("dbo.Kategoris");
        }
    }
}
