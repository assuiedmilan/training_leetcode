namespace LeetCode.Others;

/* https://leetcode.com/problems/flipping-an-image/description/ */
public class FlippingImage
{
    public int[][] Solution(int[][] image)
    {
        for(var i = 0; i < image.Length; i++)
        {
            for(var j = 0; j < (image[i].Length+1) /2; j++) 
            {
                if(j == (image[i].Length+1) /2)
                {
                    image[i][j] ^= 1;
                }
                else
                {
                    var temp = image[i][image[j].Length - 1 - j] ^ 1;
                    image[i][image[j].Length - 1 - j] = image[i][j] ^ 1;
                    image[i][j] = temp;
                }
            }
        }
        return image;
    }
}