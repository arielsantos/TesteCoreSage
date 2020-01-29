using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSage.Interface;

namespace TesteSage.Repository
{
    public class TesteSageRepository<T> : ITesteSageRepository<T> where T : class, IEntity
    {
        private readonly TesteSageContext context;
        private DbSet<T> dataset;


        public TesteSageRepository(TesteSageContext context)
        {
            this.context = context;
            dataset = this.context.Set<T>();
        }

        public async Task<T> Create(T item)
        {
            try
            {
                dataset.Add(item);
                await this.context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }


        public async Task<bool> Delete(int id)
        {
            var result = await FindById(id);

            try
            {
                if (result != null) dataset.Remove(result);
                return (await this.context.SaveChangesAsync()) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<List<T>> FindAll()
        {
            return await context.Set<T>().AsNoTracking().ToListAsync();

        }


        public async Task<T> FindById(int id)
        {
            return await dataset.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> Exists(int? id)
        {
            return await dataset.AnyAsync(a => a.Id.Equals(id));
        }



        public async Task<T> Update(T item)
        {
            if (!Exists(item.Id).Result) return null;

            var result = dataset.FirstOrDefaultAsync(i => i.Id.Equals(item.Id)).Result;

            if (result != null)
            {
                try
                {
                    this.context.Entry(result).CurrentValues.SetValues(item);
                    await this.context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }
    }
}
