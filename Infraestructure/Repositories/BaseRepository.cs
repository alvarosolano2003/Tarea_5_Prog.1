using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class BaseRepository<T> : IModel<T>
    {
        protected List<T> data;

        public BaseRepository()
        {
            data = new List<T>();
        }
        public void Create(T t)
        {
            if (t == null)
            {
                throw new ArgumentException("Hay elementos inexistentes. Compruebe los datos nuevamente");
            }

            data.Add(t);
        }

        public void Delete(T t)
        {
            if (t == null)
            {
                throw new ArgumentException("Hay elementos inexistentes. Compruebe los datos nuevamente.");
            }

            data.Remove(t);
        }

        public T[] GetAll()
        {
            if (data == null)
            {
                throw new ArgumentException("No se han agregado datos aun.");
            }

            return data.ToArray();
        }

        public int GetLastIndex()
        {
            if (data == null)
            {
                throw new ArgumentException("No se han agregado datos aun.");
            }

            //Se hara despues el metodo, todavia no estan los datos necesarios
            throw new NotImplementedException();
        }

        public void Update(int index, T t)
        {
            if (index > 1 || t == null)
            {
                throw new ArgumentException("Hay elementos inexistentes. Compruebe los datos nuevamente.");
            }

            data.Insert(index, t);
        }
    }
}
