using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestSudokuValid
{
    static readonly IList<char[]> k_FullBoard = new List<char[]>
    {
             // 0    1    2    3    4    5    6    7    8
        new[] {'1', '2', '3', '4', '5', '6', '7', '8', '9'}, //0
        new[] {'4', '5', '6', '7', '8', '9', '1', '2', '3'}, //1
        new[] {'7', '8', '9', '1', '2', '3', '4', '5', '6'}, //2
        new[] {'3', '1', '2', '6', '4', '5', '9', '7', '8'}, //3
        new[] {'6', '4', '5', '9', '7', '8', '3', '1', '2'}, //4
        new[] {'9', '7', '8', '3', '1', '2', '6', '4', '5'}, //5
        new[] {'2', '3', '1', '5', '6', '4', '8', '9', '7'}, //6
        new[] {'5', '6', '4', '8', '9', '7', '2', '3', '1'}, //7
        new[] {'8', '9', '7', '2', '3', '1', '5', '6', '4'}  //8
    };
    
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
        new[] {'2', '2', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '2', '.', '.', '2', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'}
    };

    static readonly IList<char[]> k_DuplicateInColumnBoard = new List<char[]>
    {
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '4', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '4', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'}
    };

    static readonly IList<char[]> k_DuplicateInBox = new List<char[]>
    {
        new[] {'1', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '2', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '1', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '1', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'},
        new[] {'.', '.', '.', '.', '.', '.', '.', '.', '.'}
    };
    
    static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(k_FullBoard).Returns(true).SetName("Full board");
        yield return new TestCaseData(k_ValidBoard).Returns(true).SetName("Base case");
        yield return new TestCaseData(k_DuplicateInRowBoard).Returns(false).SetName("Duplicate value in row");
        yield return new TestCaseData(k_DuplicateInColumnBoard).Returns(false).SetName("Duplicate value in column");
        yield return new TestCaseData(k_DuplicateInBox).Returns(false).SetName("Duplicate value in a box");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public bool TestSolution(List<char[]> board)
    {
        var testObject = new ValidSudoku();
        var boardArray = board.ToArray();
        return testObject.Solution(boardArray);
    }
}