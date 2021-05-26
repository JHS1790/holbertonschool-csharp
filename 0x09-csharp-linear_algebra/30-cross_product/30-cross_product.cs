using System;

class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
            return -1;
            
        double ax = vector1[0], ay = vector1[1], az = vector1[2];
        double bx = vector2[0], by = vector2[1], bz = vector2[2];

        double cx = (ay * bz) - (az * by);
        double cy = (az * bx) - (ax * bz);
        double cz = (ax * by) - (ay * bx);

        return new double[] { cx, cy, cz };
    }
}
