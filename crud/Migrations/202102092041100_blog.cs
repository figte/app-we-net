namespace crud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
   
    
    public partial class blog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.post",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        titulo = c.String(maxLength: 50, unicode: false),
                        descripcion = c.String(maxLength: 100, unicode: false),
                        idautor = c.Int(),
                    })
                .PrimaryKey(t => t.id);

            
        }
        
        public override void Down()
        {
            DropTable("dbo.post");
        }
    }
}
