using Fim_Insura.webApi;
using System;
using System.Data.Entity;
using System.Linq;

namespace Fim_Insura.Forms
{
    public class Insura_Context : DbContext
    {
        // Your context has been configured to use a 'Insura_Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Fim_Insura.Forms.Insura_Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Insura_Context' 
        // connection string in the application configuration file.
        public Insura_Context()
            : base("name=Insura_Context")
        {
        }
        public virtual DbSet<ClientTB> ClientTB { get; set; }
        public virtual DbSet<AdminTB> AdminTB { get; set; }
        public virtual DbSet<ProductTB> ProductTB { get; set; }
        public virtual DbSet<ClaimTB> ClaimTB { get; set; }

   
            // Add a DbSet for each entity type that you want to include in your model. For more information 
            // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

            // public virtual DbSet<MyEntity> MyEntities { get; set; }
        }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}