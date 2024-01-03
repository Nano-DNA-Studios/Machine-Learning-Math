using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHelper
{
    /// 
    /// Helper Functions
    /// 
    public double[] ScalarDiv(double[] values, double scalar)
    {
        for (int i = 0; i < values.Length; i++)
            values[i] /= scalar;

        return values;
    }

    public double[] ScalarMult(double[] values, double scalar)
    {
        for (int i = 0; i < values.Length; i++)
            values[i] *= scalar;

        return values;
    }

    public double[] ScalarSub(double[] values, double scalar)
    {
        for (int i = 0; i < values.Length; i++)
            values[i] -= scalar;

        return values;
    }

    public double[] ScalarAdd(double[] values, double scalar)
    {
        for (int i = 0; i < values.Length; i++)
            values[i] += scalar;

        return values;
    }

    public double[] GetSameValues(int[] dimensions, double value)
    {
        double[] values = GetEmptyValues(dimensions);

        for (int i = 0; i < values.Length; i++)
            values[i] = value;

        return values;
    }

    public double[] GetIncrementValues(int[] dimensions)
    {
        double[] values = GetEmptyValues(dimensions);

        for (int i = 0; i < values.Length; i++)
            values[i] = i;

        return values;
    }

    public double[] GetEmptyValues(int[] dimensions)
    {
        int length = GetLength(dimensions);

        double[] values = new double[length];

        return values;
    }


    public int GetLength(int[] dimensions)
    {
        int length = 1;
        foreach (int dimension in dimensions)
            length *= dimension;
        return length;
    }

}
