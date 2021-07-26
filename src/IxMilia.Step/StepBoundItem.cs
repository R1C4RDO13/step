using IxMilia.Step.Items;
using IxMilia.Step.Syntax;
using System.Linq;

namespace IxMilia.Step
{
    internal class StepBoundItem
    {
        public StepSyntax CreatingSyntax { get; }
        public StepRepresentationItem Item { get; }
        public bool IsAuto { get; private set; }

        public StepBoundItem(StepRepresentationItem item, StepSyntax creatingSyntax)
        {
            CreatingSyntax = creatingSyntax;
            Item = item;
        }

        public TItemType AsType<TItemType>(System.Func<StepComplexItem , TItemType> ComplexToSimple = null) where TItemType : StepRepresentationItem 
        {
            TItemType result = null;
            if (IsAuto)
            {
                // do nothing; null is expected
            }
            else
            {
                result = Item as TItemType;
                if (result == null)
                {
                    if (ComplexToSimple != null &&  Item is StepComplexItem complexItem)
                    {
                        return ComplexToSimple(complexItem);
                    }

                    throw new StepReadException("Unexpected type", CreatingSyntax.Line, CreatingSyntax.Column);
                }
            }

            return result;
        }

        public static StepBoundItem AutoItem(StepSyntax creatingSyntax)
        {
            var boundItem = new StepBoundItem(null, creatingSyntax);
            boundItem.IsAuto = true;
            return boundItem;
        }
    }
}
