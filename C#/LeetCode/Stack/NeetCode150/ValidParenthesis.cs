namespace LeetCode.Stack.NeetCode150;

/*
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
 *
 * An input string is valid if:
 *
 *     Open brackets must be closed by the same type of brackets.
 *     Open brackets must be closed in the correct order.
 *     Every close bracket has a corresponding open bracket of the same type.
 *
 *
 *
 * Example 1:
 *
 * Input: s = "()"
 *
 * Output: true
 *
 * Example 2:
 *
 * Input: s = "()[]{}"
 *
 * Output: true
 *
 * Example 3:
 *
 * Input: s = "(]"
 *
 * Output: false
 *
 * Example 4:
 *
 * Input: s = "([])"
 *
 * Output: true
 *
 *
 *
 * Constraints:
 *
 *     1 <= s.length <= 104
 *     s consists of parentheses only '()[]{}'.
 *
 *
 */
public class ValidParenthesis
{
    public bool Solution(string s) {

        if(s.Length < 2) return false;

        var orderedMemory = new char[s.Length];
        var memoryIndex = 0;
        
        foreach(var c in s) {
            if (c is '(' or '{' or '['){
                orderedMemory[memoryIndex] = c;
                memoryIndex++;
            }
            else {
                if(memoryIndex == 0) return false;
                memoryIndex--;
                
                var previous = orderedMemory[memoryIndex];

                var expected = c switch
                {
                    ')' => '(',
                    '}' => '{',
                    _ => '['
                };

                if (previous!=expected) return false;
                
            }
        }

        return memoryIndex == 0;
    }    
}
