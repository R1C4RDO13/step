using IxMilia.Step.Syntax;
using System;
using System.Collections.Generic;

namespace IxMilia.Step.Items
{
    public class StepComplexItem : StepRepresentationItem
    {
        public override StepItemType ItemType => StepItemType.ComplexItem;

        internal readonly List<StepSimpleItemSyntax> Items;

        internal StepComplexItem(List<StepSimpleItemSyntax> items) : base("COMPLEX_ITEM")
        {
            Items = items;
        }

    }
}
