using System.Data.Entity;

namespace EBoutique.Models
{
    public class BdBoutiqueContext : DbContext
    {
        public BdBoutiqueContext() : base("conn")
        {

        }

        public DbSet<Produit> produits { get; set; }
        public DbSet<Categorie> categories { get; set; }
        public DbSet<Client> clients { get; set; }
    }
}