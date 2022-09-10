using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotProductOfTwoSparseVector
{
    public class SparseVector
    {
        public List<int> elements;
    
        public SparseVector(int[] nums) {
            this.elements = new List<int>();
            foreach (var num in nums)
            {
                this.elements.Add(num);
            }
        }
        
        // Return the dotProduct of two sparse vectors
        public int DotProduct(SparseVector vec) {
            var result = 0;
            for (int i = 0; i < this.elements.Count; i++) {
                result += (this.elements[i] * vec.elements[i]);
            }
            return result;
        }
    }
}