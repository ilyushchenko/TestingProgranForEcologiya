using System.Collections.Generic;

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
