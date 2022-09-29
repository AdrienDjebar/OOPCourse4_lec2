using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course4
{
    class ParamClass
    {
        #region Value and reference
        static int ModifyValue(int variable_1)
        {
            variable_1 = 30;
            return variable_1;
        }
        static int ModifyValueWithRef(ref int variable_1)
        {
            variable_1 = 30;
            return variable_1;
        }
        static void SwapWithValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void SwapWithReference(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        #endregion
        static string GetVowels(params string[] input)
        {
            if (input == null || input.Length == 0)
            {
                return string.Empty;
            }
            var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            return string.Concat(input.SelectMany(word => word.Where(letter => vowels.Contains(char.ToUpper(letter)))));
        }

        //static void Main()
        //{
        //    string fromArray = GetVowels(new[] { "apple", "banana", "pear" });
        //    Console.WriteLine($"Vowels from array: {fromArray}");

        //    string fromMultipleArguments = GetVowels("apple", "banana", "pear");
        //    Console.WriteLine($"Vowels from multiples arguments: {fromMultipleArguments}");

        //    string fromNull = GetVowels(null);
        //    Console.WriteLine($"Vowels from null: {fromNull}");

        //    string fromNoValue = GetVowels();
        //    Console.WriteLine($"Vowels from no value: {fromNoValue}");

        //    #region Value and reference
        //    int variable_1 = 245;
        //    Console.WriteLine($"first call: {variable_1}");
        //    ModifyValue(variable_1); //We "changed" the value of variable_1 in the "ModifyValue" methods, but it didn't changed back to the Main()
        //    Console.WriteLine($"second call: {variable_1}");

        //    //if we truly want to change the value of variable_1 we have to put the "ref" keyword
        //    Console.WriteLine($"third call: {variable_1}");
        //    ModifyValueWithRef(ref variable_1); //We "changed" the value of variable_1 in the "ModifyValue" methods, but it didn't changed back to the Main()
        //    Console.WriteLine($"fourth call: {variable_1}");

        //    int i = 2, j = 3;
        //    Console.WriteLine("i = {0}, j = {1}", i, j);

        //    SwapWithValue(i, j);
        //    Console.WriteLine("Swapped with Val i = {0} j = {1} (didn't swap)", i, j);

        //    SwapWithReference(ref i, ref j);
        //    Console.WriteLine("Swapped With Ref i = {0} j = {1} (did swap)", i, j);
        //    #endregion
        //}
    }

    
    
}
