using System.Runtime.ExceptionServices;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //Create an array for multiples to be saved
        double[] numberArray = new double [length];

        //Create a for loop to go through every number up to the length
        for (int i = 1; i <= length; ++i)
        {
            //Multiply both numbers
            double newNumber = number * i;

            //Append the multiple of the given number to the array
            numberArray[i - 1] = newNumber;
        }
        //Return the Array
        return numberArray; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        //Create a list of the numbers that must go first
        List<int> numbersToFirst = data.GetRange(data.Count - amount, amount);

        //Create a list of the numbers that must go last
        List<int> numbersToLast = data.GetRange(0, data.Count -amount);
        
        for (int index = 0; index < numbersToFirst.Count; ++index)
        {
            data[index] = numbersToFirst[index];
        }
        for (int secondPartIndex = 0; secondPartIndex < numbersToLast.Count; ++secondPartIndex)
        {
            data[secondPartIndex + numbersToFirst.Count] = numbersToLast[secondPartIndex];
        }
    }
}
