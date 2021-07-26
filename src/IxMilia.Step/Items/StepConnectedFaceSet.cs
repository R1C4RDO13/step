using IxMilia.Step.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace IxMilia.Step.Items
{
    public abstract class StepConnectedFaceSet : StepTopologicalRepresentationItem
    {
        public List<StepFace> Faces { get;  } = new List<StepFace>();

        public StepConnectedFaceSet(string name) 
            : base (name)
        {

        }

        internal override IEnumerable<StepSyntax> GetParameters(StepWriter writer)
        {
            foreach (var parameter in base.GetParameters(writer))
            {
                yield return parameter;
            }

            yield return new StepSyntaxList(Faces.Select(b => writer.GetItemSyntax(b)));
        }

    }
}
