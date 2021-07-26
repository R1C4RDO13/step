using IxMilia.Step.Syntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace IxMilia.Step.Items
{
    public class StepSurfaceOfRevolutation :StepSwepSurface
    {
        public override StepItemType ItemType => StepItemType.SurfaceOfRevolution;


        public StepCurve SwepCurve { get; set; }
        public StepAxis1Placement AxisPosition { get; set; }

        public StepSurfaceOfRevolutation(): base(string.Empty)
        {
        }

        public StepSurfaceOfRevolutation(string name , StepCurve swepCurve , StepAxis1Placement stepAxis1Placement):
          base(name)
        {
            SwepCurve = swepCurve;
            AxisPosition = stepAxis1Placement;
        }

        internal override IEnumerable<StepSyntax> GetParameters(StepWriter writer)
        {
            foreach (var parameter in base.GetParameters(writer))
            {
                yield return parameter;
            }

            yield return writer.GetItemSyntax(SwepCurve);
            yield return writer.GetItemSyntax(AxisPosition);
        }

        internal static StepRepresentationItem CreateFromSyntaxList(StepBinder binder, StepSyntaxList syntaxList)
        {
            syntaxList.AssertListCount(3);
            var surface = new StepSurfaceOfRevolutation();
            surface.Name = syntaxList.Values[0].GetStringValue();
            binder.BindValue(syntaxList.Values[1], v => surface.SwepCurve = v.AsType<StepCurve>());
            binder.BindValue(syntaxList.Values[2], v => surface.AxisPosition = v.AsType<StepAxis1Placement>());

            return surface;
        }
    }
}
