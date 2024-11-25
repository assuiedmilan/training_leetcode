namespace LeetCode.TwoPointers.Extras;

public class MergeSortedArray
{
    public void Solution(int[] nums1, int m, int[] nums2, int n) {
        if (n == 0) return;
        
        var mPointer = m-1;
        var nPointer = n-1;
        var mHasValues = mPointer >= 0;
        var nHasValues = nPointer >= 0;
        
        var currentReplacementIndex = m+n-1;
        
        while(mHasValues || nHasValues)
        {
            var mValue = mHasValues ? nums1[mPointer] : -1;
            var nValue = nHasValues ? nums2[nPointer] : -1;
            
            if((mValue >= nValue && mHasValues) || !nHasValues)
            {
                nums1[currentReplacementIndex--] = mValue;
                mPointer--;
            }
            
            if((nValue >= mValue && nHasValues) || !mHasValues)
            {
                nums1[currentReplacementIndex--] = nValue;
                nPointer--;
            }
            
            mHasValues = mPointer >= 0;
            nHasValues = nPointer >= 0;
        }
    }    
}