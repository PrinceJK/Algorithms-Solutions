namespace LeetCode
{
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            var result = new int[nums.Length];
            //result[0] = 
            int index = 0;
            while (index != nums.Length) 
            {
                if (index == 0)
                {
                    result[index] = nums[index];
                    index++;
                }

                result[index] = result[index - 1] + nums[index];
                index++;
            }



            return result;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var temp = new Dictionary<int, int>();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (temp.ContainsKey(complement))
                {
                    result[0] = temp[complement];
                    result[1] = i;
                    return result;
                }
                temp[nums[i]] = i;
            }
            return result;

        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null && carry == 0)
            {
                return null;
            }

            var total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
            carry = total / 10;

            return new ListNode(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
        }

        public int LengthOfLongestSubstring(string s)
        {
            var result = new HashSet<char>();
            int previous = 0, next = 0, count = 0;
            while (next < s.Length)
            {
                if (!result.Contains(s[next]))
                {
                    result.Add(s[next]);
                    next++;
                    count = Math.Max(count, result.Count);
                }
                else
                {
                    result.Remove(s[previous]);
                    previous++;
                }
            }
            return count;
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums3 = new int[nums1.Length + nums2.Length];
            //Array.Copy(nums1, nums3, nums1.Length);
            Array.Copy(nums1, 0, nums2, nums1.Length, nums2.Length);
            Array.Sort(nums3);
            var arrayLength = nums3.Length;

            double median;

            var isOdd = arrayLength % 2 != 0;
            if (isOdd)
            {
                median = nums3[(arrayLength + 1) / 2 - 1];
            }
            else
            {
                median = (nums3[arrayLength / 2 - 1] + nums3[arrayLength / 2]) / 2.0d;
            }
            return median;

        }

        public string LongestPalindrome(string s)
        {
            var result = string.Empty;


            return result;
        }

        public int Reverse(int x)
        {
            int reversed = 0;
            while (Convert.ToBoolean(x))
            {
                reversed = reversed * 10 + (x % 10);
                x = x / 10;
            }
            return reversed;
        }
    }

    public class ListNode
    {
          public int val;
          public ListNode next;
          public ListNode(int val = 0, ListNode next = null)
          {
            this.val = val;
            this.next = next;
          }
    }
}
