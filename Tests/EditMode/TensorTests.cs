using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using DNAMatrices;

public class TensorTests
{
    DNATensor DoubleIncrement = DNATensor.Increment(new int[] { 2, 4, 4 }) * 2;
    DNATensor Increment = new DNATensor(new int[] { 2, 4, 4 });


    /// <summary>
    /// Covers Addition of 2 Tensors
    /// </summary>
    [Test]
    public void TensorAddition ()
    {
        DNATensor Tensor1 = DNATensor.Increment(new int[] { 2, 4, 4 });
        DNATensor Tensor2 = DNATensor.Increment(new int[] { 2, 4, 4 });

        DNATensor ResultTensor = Tensor1 + Tensor2 + Tensor1;

        Assert.AreEqual(ResultTensor.Dimensions, DoubleIncrement.Dimensions);
        Assert.AreEqual(ResultTensor.Values, DoubleIncrement.Values);
    }


    [Test]
    public void SameDimension (DNATensor tensor1, DNATensor tensor2)
    {
    }
}
