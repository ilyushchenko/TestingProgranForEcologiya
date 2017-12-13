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
                new Variant(){VariantNuimber=1, Answer=16}, 
                new Variant(){VariantNuimber=2, Answer=6.5}
            };
        }
    }
}
