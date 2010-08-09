using System.Collections.Generic;

namespace Task.BaseInterfaces
{
    public interface IQuery<T>
    {
        T Single(long id);
        IEnumerable<T> All();
    }
}