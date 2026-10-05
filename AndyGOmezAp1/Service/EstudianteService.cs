using AndyGOmezAp1.Context;
using Microsoft.EntityFrameworkCore;
using AndyGOmezAp1.Models;
using Aplicada1.Core;

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

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Autor>> GetList(System.Linq.Expressions.Expression<Func<Autor, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Autor entidad)
    {
        throw new NotImplementedException();
    }
}