using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteSage.Interface
{
    public interface ITesteSageRepository<T> where T : class
    {
        Task<T> Create(T item);
        Task<T> Update(T item);
        Task<bool> Delete(int id);
        Task<T> FindById(int id);
        Task<List<T>> FindAll();
        Task<bool> Exists(int? id);
    }
}
