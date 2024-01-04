using System.Collections;
using System.Collections.Generic;
using DNAMatrices;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

/// <summary>
/// Covers Matrix Properties
/// </summary>
public class TensorMatrixIndexing
{
    TestHelper Helper = new TestHelper();


    [Test]
    public void AccessEmptyMatrix ()
    {
        DNATensor tensor = new DNATensor(Helper.DefaultDimension);
        DNAMatrix emptyMatrix = Helper.EmptyMatrix;


        //First Matrix
        Assert.AreEqual(tensor.MatrixProperties[0].Dimensions, emptyMatrix.Dimensions);
        Assert.AreEqual(tensor.MatrixProperties[0].Length, emptyMatrix.Length);
        Assert.AreEqual(tensor.MatrixProperties[0].Height, emptyMatrix.Height);
        Assert.AreEqual(tensor.MatrixProperties[0].Width, emptyMatrix.Width);
        Assert.AreEqual(tensor.MatrixProperties[0].Values, emptyMatrix.Values);


        //Second Matrix
        Assert.AreEqual(tensor.MatrixProperties[1].Dimensions, emptyMatrix.Dimensions);
        Assert.AreEqual(tensor.MatrixProperties[1].Length, emptyMatrix.Length);
        Assert.AreEqual(tensor.MatrixProperties[1].Height, emptyMatrix.Height);
        Assert.AreEqual(tensor.MatrixProperties[1].Width, emptyMatrix.Width);
        Assert.AreEqual(tensor.MatrixProperties[1].Values, emptyMatrix.Values);
    }

    [Test]
    public void AccessIncrementMatrix()
    {
        DNATensor tensor = DNATensor.Increment(Helper.DefaultDimension);
        DNAMatrix incrementMatrix = DNAMatrix.Increment(4, 4);

        //First Matrix
        Assert.AreEqual(tensor.MatrixProperties[0].Dimensions, incrementMatrix.Dimensions);
        Assert.AreEqual(tensor.MatrixProperties[0].Length, incrementMatrix.Length);
        Assert.AreEqual(tensor.MatrixProperties[0].Height, incrementMatrix.Height);
        Assert.AreEqual(tensor.MatrixProperties[0].Width, incrementMatrix.Width);
        Assert.AreEqual(tensor.MatrixProperties[0].Values, incrementMatrix.Values);

        incrementMatrix += 16;

        //Second Matrix
        Assert.AreEqual(tensor.MatrixProperties[1].Dimensions, incrementMatrix.Dimensions);
        Assert.AreEqual(tensor.MatrixProperties[1].Length, incrementMatrix.Length);
        Assert.AreEqual(tensor.MatrixProperties[1].Height, incrementMatrix.Height);
        Assert.AreEqual(tensor.MatrixProperties[1].Width, incrementMatrix.Width);
        Assert.AreEqual(tensor.MatrixProperties[1].Values, incrementMatrix.Values);
    }








}
