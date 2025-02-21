namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/valid-parentheses/ */
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
