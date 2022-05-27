

namespace BankTransactionsCoreMVC.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base (options)
        {

        }

        //What we need in the db after migration 
        //Therefore we need a property here that connected to the Transaction Model 

        public DbSet<Transaction> Transactions { get; set; } 
        //After creating the Db the corresponding table for Transaction Model will be Transactions 
    }
}
