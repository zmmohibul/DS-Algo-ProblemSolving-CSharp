using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstUniqueNumber
{
    public class FirstUnique
    {
        public Dictionary<int, int> NumFrequencyOfQueue { get; set; } // NumFrequencyOfQueue = {2: 1, 3: 1, 5: 1}
        public Queue<int> NumsQueue { get; set; } // NumsQueue = [2, 3, 5]


        // FirstUnique firstUnique = new FirstUnique([2,3,5]);
        public FirstUnique(int[] nums) // nums = [2, 3, 5]
        {
            // Instantiate NumFrequencyOfQueue and NumsQueue
            NumsQueue = new Queue<int>(); // NumsQueue = []
            NumFrequencyOfQueue = new Dictionary<int, int>(); // NumFrequencyOfQueue = {}

            // Iterate Over the nums array and build NumFrequencyOfQueue dictionary and add to NumsQueue
            // nums = [2, 3, 5]
            //               n
            foreach (var num in nums)
            {
                NumsQueue.Enqueue(num);
                
                if (!NumFrequencyOfQueue.ContainsKey(num))
                {
                    NumFrequencyOfQueue[num] = 1;
                }
                else
                {
                    NumFrequencyOfQueue[num] += 1;
                }
            }
            // NumsQueue = [2, 3, 5]
            // NumFrequencyOfQueue = {2: 1, 3: 1, 5: 1}
        }
    
        // firstUnique.showFirstUnique();  | NumsQueue = [2, 3, 5]  | NumFrequencyOfQueue = {2: 1, 3: 1, 5: 1} | return 
        public int ShowFirstUnique() 
        {
            // Iterate over each num in NumsQueue and check count in NumFrequencyOfQueue, if count is 1 return the num
            // NumsQueue = [2, 3, 5]
            //              n
            foreach (var num in NumsQueue)
            {
                if (NumFrequencyOfQueue[num] == 1)
                {
                    return num;
                }
            }

            // Return -1 if no unique value found
            return -1;
            
        }
    
        public void Add(int value) 
        {
            // Add the value to NumsQueue, increment count of value in NumFrequencyOfQueue if exist else add to NumFrequencyOfQueue
            NumsQueue.Enqueue(value);
            if (!NumFrequencyOfQueue.ContainsKey(value))
            {
                NumFrequencyOfQueue[value] = 1;
            }
            else
            {
                NumFrequencyOfQueue[value] += 1;
            }
        }
    }
}