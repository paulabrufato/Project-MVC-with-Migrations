using Microsoft.EntityFrameworkCore;
using Projeto_VS.Models;

namespace Projeto_VS.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options) : base(options)
        {
        }
        //Contacts será o nome da tabela criada no banco
        public DbSet<ContactModel> Contacts { get; set; }
    }
}