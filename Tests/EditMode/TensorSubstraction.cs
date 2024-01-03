using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using DNAMatrices;


/// <summary>
/// Covers all Substraction Based Operations
/// </summary>
public class TensorSubstraction
{
    static int[] DefaultDimension = new int[] { 2, 4, 4 };
    int[] integerValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
    double[] doubleValues = new double[] { 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1, 1.5, 2.5 };

    DNATensor DoubleIncrement = DNATensor.Increment(DefaultDimension) * 2;
    DNATensor Increment = new DNATensor(DefaultDimension);
    DNATensor Empty = new DNATensor(DefaultDimension);

    TestHelper Helper = new TestHelper();

    /// <summary>
    /// Covers Substraction of 2 Tensors
    /// </summary>
    [Test]
    public void Substraction()
    {
        DNATensor Tensor1 = DNATensor.Increment(DefaultDimension);
        DNATensor Tensor2 = DNATensor.Increment(DefaultDimension);

        DNATensor ResultTensor = Tensor1 - Tensor2;

        double[] values = Helper.GetSameValues(DefaultDimension, 0);

        Assert.AreEqual(ResultTensor.Dimensions, Empty.Dimensions);
        Assert.AreEqual(ResultTensor.Values, values);
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

            double[] values = Helper.ScalarSub(Helper.GetIncrementValues(DefaultDimension), scalar);

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

            double[] values = Helper.ScalarSub(Helper.GetEmptyValues(DefaultDimension), scalar);

            Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
            Assert.AreEqual(ResultTensor.Values, values);
        }
    }

    /// <summary>
    /// Covers Integer Substraction
    /// </summary>
    [Test]
    public void ScalarDoubleSubstraction()
    {
        foreach (double scalar in doubleValues)
        {
            DNATensor Tensor = DNATensor.Increment(DefaultDimension);

            DNATensor ResultTensor = Tensor - scalar;

            double[] values = Helper.ScalarSub(Helper.GetIncrementValues(DefaultDimension), scalar);

            Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
            Assert.AreEqual(ResultTensor.Values, values);
        }
    }

    /// <summary>
    /// Covers Integer Substraction
    /// </summary>
    [Test]
    public void ScalarDoubleSubstractionEmpty()
    {
        foreach (double scalar in doubleValues)
        {
            DNATensor Tensor = new DNATensor(DefaultDimension);

            DNATensor ResultTensor = Tensor - scalar;

            double[] values = Helper.ScalarSub(Helper.GetEmptyValues(DefaultDimension), scalar);

            Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
            Assert.AreEqual(ResultTensor.Values, values);
        }
    }

}
