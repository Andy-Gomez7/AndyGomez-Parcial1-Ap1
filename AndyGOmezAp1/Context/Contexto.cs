using Microsoft.EntityFrameworkCore;
using AndyGOmezAp1.Models;
namespace AndyGOmezAp1.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options){}

    public DbSet<Autor> Autores { get; set;}
}