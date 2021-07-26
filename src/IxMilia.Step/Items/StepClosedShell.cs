using IxMilia.Step.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace IxMilia.Step.Items
{
    public class StepClosedShell : StepConnectedFaceSet
    {
        public override StepItemType ItemType => StepItemType.ClosedShell;

        public StepClosedShell(string name):
            base(name)
        {
        }

        public StepClosedShell():
            base(string.Empty)
        {
        }

        public StepClosedShell(string name , IEnumerable<StepFace> faces) :
    base(name)
        {
            this.Faces.Clear();
            for (int i = 0; i < faces.Count(); i++)
            {
                Faces.Add(faces.ElementAt(i));
            }
        }

        internal static StepClosedShell CreateFromSyntaxList(StepBinder binder, StepSyntaxList syntaxList)
        {
            var closedShell = new StepClosedShell();
            syntaxList.AssertListCount(2);
            closedShell.Name = syntaxList.Values[0].GetStringValue();

            var faceSet = syntaxList.Values[1].GetValueList();
            closedShell.Faces.Clear();
            closedShell.Faces.AddRange(Enumerable.Range(0, faceSet.Values.Count).Select(_ => (StepFace)null));
            for (int i = 0; i < faceSet.Values.Count; i++)
            {
                var j = i; // capture to avoid rebinding
                binder.BindValue(faceSet.Values[j], v => closedShell.Faces[j] = v.AsType<StepFace>());
            }
           
            return closedShell;
        }

    }
}
