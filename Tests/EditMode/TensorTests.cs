using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using DNAMatrices;

public class TensorTests
{
    static int[] DefaultDimension = new int[] { 2, 4, 4 };
    int[] integerValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
    double[] doubleValues = new double[] { 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1, 1.5, 2.5 };

    DNATensor DoubleIncrement = DNATensor.Increment(DefaultDimension)* 2;
    DNATensor Increment = new DNATensor(DefaultDimension);
    DNATensor Empty = new DNATensor(DefaultDimension);



    /// <summary>
    /// Covers Addition of 2 Tensors
    /// </summary>
    [Test]
    public void TensorAddition()
    {
        DNATensor Tensor1 = DNATensor.Increment(DefaultDimension);
        DNATensor Tensor2 = DNATensor.Increment(DefaultDimension);

        DNATensor ResultTensor = Tensor1 + Tensor2;

        double[] values = ScalarMult(GetIncrementValues(DefaultDimension), 2);

        Assert.AreEqual(ResultTensor.Dimensions, Tensor1.Dimensions);
        Assert.AreEqual(ResultTensor.Values, values);
    }

    /// <summary>
    /// Covers Substraction of 2 Tensors
    /// </summary>
    [Test]
    public void TensorSubstraction()
    {
        DNATensor Tensor1 = DNATensor.Increment(DefaultDimension);
        DNATensor Tensor2 = DNATensor.Increment(DefaultDimension);

        DNATensor ResultTensor = Tensor1 - Tensor2;

        double[] values = GetSameValues(DefaultDimension, 0);

        Assert.AreEqual(ResultTensor.Dimensions, Empty.Dimensions);
        Assert.AreEqual(ResultTensor.Values, values);
    }

    /// <summary>
    /// Covers Integer Addition
    /// </summary>
    [Test]
    public void ScalarIntAddition()
    {
        foreach (int scalar in integerValues)
        {
            DNATensor Tensor = DNATensor.Increment(DefaultDimension);

            DNATensor ResultTensor = Tensor + scalar;

            double[] values = ScalarAdd(GetIncrementValues(DefaultDimension), scalar);

            Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
            Assert.AreEqual(ResultTensor.Values, values);
        }
    }

    /// <summary>
    /// Covers Integer Addition
    /// </summary>
    [Test]
    public void ScalarIntAdditionEmpty()
    {
        foreach (int scalar in integerValues)
        {
            DNATensor Tensor = new DNATensor(DefaultDimension);

            DNATensor ResultTensor = Tensor + scalar;

            double[] values = ScalarAdd(GetEmptyValues(DefaultDimension), scalar);

            Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
            Assert.AreEqual(ResultTensor.Values, values);
        }
    }

    /// <summary>
    /// Covers Integer Substraction
    /// </summary>
    [Test]
    public void ScalarIntSubstraction()
    {
        foreach (int scalar in integerValues)
        {
            DNATensor Tensor = DNATensor.Increment(DefaultDimension);

            DNATensor ResultTensor = Tensor - scalar;

            double[] values = ScalarSub(GetIncrementValues(DefaultDimension), scalar);

            Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
            Assert.AreEqual(ResultTensor.Values, values);
        } 
    }

    /// <summary>
    /// Covers Integer Substraction
    /// </summary>
    [Test]
    public void ScalarIntSubstractionEmpty()
    {
        foreach (int scalar in integerValues)
        {
            DNATensor Tensor = new DNATensor(DefaultDimension);

            DNATensor ResultTensor = Tensor - scalar;

            double[] values = ScalarSub(GetEmptyValues(DefaultDimension), scalar);

            Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
            Assert.AreEqual(ResultTensor.Values, values);
        }
    }

    /// <summary>
    /// Covers Integer Multiplication
    /// </summary>
    [Test]
    public void ScalarIntMultiplication()
    {
        foreach (int scalar in integerValues)
        {
            DNATensor Tensor = DNATensor.Increment(DefaultDimension);

            DNATensor ResultTensor = Tensor * scalar;

            double[] values = ScalarMult(GetIncrementValues(DefaultDimension), scalar);

            Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
            Assert.AreEqual(ResultTensor.Values, values);
        }
    }

    /// <summary>
    /// Covers Integer Multiplication
    /// </summary>
    [Test]
    public void ScalarIntMultiplicationEmpty()
    {
        foreach (int scalar in integerValues)
        {
            DNATensor Tensor = new DNATensor(DefaultDimension);

            DNATensor ResultTensor = Tensor * scalar;

            double[] values = ScalarMult(GetEmptyValues(DefaultDimension), scalar);

            Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
            Assert.AreEqual(ResultTensor.Values, values);
        }
    }

    /// <summary>
    /// Covers Integer Division
    /// </summary>
    [Test]
    public void ScalarIntDivision()
    {
        foreach (int scalar in integerValues)
        {
            DNATensor Tensor = DNATensor.Increment(DefaultDimension);

            DNATensor ResultTensor = Tensor / scalar;

            double[] values = ScalarDiv(GetIncrementValues(DefaultDimension), scalar);

            Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
            Assert.AreEqual(ResultTensor.Values, values);
        }
    }

    /// <summary>
    /// Covers Integer Division
    /// </summary>
    [Test]
    public void ScalarIntDivisionEmpty()
    {
        foreach (int scalar in integerValues)
        {
            DNATensor Tensor = new DNATensor(DefaultDimension);

            DNATensor ResultTensor = Tensor / scalar;

            double[] values = ScalarDiv(GetEmptyValues(DefaultDimension), scalar);

            Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
            Assert.AreEqual(ResultTensor.Values, values);
        }
    }


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


    private int GetLength(int[] dimensions)
    {
        int length = 1;
        foreach (int dimension in dimensions)
            length *= dimension;
        return length;
    }

}
