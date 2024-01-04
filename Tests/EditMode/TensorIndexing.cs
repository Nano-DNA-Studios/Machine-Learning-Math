using System.Collections;
using System.Collections.Generic;
using DNAMatrices;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

/// <summary>
/// Covers Indexing Operations for Tensors
/// </summary>
public class TensorIndexing
{
    TestHelper Helper = new TestHelper();


    [Test]
    public void AllValuesIndex()
    {
        DNATensor tensor = DNATensor.Increment(Helper.DefaultDimension);

        Assert.AreEqual(tensor.Length, Helper.IncrememtArray.Length);

        for (int i = 0; i < tensor.Length; i++)
            Assert.AreEqual(tensor[i], Helper.IncrememtArray[i]);
    }

    [Test]
    public void AllValuesIndexEmpty()
    {
        DNATensor tensor = new DNATensor(Helper.DefaultDimension);

        Assert.AreEqual(tensor.Length, Helper.EmptyArray.Length);

        for (int i = 0; i < tensor.Length; i++)
            Assert.AreEqual(tensor[i], Helper.EmptyArray[i]);
    }

    [Test]
    public void SetCertainIndexValue()
    {
        DNATensor tensor = new DNATensor(Helper.DefaultDimension);
        double[] values = Helper.GetEmptyValues(Helper.DefaultDimension);

        Assert.AreEqual(values.Length, tensor.Length);

        SetIndex(tensor, values);

        Assert.AreEqual(tensor.Values, values);
    }

    [Test]
    public void GetCertainIndexValue()
    {
        DNATensor tensor = new DNATensor(Helper.DefaultDimension);
        double[] values = Helper.GetEmptyValues(Helper.DefaultDimension);

        Assert.AreEqual(values.Length, tensor.Length);

        SetIndex(tensor, values);

        foreach (int index in Helper.indexValues)
            Assert.AreEqual(values[index], tensor[index]);
    }

    [Test]
    public void GetAccurateFlatIndex()
    {
        DNATensor tensor = new DNATensor(Helper.DefaultDimension);

        int count = 0;
        foreach (int index in Helper.shortIndexValues)
        {
            Assert.AreEqual(index, tensor.GetFlatIndex(Helper.indexes[count]));
            count++;
        }
    }

    [Test]
    public void GetAccurateIndex()
    {
        DNATensor tensor = new DNATensor(Helper.DefaultDimension);

        int count = 0;
        foreach (int[] index in Helper.indexes)
        {
            Assert.AreEqual(index, tensor.GetIndex(Helper.shortIndexValues[count]));
            count++;
        }
    }

    private void SetIndex(DNATensor tensor, double[] values)
    {
        int count = 0;
        foreach (int index in Helper.indexValues)
        {
            values[index] = Helper.indexValues[count];
            tensor[index] = Helper.indexValues[count];
            count++;
        }
    }



}
