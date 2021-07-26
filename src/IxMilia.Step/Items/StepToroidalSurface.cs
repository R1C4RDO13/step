using IxMilia.Step.Syntax;
using System.Collections.Generic;

namespace IxMilia.Step.Items
{
    public class StepToroidalSurface : StepElementarySurface
    {
        public override StepItemType ItemType => StepItemType.ToroidalSurface;

        /// <summary>
        /// Outside radius
        /// </summary>
        public double Major_radius{ get; set; } 
        /// <summary>
        /// Inside radius 
        /// </summary>
        public double Minor_radius{ get; set; }
        

        public StepToroidalSurface() 
            : base()
        {
        }

        public StepToroidalSurface(string name, StepAxis2Placement3D position , double major_radius , double minor_radius) : base (name , position)
        {
            Major_radius = major_radius;
            Minor_radius = minor_radius;
        }

        internal override IEnumerable<StepSyntax> GetParameters(StepWriter writer)
        {
            foreach (var parameter in base.GetParameters(writer))
            {
                yield return parameter;
            }

            yield return new StepRealSyntax(Major_radius);
            yield return new StepRealSyntax(Minor_radius);
        }

        internal static StepRepresentationItem CreateFromSyntaxList(StepBinder binder, StepSyntaxList syntaxList)
        {
            syntaxList.AssertListCount(4);
            var surface = new StepToroidalSurface();
            surface.Name = syntaxList.Values[0].GetStringValue();
            binder.BindValue(syntaxList.Values[1], v => surface.Position = v.AsType<StepAxis2Placement3D>());
            surface.Major_radius = syntaxList.Values[2].GetRealVavlue();
            surface.Minor_radius = syntaxList.Values[3].GetRealVavlue();
            return surface;
        }

    }
}
