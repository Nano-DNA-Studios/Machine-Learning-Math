using DNAMatrices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHelper
{
    private static int[] _DefaultDimension = { 2, 4, 4 };
    private static int[] _StackedDefaultDimension = { 3, 4, 4 };
    public int[] StackedDefaultDimension = { 3, 4, 4 };
    public int[] DefaultDimension = new int[] { 2, 4, 4 };
    public int[] integerValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
    public int[] indexValues = new int[] { 0, 1, 2, 6, 7, 12, 15, 16, 18, 23, 27, 31 };
    public int[] shortIndexValues = new int[] { 0, 6, 12, 18, 27, 31 };
    public int[][] indexes = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 1, 2 }, new int[] { 0, 3, 0}, new int[] { 1, 0, 2 }, new int[] { 1, 2, 3 }, new int[] { 1, 3, 3 } };
    public double[] doubleValues = new double[] { 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1, 1.5, 2.5 };

    public DNATensor DoubleIncrement = DNATensor.Increment(_DefaultDimension) * 2;
    public DNATensor Increment = new DNATensor(_DefaultDimension);
    public DNATensor Empty = new DNATensor(_DefaultDimension);
    public DNATensor StackedEmptyTensor = new DNATensor(_StackedDefaultDimension);
    public DNATensor StackedIncrementTensor = _Increment ^ _IncrementMatrix;

    private static DNATensor _Increment = new DNATensor(_DefaultDimension);
    private static DNATensor _Empty = new DNATensor(_DefaultDimension);

    public DNAMatrix EmptyMatrix = new DNAMatrix(4, 4);
    public DNAMatrix IncrementMatrix = DNAMatrix.Increment(4, 4);
    private static DNAMatrix _IncrementMatrix = DNAMatrix.Increment(4, 4);

    public double[] IncrememtArray = DNATensor.Increment(_DefaultDimension).Values;
    public double[] EmptyArray = new DNATensor(_DefaultDimension).Values;

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
