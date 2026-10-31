public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    ///         // TODO Problem 1 Start
    // Remember: Using comments in your program, write down your process for solving this problem
    // step by step before you write the code. The plan should be clear enough that it could
    // be implemented by another person.
    public static double[] MultiplesOf(double number, int length)
    {

        // Create an array of doubles with the specified length
        double[] multiples = new double[length];
        // Loop through the array and calculate the multiples of the number
        for (int i = 0; i < length; i++)
        {
            // Calculate the multiple by multiplying the number with (i + 1) and assign it to the array
            multiples[i] = number * (i + 1);
        }
        // Return the array of multiples
        return multiples;
    } // Big O notation: O(n) Because the function iterates through the array once, where n is the length of the array.

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    ///         // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    public static void RotateListRight(List<int> data, int amount)
    {
        // Calculate the effective rotation amount by taking the modulus with the count of the list
        int effectiveAmount = amount % data.Count;
        // Create a new list to hold the rotated values
        List<int> rotatedList = new List<int>(data.Count);
        // Add the last 'effectiveAmount' elements to the new list first
        for (int i = data.Count - effectiveAmount; i < data.Count; i++)
        {
            rotatedList.Add(data[i]);
        }
        // Add the remaining elements from the start of the original list to the new list
        for (int i = 0; i < data.Count - effectiveAmount; i++)
        {
            rotatedList.Add(data[i]);
        }
        // Clear the original list and add all elements from the rotated list back to it
        data.Clear();
        data.AddRange(rotatedList);
    }
}
