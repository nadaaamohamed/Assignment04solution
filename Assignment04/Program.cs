using System.Text;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Please Enter A Number");
            //int number;
            //int.TryParse(Console.ReadLine(), out number);
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q2.Write a program that allows the user to insert an integer then print a multiplication table up to 12
            //Console.WriteLine("please enter a number");
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i = 1; i <=12 ; i++)
            //{
            //    Console.WriteLine($"{i} * {number} = {i*number}");
            //}
            #endregion
            #region Q3.Write a program that allows to user to insert number then print all even numbers between 1 to this number 
            //Console.WriteLine("please enter a number");
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i =1 ; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("********************************");
            //for(int i = 2;i <= number; i += 2)
            //{
            //    Console.WriteLine(i);   
            //}

            #endregion
            #region Q4.Write a program that takes two integers then prints the power.
            //Console.WriteLine("Please enter two number");
            //int.TryParse(Console.ReadLine(), out int  Base);
            //int.TryParse(Console.ReadLine(), out int exponent);
            //int res = 1;
            //for (int i = 1; i <= exponent; i++)
            //{
            //    res *= Base;
            //}
            //Console.WriteLine($"{res}");

            #endregion
            #region Q5.Write a program to enter marks of five subjects and calculate total, average and percentage
            //marks 10 15 18 20 14 
            //sum 77 avg 15 // per 77
            // int[]marks=new int[5];
            // int sum = 0;
            //double avg = 0;
            //double percentage = 1;
            // for (int i = 0; i < 5; /*i++*/)
            // {
            //     Console.WriteLine($"Please Enter Marks Of Subject {i+1}");

            //    bool isparsed = int.TryParse(Console.ReadLine(), out marks[i]);
            //     if (isparsed)
            //         ++i;

            // }
            // for (int i = 0; i < 5; i++)
            // {
            //     sum += marks[i];

            // }
            // avg = sum / 5;
            // percentage = (sum * 100)/100;
            // Console.WriteLine($"Total Summation is {sum}");
            // Console.WriteLine($"Average is {avg}");
            // Console.WriteLine($"percentage is {percentage}");




            #endregion
            #region Q6. Write a program to allow the user to enter a string and print the REVERSE of it.
            //string message;
            //Console.WriteLine("please enter a message");
            //message=Console.ReadLine() ?? "0";
            //for (int i = message.Length-1; i >=0; i--)
            //{
            //    Console.Write(message[i]);  
            //}

            #endregion
            #region Q7.Write a program to allow the user to enter int and print the REVERSED of it.
            //int res = 0;
            //bool isparsed;
            //int number;
            //do
            //{
            //    Console.WriteLine("Please enter a number");
            //    isparsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!isparsed);
            //{
            //    while (number > 0)
            //    {
            //       int value = number % 10;
            //        res = (res * 10) + value;
            //        number = number / 10;


            //    }
            //    Console.WriteLine(res);

            //}
            #endregion
            #region #Q8.Write a program in C# Sharp to find prime numbers within a range of numbers
            #endregion
            #region #Q9.Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //int number;
            //bool isparsed;
            //string Binary = " ";
            //do
            //{
            //    Console.WriteLine("Please Enter A  number");
            //    isparsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!isparsed);

            //for (int i = 0; number > 0; i++)
            //{
            //    Binary = (number % 2) + Binary;
            //    number /= 2;
            //}
            //Console.WriteLine(Binary);


            #endregion
            #region #Q10.Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //int[] x = new int[3];
            //int[] y= new int[3];
            //Console.WriteLine("Please Enter Three points");
            //for(int i = 0; i<3; i++)
            //{
            //    Console.WriteLine($"Please Enter First Point {i+1}");
            //    int.TryParse( Console.ReadLine(), out x[i] );
            //    int.TryParse ( Console.ReadLine(), out y[i] );
            //}

            //int determinant = x[0] * (y[1] - y[2]) + x[1] * (y[2] - y[0]) + x[2] * (y[0] - y[1]);
            //if (determinant == 0)
            //{
            //    Console.WriteLine("The points lie on the same straight line");
            //}
            //else
            //{
            //    Console.WriteLine("The points lie is not on the same straight line");
            //}

            #endregion
            #region Q11.Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the matrix: ");
            //int.TryParse(Console.ReadLine(), out int n);
            //for (int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}


            #endregion
            #region Q12. Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    sum+= arr[i];
            //}
            //Console.WriteLine($"sum of all elements {sum}");

            #endregion
            #region Q13.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++) {
            //    arr[i]=Convert.ToInt32(Console.ReadLine());    

            //}
            //int[] arr1 = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());

            //}
            #endregion
            #region Q14.Write a program in C# Sharp to count the frequency of each element of an array.
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //bool[] counted = new bool[n];
            //for (int i = 0; i < n; i++)
            //{
            //    if (counted[i])
            //        continue;
            //    int count = 1;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //        }
            //        counted[j] = true;
            //        Console.WriteLine($"{arr[i]} : {count} ");
            //    }
            //}
            #endregion
            #region Q15.Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int Max = int.MinValue;
            //int Min=int.MaxValue;
            //for (int i = 0; i < arr.Length; i++) {
            //    if (arr[i] > Max)  
            //        Max = arr[i];
            //    if (arr[i] < Min)
            //        Min = arr[i];

            //}
            //Console.WriteLine($"{Max} , {Min}");

            #endregion
            #region Q16. Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = { 1, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int max=int.MinValue;
            //int max2 = int.MinValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max2 = max;
            //        max = arr[i];
            //    }
            //    else if (arr[i] > max2 && arr[i] != max)
            //        max2 = arr[i];

            //}
            //Console.WriteLine(max2);

            #endregion
            #region Q17.Consider an Array of Integer values with size N, having values as  
            #endregion

            #region Q18.Given a list of space separated words, reverse the order of the words.
            //string str = Console.ReadLine() ?? "0";
            //string[] word = str.Split(' ');
            //Array.Reverse(word);
            //string reverse = string.Join(" ", word);
            //Console.Write(reverse);

            #endregion
            #region Q19. Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            #endregion

            #region Q20. Write a Program to Print One Dimensional Array in Reverse Order
            //int[,] arr = new int[2, 3];
            //for(int i = 0; i < arr.GetLength(0); i++)

            //{
            //    Console.WriteLine(i + 2);
            //    for (int j = 0; j < arr.GetLength(1); /*j++*/)
            //    {
            //        bool isparsed = int.TryParse(Console.ReadLine(), out arr[i, j]);
            //        if (isparsed)
            //            ++j;
            //    }
            //} 
            //for(int i = 0;i<arr.GetLength(0); i--)
            //{
            //    for(int j=0 ; j<arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"{arr[i,j]}");
            //    }
            //    Console.WriteLine();
            //}   
            #endregion
        }
    }
}
