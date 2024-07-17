using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Services;
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
            Console.WriteLine("Enter 1 for Decimal to Binary");
            Console.WriteLine("Enter 2 for Binary to Decimal");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Console.WriteLine("Please input a decimal number from 0 to 255 (in digits): ");
                string userInput = Console.ReadLine();
                char myChar = userInput[0];
                bool myBool = Char.IsDigit(myChar);
                while (myBool == false)
                {
                    Console.WriteLine("Your input is not valid");
                    Console.WriteLine("Please re-input a decimal number from 0 to 255 (IN DIGITS!!): ");
                    userInput = Console.ReadLine();
                    myChar = userInput[0];
                    myBool = Char.IsDigit(myChar);
                }
                int myInput = Convert.ToInt32(userInput);
                if (myInput < 0 || myInput > 255)
                {
                    while (myInput < 0 || myInput > 255)
                    {
                        Console.WriteLine("Your input is not valid");
                        Console.WriteLine("Please re-input a decimal number from 0 to 255 (in digits): ");
                        userInput = Console.ReadLine();
                        myInput = Convert.ToInt32(userInput);
                    }
                }
                
                if (myInput > -1 && myInput < 256)
                {
                    string result = denaryToBinary(myInput);
                    Console.WriteLine("Number in binary is: " + result);
                }
            }

            if (userChoice == "2")
            {
                Console.WriteLine("Please enter a binary number between 1 and 8 bits (in digits): ");
                string userInput1 = Console.ReadLine();
                //int myInput1 = Convert.ToInt32(userInput1);
                string myDenery = binaryToDenary(userInput1);
                Console.WriteLine("Number in denary is: " + myDenery);
            }
        }

        ///Subroutines for Extension  <summary> 
        ///DENARY TO BINARY
        static string denaryToBinary(int myInput)
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

        ///BINARY TO DENARY
        static string binaryToDenary(string userInput1)
        {
            int length = userInput1.Length -1;
            ///int i = 0;
            ///int userInput2 = Convert.ToInt32(userInput1);
            int a = 2;
            int multiply = 0;
            int result = 0;
            ///char binaryDig = userInput1[length];
            ///int binaryDig1 = Convert.ToInt32(binaryDig);
            ///int binaryDig1 = Convert.ToInt32(userInput1[length]);
            ///Console.WriteLine(userInput1[length]);
            //Console.WriteLine(length);
            char binaryDig1 = userInput1[length];
            char i = Convert.ToChar(0);
            char j = Convert.ToChar(0);
            while (length >= 0) 
            {
                if (binaryDig1 == i) 
                {
                    a = a * 2;
                    ///i = i + 1;
                    length = length - 1;
                    ///binaryDig = userInput1[length];
                    ///binaryDig1 = Convert.ToInt32(binaryDig);
                    //binaryDig1 = Convert.ToInt32(userInput1[length]);
                    binaryDig1 = userInput1[length];
                }
                else if (binaryDig1 == j)
                {
                    int digDig = Convert.ToInt32(binaryDig1);
                    multiply = digDig * a;
                    a = a * 2;
                    length = length - 1;
                    ///binaryDig = userInput1[length];
                    ///binaryDig1 = Convert.ToInt32(binaryDig);
                    //binaryDig1 = Convert.ToInt32(userInput1[length]);
                    result = multiply + result;
                    ///i = i + 1;
                    binaryDig1 = userInput1[length];
                } 
                else
                {
                    a = a * 2;
                    ///i = i + 1;
                    length = length - 1;
                    ///binaryDig = userInput1[length];
                    ///binaryDig1 = Convert.ToInt32(binaryDig);
                    //binaryDig1 = Convert.ToInt32(userInput1[length]);
                    binaryDig1 = userInput1[length];
                }
                Console.WriteLine("Waiting for your result...");
            }
            string result1 = Convert.ToString(result);
            return result1;
            //int result = 0;
            //for (int i = myInput1.Length; i > 0; i--)
            //{
            //    if (myInput1.Substring(i - 1, 1) == "1")
            //    {
            ///        result += (int)Math.Pow(2, (myInput1.Length - i));
            //    }
            //}
            //return result.ToString();
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
