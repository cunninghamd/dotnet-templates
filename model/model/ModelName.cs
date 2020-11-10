using System;
using System.Collections.Generic;

namespace Namespace
{
    public class ModelName
    {
        public ModelName() {}

        public int ModelNameID { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }

        public ICollection<RelatedModel> RelatedModels { get; set; }
    }
}
