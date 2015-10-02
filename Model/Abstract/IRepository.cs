using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DammapadaReader.Model.Abstract
{
    public interface IRepository<T>
    {
        IQueryable<T> Items { get; }
        void Insert(T item);
        void Remove(T item);
        void Update(T item);
    }
}
