namespace IxMilia.Step.Items
{
    public abstract class StepCurve : StepGeometricRepresentationItem
    {
        protected StepCurve(string name)
            : base(name)
        {
        }

    }

    public class StepCurveComplex : StepCurve
    {
        public override StepItemType ItemType => ~StepItemType.ComplexItem;

        private readonly StepComplexItem item;

        public StepCurveComplex(StepComplexItem item) : base("Complex curve")
        {
            this.item = item;
        }
    }
}
