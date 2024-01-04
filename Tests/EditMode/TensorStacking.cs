using System.Collections;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using DNAMatrices;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TensorStacking
{
    TestHelper Helper = new TestHelper();

    [Test]
    public void EmptyMatrixStacking ()
    {
        DNAMatrix matrix1 = new DNAMatrix(4, 4);
        DNAMatrix matrix2 = new DNAMatrix(4, 4);

        DNATensor tensor = matrix1 ^ matrix2;

        //First Matrix
        Assert.IsTrue(MatricesAreEqual(tensor.MatrixProperties[0], matrix1));

        //Second Matrix
        Assert.IsTrue(MatricesAreEqual(tensor.MatrixProperties[1], matrix1));
    }

    [Test]
    public void IncrementMatrixStacking()
    {
        DNAMatrix matrix1 = DNAMatrix.Increment(4, 4);
        DNAMatrix matrix2 = DNAMatrix.Increment(4, 4);

        DNATensor tensor = matrix1 ^ matrix2;

        //First Matrix
        Assert.AreEqual(tensor.MatrixProperties[0].Dimensions, matrix1.Dimensions);
        Assert.AreEqual(tensor.MatrixProperties[0].Values, matrix1.Values);
        Assert.AreEqual(tensor.MatrixProperties[0].Length, matrix1.Length);
        Assert.AreEqual(tensor.MatrixProperties[0].Width, matrix1.Height);
        Assert.AreEqual(tensor.MatrixProperties[0].Height, matrix1.Height);


        //Second Matrix
        Assert.AreEqual(tensor.MatrixProperties[1].Dimensions, matrix2.Dimensions);
        Assert.AreEqual(tensor.MatrixProperties[1].Values, matrix2.Values);
        Assert.AreEqual(tensor.MatrixProperties[1].Length, matrix2.Length);
        Assert.AreEqual(tensor.MatrixProperties[1].Width, matrix2.Height);
        Assert.AreEqual(tensor.MatrixProperties[1].Height, matrix2.Height);
    }

    /*
    [Test]
    public void IncrementTensorStacking ()
    {
        DNATensor tensor = DNATensor.Increment(Helper.DefaultDimension);
        DNAMatrix matrix = DNAMatrix.Increment(4, 4);

        DNATensor ResultTensor = tensor ^ matrix;


        //First Matrix
        






    }
    */

    public bool MatricesAreEqual (DNAMatrix matrix1, DNAMatrix matrix2)
    {
        //First Matrix
        /*
        Assert.AreEqual(matrix1.Dimensions, matrix2.Dimensions);
        Assert.AreEqual(matrix1.Values, matrix2.Values);
        Assert.AreEqual(matrix1.Length, matrix2.Length);
        Assert.AreEqual(matrix1.Width, matrix2.Height);
        Assert.AreEqual(matrix1.Height, matrix2.Height);
        */
        return true;
    }

}
