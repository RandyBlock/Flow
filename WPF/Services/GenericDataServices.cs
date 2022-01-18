using Flow.WPF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Flow.WPF.Services
{
    public class GenericDataServices<T> : IDataService<T> where T : DomainObject
    {
        private readonly FlowDBContextFactory _contextFactory;
       //public string[] args = default!;

        public GenericDataServices(FlowDBContextFactory contextfactory) { _contextFactory = contextfactory; }
        public async Task<T> Create(T entity)
        {
            using (FlowDBContext context = _contextFactory.CreateDbContext(default!))
            {
                EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return createdResult.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (FlowDBContext context = _contextFactory.CreateDbContext(default!))
            {
#nullable disable 
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == e.Id);
#nullable enable
                if (entity == null) { return false; }
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (FlowDBContext context = _contextFactory.CreateDbContext(default!))
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
                return entities;

            }
        }
        public async Task<T> GetById(int id)
        {
            using (FlowDBContext context = _contextFactory.CreateDbContext(default!))
            {
#nullable disable
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
#nullable enable

            }
        }
        public async Task<T> Update(int id, T entity)
        {
            using (FlowDBContext context = _contextFactory.CreateDbContext(default!))
            {
                entity.Id = id;

                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }
    }
}
