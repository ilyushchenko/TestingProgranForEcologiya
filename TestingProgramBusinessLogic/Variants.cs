using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProgramBusinessLogic
{
    public class Variants : IDataLoader<Variant>
    {
        public IEnumerable<Variant> GetCollection()
        {
            return new Variant[]
            {
            };
        }
    }
}
