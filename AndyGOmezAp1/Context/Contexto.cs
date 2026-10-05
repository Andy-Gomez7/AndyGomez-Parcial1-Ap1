using Microsoft.EntityFrameworkCore;

namespace AndyGOmezAp1.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options){}
}