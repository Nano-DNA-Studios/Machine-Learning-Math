using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using MachineLearningMath;

public class TensorTests
{
    static int[] DefaultDimension = new int[] { 2, 4, 4 };
    int[] integerValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
    double[] doubleValues = new double[] { 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1, 1.5, 2.5 };

    Tensor DoubleIncrement = Tensor.Increment(DefaultDimension)* 2;
    Tensor Increment = new Tensor(DefaultDimension);
    Tensor Empty = new Tensor(DefaultDimension);

}
