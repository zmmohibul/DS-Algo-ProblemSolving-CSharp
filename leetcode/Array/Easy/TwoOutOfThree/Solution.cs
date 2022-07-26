using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoOutOfThree
{
    public class Solution
    {
        public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) 
        {
            var nums1Hs = new HashSet<int>();
            foreach (var num in nums1)
            {
                nums1Hs.Add(num);
            }
            
            var nums2Hs = new HashSet<int>();
            foreach (var num in nums2)
            {
                nums2Hs.Add(num);
            }
            
            var nums3Hs = new HashSet<int>();
            foreach(var num in nums3)
            {
                nums3Hs.Add(num);
            }
            
            var result = new HashSet<int>();
            foreach (var num in nums1Hs)
            {
                var num1Contain = nums1Hs.Contains(num);
                var num2Contain = nums2Hs.Contains(num);
                var num3Contain = nums3Hs.Contains(num);
                
                if ((num1Contain && num2Contain) || (num2Contain && num3Contain) || (num1Contain && num3Contain))
                {
                    result.Add(num);
                }
            }
            
            foreach (var num in nums2Hs)
            {
                var num1Contain = nums1Hs.Contains(num);
                var num2Contain = nums2Hs.Contains(num);
                var num3Contain = nums3Hs.Contains(num);
                
                if ((num1Contain && num2Contain) || (num2Contain && num3Contain) || (num1Contain && num3Contain))
                {
                    result.Add(num);
                }
            }
            
            foreach (var num in nums3Hs)
            {
                var num1Contain = nums1Hs.Contains(num);
                var num2Contain = nums2Hs.Contains(num);
                var num3Contain = nums3Hs.Contains(num);
                
                if ((num1Contain && num2Contain) || (num2Contain && num3Contain) || (num1Contain && num3Contain))
                {
                    result.Add(num);
                }
            }
            
            var resultList = new List<int>();
            foreach (var num in result)
            {
                resultList.Add(num);
            }
            
            return resultList;
            
        }
    }
}