internal class Program {
    private static void Main(string[] args) {
        
        bool ContainsDuplicate(int[] nums) 
        {

            int aux;
            for (int i = 0; i < nums.Length; i++) {
                aux = nums[i];
                for (int j = i + 1; j < nums.Length; j++) {
                    if (aux.Equals(nums[j])) {
                        return true;
                    } 
                }
            }
            return false;
        }

        int[] arr = { 1, 2, 3, 4,5,6,7};
        Console.WriteLine(ContainsDuplicate(arr));
    }
}