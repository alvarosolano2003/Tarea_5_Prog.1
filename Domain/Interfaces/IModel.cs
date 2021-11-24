using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        void Create(T t);
        T[] GetAll();
        void Update(int index, T t2);
        void Delete(T t);
    }
}
