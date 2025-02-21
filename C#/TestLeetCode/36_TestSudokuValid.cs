using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;
using Sandbox;

namespace TestLeetCode;

public class TestSudokuValid
{
    static readonly IList<char[]> k_ValidBoard = new List<char[]>
    {
        new[] {'1', '2', '.', '.', '3', '.', '.', '.', '.'},
        new[] {'4', '.', '.', '5', '.', '.', '.', '.', '.'},
        new[] {'.', '9', '8', '.', '.', '.', '.', '.', '3'},
        new[] {'5', '.', '.', '.', '6', '.', '.', '.', '4'},
        new[] {'.', '.', '.', '8', '.', '3', '.', '.', '5'},
        new[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
        new[] {'.', '.', '.', '.', '.', '.', '2', '.', '.'},
        new[] {'.', '.', '.', '4', '1', '9', '.', '.', '8'},
        new[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
    };

    static readonly IList<char[]> k_DuplicateInRowBoard = new List<char[]>
    {
        new[] {'1', '2', '.', '.', '3', '.', '.', '.', '.'},
        new[] {'4', '.', '.', '5', '.', '.', '.', '.', '.'},
        new[] {'.', '9', '8', '.', '.', '.', '8', '.', '3'},
        new[] {'5', '.', '.', '.', '6', '.', '.', '.', '4'},
        new[] {'.', '.', '.', '8', '.', '3', '.', '.', '5'},
        new[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
        new[] {'.', '.', '.', '.', '.', '.', '2', '.', '.'},
        new[] {'.', '.', '.', '4', '1', '9', '.', '.', '8'},
        new[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
    };

    static readonly IList<char[]> k_DuplicateInColumnBoard = new List<char[]>
    {
        new[] {'1', '2', '.', '.', '3', '.', '.', '.', '.'},
        new[] {'4', '.', '.', '5', '.', '.', '.', '.', '.'},
        new[] {'.', '9', '8', '.', '.', '.', '.', '.', '3'},
        new[] {'5', '.', '.', '.', '6', '.', '.', '.', '4'},
        new[] {'.', '9', '.', '8', '.', '3', '.', '.', '5'},
        new[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
        new[] {'.', '.', '.', '.', '.', '.', '2', '.', '.'},
        new[] {'.', '.', '.', '4', '1', '9', '.', '.', '8'},
        new[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
    };

    static readonly IList<char[]> k_DuplicateInBox = new List<char[]>
    {
        new[] {'1', '2', '.', '.', '3', '.', '.', '.', '.'},
        new[] {'4', '1', '.', '5', '.', '.', '.', '.', '.'},
        new[] {'.', '9', '8', '.', '.', '.', '.', '.', '3'},
        new[] {'5', '.', '.', '.', '6', '.', '.', '.', '4'},
        new[] {'.', '.', '.', '8', '.', '3', '.', '6', '5'},
        new[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
        new[] {'.', '.', '.', '.', '.', '.', '2', '.', '.'},
        new[] {'.', '.', '.', '4', '1', '9', '.', '.', '8'},
        new[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
    };
    
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(k_ValidBoard).Returns(true).SetName("Base case two values");
        yield return new TestCaseData(k_DuplicateInRowBoard).Returns(false).SetName("Base case three values");
        yield return new TestCaseData(k_DuplicateInColumnBoard).Returns(false).SetName("Odd number of contiguous 0/1");
        yield return new TestCaseData(k_DuplicateInBox).Returns(false).SetName("Even number of contiguous 0/1");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(List<char[]> board)
    {
        var testObject = new ValidSudoku();
        var boardArray = board.ToArray();
        return MeasureExecutionTime.Measure(() => testObject.Solution(boardArray));
    }
}