using System.Collections.Generic;

namespace TestingProgram.Data
{
    public interface IDataLoader<T> where T:IVariant
    {
        IEnumerable<T> GetCollection();
    }
}