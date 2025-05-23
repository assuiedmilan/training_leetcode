﻿using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

/* Copilot tests prompt:
Write unit tests for the current file based on its filename, when you do:
 
 - Use file-scoped namespace 
 
 - Use IEnumerable<TestCaseData> to generate the test cases When an argument is an array,
 
 - Use cast collection expression, such as (string[]) ["aa", "bb"], or (IList<int[]>) [[-4, 0, 1, 2], [-1, -1, 0, 1]]
 
 - Have a single TestSolution method</TestCaseData>
 
 - Use TestTwoSums as a reference
 */
public class TestTwoSums
{

    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData((int[]) [15, 11, 7, 2], 9).Returns((int[]) [2, 3]).SetName("SortedDecreasing");
        yield return new TestCaseData((int[]) [2, 7, 11, 15], 9).Returns((int[]) [0, 1]).SetName("SortedIncreasing");
        yield return new TestCaseData((int[]) [3, 2, 4], 6).Returns((int[]) [1, 2]).SetName("RandomOrderFirstIndexIsOnTheLeft");
        yield return new TestCaseData((int[]) [3, 4, 2], 6).Returns((int[]) [1, 2]).SetName("RandomOrderFirstIndexIsOnTheRight");
        yield return new TestCaseData((int[]) [3, 3], 6).Returns((int[]) [0, 1]).SetName("SameValues");
        yield return new TestCaseData((int[]) [], 0).Returns((int[]) []).SetName("EmptyArray");
        yield return new TestCaseData((int[]) [1], 1).Returns((int[]) []).SetName("SingleElementArray");
        yield return new TestCaseData((int[]) [int.MaxValue, int.MinValue], int.MaxValue + int.MinValue).Returns((int[]) [0, 1]).SetName("MaxMinValues");
        yield return new TestCaseData((int[]) [-1, -2, -3, -4, -5], -8).Returns((int[]) [2, 4]).SetName("NegativeNumbers");
    }
        
    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestSolution(int[] array, int target)
    {
        var testObject = new TwoSum();
        return MeasureExecutionTime.Measure(() => testObject.Solution(array, target));
    }
}