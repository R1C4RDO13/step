using System;

namespace IxMilia.Step.Items
{
    public enum StepItemType
    {
        AdvancedFace,
        Axis1Placement,
        AxisPlacement2D,
        AxisPlacement3D,
        BSplineCurveWithKnots,
        CartesianPoint,
        Circle,
        CylindricalSurface,
        Direction,
        EdgeCurve,
        EdgeLoop,
        Ellipse,
        FaceBound,
        FaceOuterBound,
        Line,
        OrientedEdge,
        Plane,
        Vector,
        VertexPoint,
        ToroidalSurface,
        ClosedShell,
        SurfaceOfRevolution,
        ComplexItem
    }

    internal static class StepItemTypeExtensions
    {
        public const string AdvancedFaceText = "ADVANCED_FACE";
        public const string Axis2Placement2DText = "AXIS2_PLACEMENT_2D";
        public const string Axis2Placement3DText = "AXIS2_PLACEMENT_3D";
        public const string BSplineCurveWithKnotsText = "B_SPLINE_CURVE_WITH_KNOTS";
        public const string CartesianPointText = "CARTESIAN_POINT";
        public const string CircleText = "CIRCLE";
        public const string CylindricalSurfaceText = "CYLINDRICAL_SURFACE";
        public const string DirectionText = "DIRECTION";
        public const string EdgeCurveText = "EDGE_CURVE";
        public const string EdgeLoopText = "EDGE_LOOP";
        public const string EllipseText = "ELLIPSE";
        public const string FaceBoundText = "FACE_BOUND";
        public const string FaceOuterBoundText = "FACE_OUTER_BOUND";
        public const string LineText = "LINE";
        public const string OrientedEdgeText = "ORIENTED_EDGE";
        public const string PlaneText = "PLANE";
        public const string VectorText = "VECTOR";
        public const string VertexPointText = "VERTEX_POINT";
        public const string ToroidalSurfaceText = "TOROIDAL_SURFACE";
        public const string ClosedShellText = "CLOSED_SHELL";
        public const string SurfaceOfRevolutionText = "SURFACE_OF_REVOLUTION";
        public const string Axis1PlacementText = "AXIS1_PLACEMENT";

        public static string GetItemTypeString(this StepItemType type)
        {
            switch (type)
            {
                case StepItemType.AdvancedFace:
                    return AdvancedFaceText;
                case StepItemType.AxisPlacement2D:
                    return Axis2Placement2DText;
                case StepItemType.AxisPlacement3D:
                    return Axis2Placement3DText;
                case StepItemType.BSplineCurveWithKnots:
                    return BSplineCurveWithKnotsText;
                case StepItemType.CartesianPoint:
                    return CartesianPointText;
                case StepItemType.Circle:
                    return CircleText;
                case StepItemType.CylindricalSurface:
                    return CylindricalSurfaceText;
                case StepItemType.Direction:
                    return DirectionText;
                case StepItemType.EdgeCurve:
                    return EdgeCurveText;
                case StepItemType.EdgeLoop:
                    return EdgeLoopText;
                case StepItemType.Ellipse:
                    return EllipseText;
                case StepItemType.FaceBound:
                    return FaceBoundText;
                case StepItemType.FaceOuterBound:
                    return FaceOuterBoundText;
                case StepItemType.Line:
                    return LineText;
                case StepItemType.OrientedEdge:
                    return OrientedEdgeText;
                case StepItemType.Plane:
                    return PlaneText;
                case StepItemType.Vector:
                    return VectorText;
                case StepItemType.VertexPoint:
                    return VertexPointText;
                case StepItemType.ToroidalSurface:
                    return ToroidalSurfaceText;
                case StepItemType.ClosedShell:
                    return ClosedShellText;
                    //TODO: IMPLEMENT THIS ITEMS
                case StepItemType.SurfaceOfRevolution:
                    return SurfaceOfRevolutionText;
                case StepItemType.Axis1Placement:
                    return Axis1PlacementText;
                case StepItemType.ComplexItem:
                    throw new NotImplementedException("Complex items are still in development,");
                default:
                    throw new InvalidOperationException("Unexpected item type " + type);
            }
        }
    }
}
