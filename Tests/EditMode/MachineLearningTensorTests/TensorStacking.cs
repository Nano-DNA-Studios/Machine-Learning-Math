using MachineLearningMath;
using NUnit.Framework;

namespace MachineLearningTensorTests
{
    public class TensorStacking
    {
        TestHelper Helper = new TestHelper();

        [Test]
        public void EmptyMatrixStacking()
        {
            Matrix matrix1 = new Matrix(4, 4);
            Matrix matrix2 = new Matrix(4, 4);

            Tensor tensor = matrix1 ^ matrix2;

            Assert.IsTrue(MatricesAreEqual(tensor.MatrixProperties[0], matrix1));
            Assert.IsTrue(MatricesAreEqual(tensor.MatrixProperties[1], matrix2));
        }

        [Test]
        public void IncrementMatrixStacking()
        {
            Matrix matrix1 = Matrix.Increment(4, 4);
            Matrix matrix2 = Matrix.Increment(4, 4);

            Tensor tensor = matrix1 ^ matrix2;

            Assert.IsTrue(MatricesAreEqual(tensor.MatrixProperties[0], matrix1));
            Assert.IsTrue(MatricesAreEqual(tensor.MatrixProperties[1], matrix2));
        }

        [Test]
        public void IncrementTensorStacking()
        {
            Tensor tensor = Tensor.Increment(Helper.DefaultDimension);
            Matrix matrix = Matrix.Increment(4, 4);

            Tensor ResultTensor = tensor ^ matrix;

            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[0], tensor.MatrixProperties[0]));
            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[1], tensor.MatrixProperties[1]));
            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[2], matrix));
        }


        [Test]
        public void EmptyTensorStacking()
        {
            Tensor tensor = new Tensor(Helper.DefaultDimension);
            Matrix matrix = new Matrix(4, 4);

            Tensor ResultTensor = tensor ^ matrix;

            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[0], tensor.MatrixProperties[0]));
            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[1], tensor.MatrixProperties[1]));
            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[2], matrix));
        }

        [Test]
        public void EmptyReceivedMatrices()
        {
            Tensor tensor = new Tensor(Helper.DefaultDimension);
            Matrix matrix = new Matrix(4, 4);

            Tensor ResultTensor = tensor ^ matrix;

            Matrix[] matrices = ResultTensor.MatrixProperties.Matrices;


            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[0], matrices[0]));
            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[1], matrices[1]));
            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[2], matrices[2]));
        }

        [Test]
        public void IncrementReceivedMatrices()
        {
            Tensor tensor = Tensor.Increment(Helper.DefaultDimension);
            Matrix matrix = Matrix.Increment(4, 4);

            Tensor ResultTensor = tensor ^ matrix;

            Matrix[] matrices = ResultTensor.MatrixProperties.Matrices;

            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[0], matrices[0]));
            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[1], matrices[1]));
            Assert.IsTrue(MatricesAreEqual(ResultTensor.MatrixProperties[2], matrices[2]));
        }

        public bool MatricesAreEqual(Matrix matrix1, Matrix matrix2)
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
}
