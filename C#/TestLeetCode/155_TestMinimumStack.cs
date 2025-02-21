using System.Collections.Generic;
using LeetCode.Neetcode;
using NUnit.Framework;

namespace TestLeetCode;

public class TestMinimumStack
{
    [Test]
    public void TestBaseCase()
    {
        string[] commands = ["MinStack", "push", "push", "push", "top", "pop", "getMin", "pop", "getMin", "pop", "push", "top", "getMin", "push", "top", "getMin", "pop", "getMin"];
        List<int>[] commandsValues = [[], [2147483646], [2147483646], [2147483647], [], [], [], [], [], [], [2147483647], [], [], [-2147483648], [], [], [], []];
        int?[] expectedValues = [null,null,null,null,2147483647,null,2147483646,null,2147483646,null,null,2147483647,2147483647,null,-2147483648,-2147483648,null,2147483647];

        Check(commands, commandsValues, expectedValues);
    }

    static void Check(string[] commands, List<int>[] commandsValues, int?[] expectedValues)
    {
        var testObj = new MinStack();

        for(var i = 0; i < commands.Length; i++)
        {
            var command = commands[i];

            switch (command)
            {
                case "MinStack": 
                    break;
                case "push": 
                    testObj.Push(commandsValues[i][0]);
                    break;
                case "top":
                    Assert.That(testObj.Top(), Is.EqualTo(expectedValues[i]!));
                    break;
                case "pop":
                    testObj.Pop();
                    break;
                case "getMin":
                    Assert.That(testObj.GetMin(), Is.EqualTo(expectedValues[i]!));
                    break;                
            }
        }
    }
}
