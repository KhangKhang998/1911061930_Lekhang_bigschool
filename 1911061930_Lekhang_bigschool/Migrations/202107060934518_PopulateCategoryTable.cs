namespace _1911061930_Lekhang_bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID , NAME) VALUES (1, 'Do an Java') ");
            Sql("INSERT INTO CATEGORIES (ID , NAME) VALUES (2, 'Lap trinh web') ");
            Sql("INSERT INTO CATEGORIES (ID , NAME) VALUES (3, 'Lap trinh C') ");
            Sql("INSERT INTO CATEGORIES (ID , NAME) VALUES (4, 'Lap trinh java') ");
            Sql("INSERT INTO CATEGORIES (ID , NAME) VALUES (5, 'Toan cao cap') ");
        }
        
        public override void Down()
        {
        }
    }
}
