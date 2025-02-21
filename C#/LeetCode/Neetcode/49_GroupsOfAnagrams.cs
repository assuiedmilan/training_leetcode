using System.Collections.Generic;

namespace LeetCode.Neetcode;

/* https://leetcode.com/problems/group-anagrams/description/ */
public class GroupsOfAnagrams
{
    public IList<IList<string>> Solution(string[] strs)
    {
        //Create a list that will contain the results and a hashmap that will keep all the sub-lists of anagrams
        //For each word reduce the word to a unique key by sorting the characters, all anagrams will be sorted the same.
        //This constitutes a hash function.
        //Either the key is already in the hashmap, then add the word to the list, or create a new list and add it to the results
        //
        //Edit: Using an array to count the letters as a key reduce the complexity from O(n.m.log(m)) to O(n.m)
        //This will be slower on small inputs but faster on large inputs

        switch (strs.Length)
        {
            case 0:
                return new List<IList<string>> { new List<string> { string.Empty } };
            case 1:
                return new List<IList<string>> { new List<string> { strs[0] } };
        }
        

        var anagramsLists = new Dictionary<string, IList<string>>();
        var results = new List<IList<string>>();

        foreach (var word in strs)
        {
            var charCount = new char[26];

            foreach (var c in word)
            {
                charCount[c%26]++;
            }
            
            var key = new string(charCount);
            
            if (anagramsLists.ContainsKey(key))
            {
                anagramsLists[key].Add(word);
                continue;
            }
            
            var subList = new List<string> { word };
            results.Add(subList);
            anagramsLists.Add(key, subList);
        }

        return results;
    }
}