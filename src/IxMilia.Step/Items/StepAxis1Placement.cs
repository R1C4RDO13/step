using IxMilia.Step.Syntax;
using System;
using System.Collections.Generic;

namespace IxMilia.Step.Items
{
    public class StepAxis1Placement : StepPlacement
    {
        public override StepItemType ItemType => StepItemType.Axis1Placement;

        private StepDirection _axis;
            
        public StepDirection Axis
        {
            get { return _axis; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                _axis = value;
            }
        }


        public StepAxis1Placement() : base(string.Empty)
        {
        }

        public StepAxis1Placement(string name , StepCartesianPoint location , StepDirection axis): base(name , location)
        {
            this.Axis = axis;
        }

        internal override IEnumerable<StepRepresentationItem> GetReferencedItems()
        {
            yield return Location;
            yield return Axis;
        }

        internal override IEnumerable<StepSyntax> GetParameters(StepWriter writer)
        {
            foreach (var parameter in base.GetParameters(writer))
            {
                yield return parameter;
            }

            yield return writer.GetItemSyntax(Location);
            yield return writer.GetItemSyntax(Axis);
        }

        internal static StepRepresentationItem CreateFromSyntaxList(StepBinder binder, StepSyntaxList syntaxList)
        {
            var axis = new StepAxis1Placement();
            syntaxList.AssertListCount(3);
            axis.Name = syntaxList.Values[0].GetStringValue();
            binder.BindValue(syntaxList.Values[1], v => axis.Location = v.AsType<StepCartesianPoint>());
            binder.BindValue(syntaxList.Values[2], v => axis.Axis = v.AsType<StepDirection>());
            return axis;
        }

    }
}
