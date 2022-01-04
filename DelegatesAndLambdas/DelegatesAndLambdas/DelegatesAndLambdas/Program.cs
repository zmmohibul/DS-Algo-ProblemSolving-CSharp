using System;

namespace DelegatesAndLambdas
{
    class Program
    {
        /*
         * Delegates are basically a Type Definition for Functions
         * like a Class is for an Object. A Class provides the type
         * definition for an object and the Object is an instance of
         * that type. A delegate provides a type definition for 
         * functions and all the functions that fulfill the signature
         * of the delegate can be an instance of the delegate. In the
         * following a MathOp delegate is defined whose signature is 
         * that it takes two integers as parameter and returns a value
         * of type integer. Any function that has such signature can
         * be a delegate of type MathOp.
         */
        delegate int MathOp(int n1, int n2);
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(11, 11));
            Console.WriteLine(Subtract(11, 11));

            /*
             * The function Add takes two integers as parameter and
             * it returns an integer value. So the MathOp delegate
             * can be applied to Add function. It fulfill the contract
             * of the MathOp Delegate. So we can create a delegate
             * instance of type MathOp of the Add function in
             * the following way. MathOp f = Add;
             * Please Note: The Add function is not being invoked here
             * rather only a reference to the Add function is being
             * assigned to the 'f' MathOp instance.
             */
            MathOp f = Add;
            Console.WriteLine(f(21, 10)); // Output : 31

            f = Subtract;
            Console.WriteLine(f(21, 10)); // Output : 11
            
            
            
            CalculateAndPrint(21, 21, Add);
        }

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        /*
             * The CalculateAndPrint method takes two integers
             * and a MathOp delegate to compute the result using
             * the received delegate and print the result.
        */
        static void CalculateAndPrint(int n1, int n2, MathOp f)
        {
            var result = f(n1, n2);
            Console.WriteLine(result);
        }
    }
}