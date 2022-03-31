
var nums1 = new int[] {5, 8, 13, 15, 0, 0, 0, 0};
var nums2 = new int[] {6, 7, 12, 14};

Merge(nums1, nums1.Length, nums2, nums2.Length);


// nums1 = new int[] {1,2,3,0,0,0};
// nums2 = new int[] {2,5,6};

// Merge(nums1, 3, nums2, nums2.Length);


void Merge(int[] nums1, int m, int[] nums2, int n) {

    int[] result = new int[nums1.Length];
    
    int i = 0;
    int j = 0;

    int k = 0;
    while (k < nums1.Length) {
        if (j < n && i < m) {
            if (nums1[i] < nums2[j]) {
                result[k] = nums1[i];
                i += 1;
                k += 1;
            } else {
                result[k] = nums2[j];
                j += 1;
                k += 1;
            }
        } else if (i < m) {
            result[k] = nums1[i];
            i += 1;
            k += 1;
        } else if (j < n) {
            result[k] = nums2[j];
            j += 1;
            k += 1;
        }
    }

    i = 0;
    foreach (var item in result) {
        // System.Console.Write(item + ", ");
        nums1[i] = item;
        i += 1;
    }

    // System.Console.WriteLine();

    // foreach (var item in nums1) {
    //     System.Console.Write(item + ", ");
    // }

    // System.Console.WriteLine();

        
}