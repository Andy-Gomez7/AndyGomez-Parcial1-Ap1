using AndyGOmezAp1.Context;
using Microsoft.EntityFrameworkCore;
using AndyGOmezAp1.Models;
using Aplicada1.Core;
using System.Linq.Expressions;

namespace AndyGOmezAp.Services;

public class EstudianteService(IDbContextFactory<Contexto> DbFactory) : IService<Autor, int>
{
    public async Task<Autor?> Buscar(int AutorId)
    {
        await using var contexto = DbFactory.CreateDbContext();

        return await contexto.Autores.FirstOrDefaultAsync(E => E.AutorId == AutorId);
    }

    public async Task<bool> Existe(String nombres)
    {
        await using var contexto = DbFactory.CreateDbContext();

        return await contexto.Autores.AnyAsync(E => E.Nombres == nombres);
    }

    public async Task<bool> Insertar(Autor autor)
    {
        await using var contexto = DbFactory.CreateDbContext();

        contexto.Autores.Add(autor);

        return await contexto.SaveChangesAsync() > 0;
    } 

    public async Task<bool> Modificar(Autor autor)
    {
        await using var contexto = DbFactory.CreateDbContext();

        contexto.Autores.Update(autor);

        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Eliminar(int AutorId)
    {
        await using var contexto = DbFactory.CreateDbContext();

        return await contexto.Autores.ExecuteDeleteAsync() > 0;
    }

    public async Task<List<Autor>> GetList(Expression<Func<Autor, bool>> criterio)
    {
        await using var contexto = DbFactory.CreateDbContext();

        return await contexto.Autores.Where(E => E.AutorId > 0).AsNoTracking().ToListAsync();
    }

    public async Task<bool> Guardar(Autor autor)
    {
        if (autor.AutorId == 0)
        {
            return await Guardar(autor);
        }
        else
        {
            return await Modificar(autor);
        }
    }
}