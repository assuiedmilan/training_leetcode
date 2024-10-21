using System.Collections.Generic;
using LeetCode.Easy;
using NUnit.Framework;

namespace TestLeetCode.Easy
{
    public class TestTwoSums
    {
        public static IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData((int[]) [15, 11, 7, 2], 9, (int[]) [2, 3]).SetName("SortedDecreasing");
            yield return new TestCaseData((int[]) [2, 7, 11, 15], 9, (int[]) [0, 1]).SetName("SortedIncreasing");
            yield return new TestCaseData((int[]) [3, 2, 4], 6, (int[]) [1, 2]).SetName("RandomOrderFirstIndexIsOnTheLeft");
            yield return new TestCaseData((int[]) [3, 4, 2], 6, (int[]) [1, 2]).SetName("RandomOrderFirstIndexIsOnTheRight");
            yield return new TestCaseData((int[]) [3, 3], 6, (int[]) [0, 1]).SetName("SameValues");
            yield return new TestCaseData((int[]) [], 0, (int[]) []).SetName("EmptyArray");
            yield return new TestCaseData((int[]) [1], 1, (int[]) []).SetName("SingleElementArray");
            yield return new TestCaseData((int[]) [int.MaxValue, int.MinValue], int.MaxValue + int.MinValue, (int[]) [0, 1]).SetName("MaxMinValues");
            yield return new TestCaseData((int[]) [-1, -2, -3, -4, -5], -8, (int[]) [2, 4]).SetName("NegativeNumbers");
        }
        
        [Test, TestCaseSource(nameof(TestCases))]
        public void TestBruteForce(int[] array, int target, int[] expected)
        {
            Assert.That(TwoSum.BruteForce(array, target), Is.EqualTo(expected));
        }
        
        [Test, TestCaseSource(nameof(TestCases))]
        public void TestUsingHashTableAndComplement(int[] array, int target, int[] expected)
        {
            Assert.That(TwoSum.UsingHashTableAndComplement(array, target), Is.EqualTo(expected));
        }
    }
}   