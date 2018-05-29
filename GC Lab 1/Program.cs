using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab_1
{

    class Program
    {
        static bool MainTask(int[] nums1, int[] nums2)
        {

            List<int> sumList = new List<int>();

            int temp;

            bool answer = true;

            for (int i = 0; i < nums2.Length; i++)
            {

                temp = nums1[i] + nums2[i];
                sumList.Add(temp);

            }

            int reference = sumList[0];

            for (int i = 0; i < nums1.Length; i++)
            {

                if ((sumList[i] == reference) && answer)
                {

                    //Do nothing

                }

                else
                {
                    
                    answer = false;

                }

            }

            return answer;

        }

        static string Input1(bool first)
        {

            bool whileBreak = false;

            int number = 0;

            if(first)
            {

                Console.WriteLine("Hello, please enter a whole number. ");

            }
            
            if(!first)
            {

                Console.WriteLine("Please enter a whole number.");

            }

            string output = Console.ReadLine();

            while (whileBreak == false)
            {

                bool tryAgain = false;

                try
                {

                    number = Convert.ToInt32(output);
                    
                }
                catch (FormatException e)
                {

                    Console.WriteLine("Input string is not a sequence of digits.");
                    Console.WriteLine("Please try again.");
                    output = Console.ReadLine();
                    whileBreak = false;
                    tryAgain = true;

                }
                catch (OverflowException e)
                {

                    Console.WriteLine("The number cannot fit in an Int32.");
                    Console.WriteLine("Please try again.");
                    output = Console.ReadLine();
                    whileBreak = false;
                    tryAgain = true;

                }
                finally
                {

                    if (tryAgain != true)
                    {

                        whileBreak = true;

                    }

                }

            }

            return output;

        }

        static string Input2()
        {

            bool whileBreak = false;

            int number = 0;

            Console.WriteLine("Please enter another whole number of the same length. ");
            string output = Console.ReadLine();

            while (whileBreak == false)
            {

                bool tryAgain = false;

                try
                {

                    number = Convert.ToInt32(output);

                }
                catch (FormatException e)
                {

                    Console.WriteLine("Input string is not a sequence of digits.");
                    Console.WriteLine("Please try again.");
                    output = Console.ReadLine();
                    whileBreak = false;
                    tryAgain = true;

                }
                catch (OverflowException e)
                {

                    Console.WriteLine("The number cannot fit in an Int32.");
                    Console.WriteLine("Please try again.");
                    output = Console.ReadLine();
                    whileBreak = false;
                    tryAgain = true;

                }
                finally
                {

                    if (tryAgain != true)
                    {

                        whileBreak = true;

                    }

                }

            }

            return output;

        }

        static bool LengthCheck(string in1, string in2)
        {

            bool check = false;

            var charArray1 = in1.ToCharArray();
            var charArray2 = in2.ToCharArray();

            check = (charArray1.Length == charArray2.Length);

            return check;

        }

        static void Main(string[] args)
        {

            //These are the raw inputs
            string input1;
            string input2;

            bool whileBreak = false;

            input1 = Input1(true);
            input2 = Input2();

            //Entry loop
            while (!whileBreak)
            {

                whileBreak = LengthCheck(input1, input2);

                if (!(LengthCheck(input1, input2)))
                {

                    Console.WriteLine("Entered numbers are not the same length, please try again.");

                    input1 = Input1(false);
                    input2 = Input2();

                }

            }

            //Magic time
            var charArray1 = input1.ToCharArray();
            var charArray2 = input2.ToCharArray();

            //Black magic time
            int[] numArray1 = Array.ConvertAll(charArray1, c => (int)Char.GetNumericValue(c));
            int[] numArray2 = Array.ConvertAll(charArray2, c => (int)Char.GetNumericValue(c));

            Console.WriteLine(MainTask(numArray1, numArray2));
            Console.ReadKey();
            
        }

    }

}
