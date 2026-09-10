namespace SUT26_Lektion_konvert_Git_Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int valueInt = 50;
            //double valueDouble = valueInt;

            //Console.WriteLine(valueDouble.GetType());

            //// Explicit

            //float fNumber = 543795.55f;

            //int intNumber = (int)fNumber; // Type Casting
            //int intNumber2 = Convert.ToInt32(fNumber); // Convert Class

            //Console.WriteLine(intNumber);

            int Result = 0;
            string stringValue = "123777777";
            //int conResult = int.Parse(stringValue);
            //Console.WriteLine(conResult.GetType());

            bool isConverted = int.TryParse(stringValue, out Result);

            if (isConverted)
            {
                Console.WriteLine("Result is : {0}",Result);
            }
            else
            {
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }


            Console.ReadKey();
        }
    }

    class user
    {

    }

    class student
    {

    }

    class user1
    {

    }

    class student1
    {
    
    }
}
