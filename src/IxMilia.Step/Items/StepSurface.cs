namespace IxMilia.Step.Items
{
    public abstract class StepSurface : StepGeometricRepresentationItem
    {
        public StepSurface(string name)
            : base(name)
        {
        }


    }

    public class StepSurfaceComplex : StepSurface
    {
        private readonly StepComplexItem item;
        public override StepItemType ItemType => StepItemType.ComplexItem;


        public StepSurfaceComplex(StepComplexItem item) : base("ComplexItem")
        {
            this.item = item;
        }
    }


}
