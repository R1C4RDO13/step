using System;

namespace IxMilia.Step.Items
{
    public abstract class StepAxis2Placement : StepPlacement
    {
       
        private StepDirection _refDirection;

        public StepDirection RefDirection
        {
            get { return _refDirection; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                _refDirection = value;
            }
        }

        protected StepAxis2Placement(string name)
            : base(name)
        {
        }

        protected StepAxis2Placement(string name , StepCartesianPoint stepCartesianPoint , StepDirection direction)
       : base(name , stepCartesianPoint)
        {
            RefDirection = direction;
        }
    }
}
