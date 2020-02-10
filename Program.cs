using System;

namespace DIS_Assignment_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Problem1
            int n = 5;
            Console.WriteLine("This is Problem 1");
            Console.WriteLine(" ");
            PrintPattern(n);
            Console.WriteLine(" ");

            //Problem 2
            Console.WriteLine("This is Problem 2");
            Console.WriteLine(" ");
            int n2 = 6;
            PrintSeries(n2);
            Console.WriteLine(" ");


            Console.WriteLine("This is Problem 3");
            Console.WriteLine(" ");
            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            Console.WriteLine("This is Problem 4");
            Console.WriteLine(" ");
            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            Console.WriteLine("This is Problem 5");
            Console.WriteLine(" ");
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            


        }

        private static void printPatternRowRecur(int n)
        {

            if (n < 1)
                return;


            Console.Write(n + " ");
            printPatternRowRecur(n - 1);
        }
        private static void PrintPattern(int n)
        //Using recursion function to generate the reverse right triangle.
        //Time taken: 60 minutes, Learning: How to use recursion functions.
        {
            try
            {

                if (n < 1)
                    return;

                printPatternRowRecur(n);

                Console.WriteLine();

              
                PrintPattern(n-1);
            
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }




        private static void PrintSeries(int a)
        {
            try
            {
                //considering the i as 1 and adding the consecutive numbers
                //Time taken: 95 minutes. Learning: How to use ++ function.
                    int i, add = 0;
                    
                    for (i = 1; i <= a; i++)
                    {
                        add += i;
                        Console.Write(add + " ");
                    }

                Console.WriteLine();


            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static string UsfTime(string input)
        {
            try
            {

                //Converting the seconds on earth to the seconds on Planet USF
                //Time taken:200 minutes. Learning: How to work on time and how to handle time related problems.
                DateTime Timeonearth = Convert.ToDateTime(input);
                Console.WriteLine("You have enetered the time :" + Timeonearth.ToLongTimeString());
                int Inputhour = Timeonearth.Hour;
                if (Inputhour.ToString("tt") == "AM" || Inputhour.ToString("tt") == "Am" || Inputhour.ToString("tt") == "am")
                {
                    Inputhour = Inputhour + 0;
                }
                else if (Inputhour.ToString("tt") == "PM" || Inputhour.ToString("tt") == "Pm" || Inputhour.ToString("tt") == "pm")
                {
                    Inputhour = Inputhour + 12;
                }
                int Secofhr = Inputhour * 60 * 60;
                int Inputmin = Timeonearth.Minute;
                int Secofmin = Inputmin * 60;
                int Secofsec = Timeonearth.Second;
                int TotalSec = Secofhr + Secofmin + Secofsec;
                //("Total seconds for time :" + TotalSec);
                double USFSec = TotalSec / 45;
                //(USFSec);
                double USFMin = USFSec / 60;
                //(USFMin);
                decimal USFMIN = Convert.ToDecimal(USFMin);
                decimal USFHour = decimal.Truncate(USFMIN);
                String HOUR = Convert.ToString(USFHour);
                Console.WriteLine("The time in USF World is:" + USFHour);
                decimal USFMIN1 = USFMIN - Math.Truncate(USFMIN);
                //(USFMIN1);
                decimal USFMINS = USFMIN1 * 60;
                //(USFMINS);
                decimal USFMINSFINAL = decimal.Truncate(USFMINS);
                String MIN = Convert.ToString(USFMINSFINAL);
                Console.WriteLine(USFMINSFINAL);
                decimal USFSEC = USFMINS - Math.Truncate(USFMINS);
                //(USFSEC);
                decimal USFSEC1 = USFSEC * 45;
                //(USFSEC1);
                decimal USFSECFINAL = decimal.Truncate(USFSEC1);
                String SECONDS = Convert.ToString(USFSECFINAL);
                Console.WriteLine(USFSECFINAL);
                Console.WriteLine(HOUR + ':' + MIN + ':' + SECONDS);

            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                // Writing the code using divisibility methods. If the number is divisible by 3 and 5, it will be divisible by 15.
                //Time Taken: 170 minutes. Learning: How to use If and Else if functions. 


                for (int i = 1; i <= n3; i++)
                {

                    if (i % 105 == 0)
                    {
                        Console.Write("USF ");
                    }
                    else if (i % 15 == 0)
                    {
                        Console.Write("US ");
                    }
                    else if (i % 35 == 0)
                    {
                        Console.Write("SF ");
                    }
                    else if (i % 21 == 0)
                    {
                        Console.Write("UF ");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("U ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("S ");
                    }
                    else if (i % 7 == 0)
                    {
                        Console.Write("F ");
                    }

                    else
                    {
                        Console.Write(i + " ");
                    }
                    if (i % k == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine();

                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }



        public static void PalindromePairs(string[] words)
        {
            try
            {


                // Here, Concat function is used to add up the words and then check that if the word is a pallindrome or not.
                //Time Taken: 300 minutes. Learning: Using reverse functions and how to work on pallindromes.
                for (int i = 0; i <= words.Length - 1; i++)
                {
                    for (int j = 0; j <= words.Length - 1; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }

                        String whole = words[i] + words[j];
                        char[] toReverse = whole.ToCharArray();
                        Array.Reverse(toReverse);
                        String reversal = new string(toReverse);
                        if (String.Equals(whole, reversal))
                        {
                            Console.Write("[" + i + "," + j + "]");
                        }
                    }
                }
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }
        public static void fun(int final)
        {
            if (final == 0)
            {
                return;
            }
    
            }

            
        
           
            
            
        }


    }
