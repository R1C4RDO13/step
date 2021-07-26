using System;

namespace IxMilia.Step.Items
{
    public abstract class StepPlacement : StepGeometricRepresentationItem
    {
        private StepCartesianPoint _location;

        public StepCartesianPoint Location
        {
            get { return _location; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                _location = value;
            }
        }

        protected StepPlacement(string name)
            : base(name)
        {
        }


        protected StepPlacement(string name , StepCartesianPoint location)
            : base(name)
        {
            Location = location;
        }
    }
}
