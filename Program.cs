namespace Challenge_Labs_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ;
            int[] myArray = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(myArray, target);
            PrintArray(myArray);
            Console.WriteLine($"Target value: {target}");
            Console.WriteLine($"Indices of the two numbers that add up to {target} are: {result[0]} and {result[1]}");


        }
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("Array elements:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complementNumber = target - nums[i];
                if (numDict.ContainsKey(complementNumber))
                {
                    return new int[] { numDict[complementNumber], i };
                }
                if (!numDict.ContainsKey(nums[i])) 
                {
                    numDict[nums[i]] = i; // Store the index of the number , key is array value, value is index
                }
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
