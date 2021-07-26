using System.Collections.Generic;
using System.Runtime.CompilerServices;
using IxMilia.Step.Syntax;

[assembly: InternalsVisibleTo("StepInterpreter")]
namespace IxMilia.Step.Items
{
    public abstract partial class StepRepresentationItem
    {
        public abstract StepItemType ItemType { get; }

        public string Name { get; set; }

        protected StepRepresentationItem(string name)
        {
            Name = name;
        }

        internal virtual IEnumerable<StepRepresentationItem> GetReferencedItems()
        {
            yield break;
        }

        internal virtual IEnumerable<StepSyntax> GetParameters(StepWriter writer)
        {
            yield return new StepStringSyntax(Name);
        }
    }
}
