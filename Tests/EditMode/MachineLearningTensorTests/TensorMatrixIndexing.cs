using MachineLearningMath;
using NUnit.Framework;
using MachineLearningTestHelper;

namespace MachineLearningTensorTests
{
    /// <summary>
    /// Covers Matrix Properties
    /// </summary>
    public class TensorMatrixIndexing
    {
        TestHelper Helper = new TestHelper();


        [Test]
        public void AccessEmptyMatrix()
        {
            Tensor tensor = new Tensor(Helper.DefaultDimension);
            Matrix emptyMatrix = Helper.EmptyMatrix;


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
            Tensor tensor = Tensor.Increment(Helper.DefaultDimension);
            Matrix incrementMatrix = Matrix.Increment(4, 4);

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
}
