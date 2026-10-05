using Microsoft.EntityFrameworkCore;

namespace Estharlyn_Ap1_P1.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options){}
}