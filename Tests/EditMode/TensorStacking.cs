using System.Collections;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using DNAMatrices;
using NUnit.Framework;
using NUnit.Framework.Constraints;
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

        Assert.IsTrue(MatricesAreEqual(tensor.MatrixProperties[0], matrix1));
        Assert.IsTrue(MatricesAreEqual(tensor.MatrixProperties[1], matrix2));
    }

    [Test]
    public void IncrementMatrixStacking()
    {
        DNAMatrix matrix1 = DNAMatrix.Increment(4, 4);
        DNAMatrix matrix2 = DNAMatrix.Increment(4, 4);

        DNATensor tensor = matrix1 ^ matrix2;

        Assert.IsTrue(MatricesAreEqual(tensor.MatrixProperties[0], matrix1));
        Assert.IsTrue(MatricesAreEqual(tensor.MatrixProperties[1], matrix2));
    }

    [Test]
    public void IncrementTensorStacking()
    {
        DNATensor tensor = DNATensor.Increment(Helper.DefaultDimension);
        DNAMatrix matrix = DNAMatrix.Increment(4, 4);

        DNATensor ResultTensor = tensor ^ matrix;

        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[0], tensor.MatrixProperties[0]));
        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[1], tensor.MatrixProperties[1]));
        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[2], matrix));
    }


    [Test]
    public void EmptyTensorStacking ()
    {
        DNATensor tensor = new DNATensor(Helper.DefaultDimension);
        DNAMatrix matrix = new DNAMatrix(4, 4);

        DNATensor ResultTensor = tensor ^ matrix;

        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[0], tensor.MatrixProperties[0]));
        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[1], tensor.MatrixProperties[1]));
        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[2], matrix));
    }

    [Test]
    public void EmptyReceivedMatrices ()
    {
        DNATensor tensor = new DNATensor(Helper.DefaultDimension);
        DNAMatrix matrix = new DNAMatrix(4, 4);

        DNATensor ResultTensor = tensor ^ matrix;

        DNAMatrix[] matrices = ResultTensor.MatrixProperties.Matrices;


        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[0], matrices[0]));
        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[1], matrices[1]));
        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[2], matrices[2]));
    }

    [Test]
    public void IncrementReceivedMatrices()
    {
        DNATensor tensor = DNATensor.Increment(Helper.DefaultDimension);
        DNAMatrix matrix = DNAMatrix.Increment(4, 4);
        
        DNATensor ResultTensor = tensor ^ matrix;

        DNAMatrix[] matrices = ResultTensor.MatrixProperties.Matrices;

        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[0], matrices[0]));
        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[1], matrices[1]));
        Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[2], matrices[2]));
    }

    public bool MatricesAreEqual (DNAMatrix matrix1, DNAMatrix matrix2)
    {
        //First Matrix
        Assert.AreEqual(matrix1.Dimensions, matrix2.Dimensions);
        Assert.AreEqual(matrix1.Values, matrix2.Values);
        Assert.AreEqual(matrix1.Length, matrix2.Length);
        Assert.AreEqual(matrix1.Width, matrix2.Height);
        Assert.AreEqual(matrix1.Height, matrix2.Height);
        
        return true;
    }

}
