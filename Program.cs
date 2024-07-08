using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            //int myInt = 0; //just for testing single stepping
            //string myString1 = "12"; //watch me being cast from string to int
            //int myStringAsInt = Convert.ToInt32(myString1); //watch me cast from string to int

            //MAIN:  NUMBER CONVERSION PROGRAM

            //CODE GOES HERE
            //Console.WriteLine(numberConversion(48, 2)); ///THIS CALLS AND OUTPUTS THE RESULT OF A SUBROUTINE



            ///NORMAL CONVERSION
            // Console.WriteLine("Please input decimal number from 0 to 255: "); 
            // string myInput = Console.ReadLine();
            // int myDecimal = Convert.ToInt32(myInput);
            // int myInteger = 0;
            // int myBinaryDig = 0;
            // string myBinaryNum = " ";
            // string myBinary = " ";
            // while (myDecimal / 2 != 0)
            // {
            //     myInteger = myDecimal / 2;
            //     myBinaryDig = myDecimal % 2;
            //     myBinary = myBinaryDig.ToString();
            //     myBinaryNum = myBinaryNum.Insert(0, myBinary);
            //     myDecimal = myInteger;
            // }
            // myInteger = myDecimal / 2;
            // myBinaryDig = myDecimal % 2;
            // myBinary = myBinaryDig.ToString();
            //myBinaryNum = myBinaryNum.Insert(0, myBinary);
            // Console.WriteLine("Number in binary is: " + myBinaryNum);

            //string myString2 = Console.ReadLine();
            //string newString = myString1.Insert(0, myString2); ///this inserts myString2 at the beginnging on myString1
            //Console.WriteLine(newString);
            ///


            ///SUBROUTINE CONVERSION
            //Console.WriteLine("Please input decimal number from 0 to 255: ");
            //string myInput = Console.ReadLine();
            //string result = convertToBinary(myInput);
            //Console.WriteLine("Number in binary is: " + result);
             
            ///Extension
            Console.WriteLine("Please input a decimal number from 0 to 255 (in digits): ");
            string userInput = Console.ReadLine();
            bool my != 0.IsDigit(myInput)
            int myInput = Convert.ToInt32(userInput);
            if (
            {

            }
            if (-1 < myInput && myInput < 256)
            {
                string result = convertToBinary(myInput);
                Console.WriteLine("Number in binary is: " + result);
            }
            else if (myInput != 0)
            {
                Console.WriteLine("Your input is not valid");
                Console.WriteLine("Please re-input a decimal number from 0 to 255 (in digits): ");
                userInput = Console.ReadLine();
                myInput = Convert.ToInt32(userInput);
            }
            else
            {
                Console.WriteLine("Your input is not valid");
                Console.WriteLine("Please re-input a decimal number from 0 to 255 (in digits): ");
                userInput = Console.ReadLine();
                myInput = Convert.ToInt32(userInput);
            }
            
        }

        ///Subroutine for Extension
        static string convertToBinary(int myInput)
        {
            int myDecimal = Convert.ToInt32(myInput);
            int myInteger = 0;
            int myBinaryDig = 0;
            string myBinaryNum = " ";
            string myBinary = " ";
            while (myDecimal / 2 != 0)
            {
                myInteger = myDecimal / 2;
                myBinaryDig = myDecimal % 2;
                myBinary = myBinaryDig.ToString();
                myBinaryNum = myBinaryNum.Insert(0, myBinary);
                myDecimal = myInteger;
            }
            myInteger = myDecimal / 2;
            myBinaryDig = myDecimal % 2;
            myBinary = myBinaryDig.ToString();
            myBinaryNum = myBinaryNum.Insert(0, myBinary);
            string finalNum = Convert.ToString(myBinaryNum);
            return finalNum;
        }
        ///

        ///SUBROUTINE FOR CONVERSION
        //static string convertToBinary(string myInput) 
        //{ 
        //    int myDecimal = Convert.ToInt32(myInput);
        //    int myInteger = 0;
        //    int myBinaryDig = 0;
        //    string myBinaryNum = " ";
        //    string myBinary = " ";
        //    while (myDecimal / 2 != 0)
        //    {
        //        myInteger = myDecimal / 2;
        //        myBinaryDig = myDecimal % 2;
        //        myBinary = myBinaryDig.ToString();
        //        myBinaryNum = myBinaryNum.Insert(0, myBinary);
        //        myDecimal = myInteger;
        //    }
        //    myInteger = myDecimal / 2;
        //    myBinaryDig = myDecimal % 2;
        //    myBinary = myBinaryDig.ToString();
        //    myBinaryNum = myBinaryNum.Insert(0, myBinary);
        //    string finalNum = Convert.ToString(myBinaryNum);
        //    return finalNum;
        //}
        ///

        //LET'S USE THE 'STRUCTURED APPROACH' TO PROGRAMMING... A QUICK INTRODUCTION TO SUBROUTINES(functions and procedures)...a.k.a
        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        //static string numberConversion(int number, int numberbase) ///THIS IS A SUBROUTINE 
        // {
        //     int num = number + numberbase;
        //     string result = Convert.ToString(num);
        //     ///we know the variable result is a string because of static string
        //     return result; //REMOVE THE RED LINE!
        // }
    }
}
