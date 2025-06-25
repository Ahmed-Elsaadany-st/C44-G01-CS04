namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //string YesOrNo;
            //do
            //{
            //    Console.WriteLine("Enter the three points in that sequence please:" +
            //                  "(x1,y1),(x2,y2),(x3,y3)");

            //    int[] xValues = new int[3];
            //    int[] yValues = new int[3];
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.Write($"Enter The Value of  x{i + 1}:");
            //        xValues[i] = int.Parse(Console.ReadLine()); //For reciveing the values of x
            //    }
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.Write($"Enter The vlaue of y{i + 1}:");
            //        yValues[i] = int.Parse(Console.ReadLine()); // for recieve the values of y
            //    }
            //    double slopeOfLineFormedByFirstTwoPoints = (yValues[0] - yValues[1]) / (xValues[0] - xValues[1]);
            //    double slopeOfLineFormedBySecondTwoPoints = (yValues[0] - yValues[2]) / (xValues[0] - xValues[2]);
            //    if (slopeOfLineFormedByFirstTwoPoints == slopeOfLineFormedBySecondTwoPoints)
            //        Console.WriteLine("The Three Points are in a Straight Line");
            //    else
            //        Console.WriteLine("The Three Points are not in a straight line");

            //    Console.WriteLine("Do you want to try another three points(Yes/No):");
            //    YesOrNo = Console.ReadLine();
            //    Console.Clear();

            //} while (YesOrNo.Equals("yes", StringComparison.OrdinalIgnoreCase)); 
            #endregion
            #region Question2
            //Console.WriteLine("Enter the days you spend doing the task please: ");
            //double.TryParse(Console.ReadLine(), out double hours);
            //string message;
            //if (hours > 2 && hours < 3)
            //    message = "High Efficient Employee";
            //else if (hours > 3 && hours < 4)
            //    message = "You need to increase your speed";
            //else if (hours > 4 && hours < 5)
            //    message = "You need to trainign to enhance your speed";

            //else message = "We are sorry to tell you that we do not your serviecs any more!";
            #endregion
            #region Question3
            ///*we can either use the built in function Sum()
            //or we can simpley define a var then use for to += the values of the array*/


            //int[]intArray= {1,2,3,4,5};
            //Console.WriteLine($"The Sum of the Array elements is :{intArray.Sum()}");
            //int sum = 0;
            //foreach( int item in intArray )
            //    sum+=item;
            //Console.WriteLine("-------------------");
            //Console.WriteLine($"The sum of the array elements is {sum}");

            #endregion
            #region Question4
            //This What I understood by Merge [1, 2] + [3, 4] → [1, 2, 3, 4]

            //int[] Array1 = { 1, 2, 3, 4, };
            //int[] Array2 = { 5, 6, 7, 8 };
            //int[]MergedArray= new int[Array1.Length+Array2.Length];
            //for (int i = 0; i < Array1.Length; i++)
            //{
            //    MergedArray[i] = Array1[i];           //Adding the elements of array1
            //}
            //for (int i = 0; i < Array2.Length; i++)
            //{
            //    MergedArray[Array1.Length + i] = Array2[i];       // Adding the element of Array2
            //}
            //foreach (var item in MergedArray)
            //{
            //    Console.Write(item+" ");
            //}

            #endregion
            #region Question5
            //Calculating the longest distance between two eqal cells(Applying this to an array of intgers)

            //int[] array = { 7, 1, 2, 3, 4, 5, 3, 1, 2, 7 };
            //LongestDistance(array, 2); //5
            //LongestDistance(array, 7); //8


            #endregion
            #region Question6
            //string wordsList = "this is a test";// List of space separeted words
            //string[] words = wordsList.Split(' ');
            //Array.Reverse(words); //Or we can defint another string and store the elements reversed :for(int i=words.Length-1;i>+0;i--) {newString+=words[i]+" "} then print this newString
            //foreach (string word in words)
            //{
            //    Console.Write(word + " ");
            //}


            #endregion
          
        }
        public static void LongestDistance(int[]array,int value)
        {
            Console.WriteLine((Array.LastIndexOf(array, value) - (Array.IndexOf(array, value) + 1)));
        }
    }
}
