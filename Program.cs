using System.Collections.Generic;
internal class Program {

    //Given an integer array nums, 
    //return true if any value appears at least twice in 
    //the array, and return false if every element is distinct.



    private static void Main(string[] args) {
        
        bool ContainsDuplicate(int[] nums) 
        {

            //Algoritmo O(n)

            Dictionary<int,int> hash = new Dictionary<int,int>();

            for (int i = 0; i < nums.Length; i++) {

                if (hash.ContainsKey(nums[i])) {
                    hash[nums[i]]++;
                    if (hash[nums[i]] > 0) {
                        return true;
                    }
                }

                hash[nums[i]] = 0;

            }
            return false;



            //Algoritmo O(n^2)


            //int aux;
            //for (int i = 0; i < nums.Length; i++) {
            //    aux = nums[i];
            //    for (int j = i + 1; j < nums.Length; j++) {
            //        if (aux.Equals(nums[j])) {
            //            return true;
            //        } 
            //    }
            //}
            //return false;
        }

        int[] arr = { 1, 2, 1, 4,5,6,7};
        Console.WriteLine(ContainsDuplicate(arr));
    }
}