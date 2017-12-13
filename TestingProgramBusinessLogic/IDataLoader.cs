using System.Collections.Generic;

namespace TestingProgramBusinessLogic
{
    public interface IDataLoader<T> where T:class
    {
        IEnumerable<T> GetCollection();
    }
}