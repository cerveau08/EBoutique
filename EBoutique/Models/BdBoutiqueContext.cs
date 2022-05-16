using System.Data.Entity;

namespace EBoutique.Models
{
    public class BdBoutiqueContext : DbContext
    {
        public BdBoutiqueContext() : base("conn")
        {

        }

        public DbSet<Produit> produits { get; set; }
    }
}