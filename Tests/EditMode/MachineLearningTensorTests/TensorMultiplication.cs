using MachineLearningMath;
using NUnit.Framework;
using MachineLearningTestHelper;

namespace MachineLearningTensorTests
{
    /// <summary>
    /// Covers all Multiplication Based Operations
    /// </summary>
    public class TensorMultiplication
    {
        static int[] DefaultDimension = new int[] { 2, 4, 4 };
        int[] integerValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        double[] doubleValues = new double[] { 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1, 1.5, 2.5 };

        Tensor DoubleIncrement = Tensor.Increment(DefaultDimension) * 2;
        Tensor Increment = new Tensor(DefaultDimension);
        Tensor Empty = new Tensor(DefaultDimension);

        TestHelper Helper = new TestHelper();

        /// <summary>
        /// Covers Integer Multiplication
        /// </summary>
        [Test]
        public void ScalarIntMultiplication()
        {
            foreach (int scalar in integerValues)
            {
                Tensor Tensor = Tensor.Increment(DefaultDimension);

                Tensor ResultTensor = Tensor * scalar;

                double[] values = Helper.ScalarMult(Helper.GetIncrementValues(DefaultDimension), scalar);

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
                Tensor Tensor = new Tensor(DefaultDimension);

                Tensor ResultTensor = Tensor * scalar;

                double[] values = Helper.ScalarMult(Helper.GetEmptyValues(DefaultDimension), scalar);

                Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
                Assert.AreEqual(ResultTensor.Values, values);
            }
        }

        /// <summary>
        /// Covers Integer Multiplication
        /// </summary>
        [Test]
        public void ScalarDoubleMultiplication()
        {
            foreach (double scalar in doubleValues)
            {
                Tensor Tensor = Tensor.Increment(DefaultDimension);

                Tensor ResultTensor = Tensor * scalar;

                double[] values = Helper.ScalarMult(Helper.GetIncrementValues(DefaultDimension), scalar);

                Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
                Assert.AreEqual(ResultTensor.Values, values);
            }
        }

        /// <summary>
        /// Covers Integer Multiplication
        /// </summary>
        [Test]
        public void ScalarDoubleMultiplicationEmpty()
        {
            foreach (double scalar in doubleValues)
            {
                Tensor Tensor = new Tensor(DefaultDimension);

                Tensor ResultTensor = Tensor * scalar;

                double[] values = Helper.ScalarMult(Helper.GetEmptyValues(DefaultDimension), scalar);

                Assert.AreEqual(ResultTensor.Dimensions, Tensor.Dimensions);
                Assert.AreEqual(ResultTensor.Values, values);
            }
        }
    }
}
