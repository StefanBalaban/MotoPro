using System;
using System.Collections.Generic;
using System.Text;

namespace MotoPro.Services.Interfaces
{
    public interface ICrudServices<T>
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(T t);
        T Get(int id);
        T Post(T t);
        T Put(T t);
        bool Delete(T t);
    }
}
