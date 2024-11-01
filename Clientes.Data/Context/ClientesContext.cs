using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clientes.Data.Models;

namespace Clientes.Data.Context;

public class ClientesContext : DbContext
{
    public ClientesContext(DbContextOptions<ClientesContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
}
