using System;

namespace My_Average_int_the_Class
{

    /* Given an array of class scores, add the scores find the average, 
     * and compare to your score. Return True if your score is higher and 
     * False if your score is lower than the class average. */

    class ClassAverage
    {
        static void Main(string[] args)
        {
            int[] ClassPoints = { 50, 60, 90, 40, 100, 70, 75, 35, 96, 86, 85, 74, 87, 76, 77 };    // Test input data
            int YourPoints = 97;                                                                    // Example Your Point Data
            
            BetterThanAverage(ClassPoints, YourPoints);                                             // Method call
        }

        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)                     // Method to test input
        {
            int sum = 0;
            int average;
            for (int i = 0; i < ClassPoints.Length; i++)                                            // Itirates through array
            {
                sum += ClassPoints[i];                                                              // Adds each value in array to sum
            }
            average = sum / ClassPoints.Length;                                                     // Computes average by taking sum over number of testscores
            if (average < YourPoints)                                                               
            {
                return true;                                                                        // If the average score is less than my score it returns true 
            }
             return false;                                                                          // If the average score is greater than my score it returns false 

        }

        /* Should be able to do something like: ClassPoints.Average() > YourPoints ? true : false ... 
         * but system would not accept syntax saying no definition for Average() or .SUM simplicity commands. */

    }
}
