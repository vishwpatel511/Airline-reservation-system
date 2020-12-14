using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Transactions;

namespace Programming_practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            int responce = 0;
            bool[] totalSeatArray = new bool[] {true, false, false, false, false, false, false, false, false, false, false};

            while (responce != 3)
            {
                Console.WriteLine("Welcome to Indian Airways");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. First Class");
                Console.WriteLine("2. Economy Class");
                Console.WriteLine("3. Exit");
                responce = Convert.ToInt32(Console.ReadLine());

                switch (responce)
                {

                    case 1:


                        Random rndm = new Random();
                        int seatNumFirstClass = rndm.Next(1, 6);

                        if (totalSeatArray[1] == false || totalSeatArray[2] == false || totalSeatArray[3] == false ||
                            totalSeatArray[4] == false || totalSeatArray[5] == false)
                        {
                            if (totalSeatArray[seatNumFirstClass] != true)
                            {
                                while (totalSeatArray[seatNumFirstClass] != true)
                                {
                                    Console.WriteLine("Your seat number is: " + seatNumFirstClass);
                                    totalSeatArray[seatNumFirstClass] = true;
                                    break;

                                }
                            }
                            else
                            {
                                goto case 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine(
                                "No seats are available please enter option 2 for booking the seat in economy class...");
                            int rep = Convert.ToInt32(Console.ReadLine());
                            if (rep == 2)
                            {
                                goto case 2;
                            }
                            else
                            {
                                Console.WriteLine("Next flight leaves in 3 hours...");
                            }

                           
                        }
                        break;




                    case 2:

                        if (totalSeatArray[6] == false || totalSeatArray[7] == false || totalSeatArray[8] == false ||
                            totalSeatArray[9] == false || totalSeatArray[10] == false)
                        {
                            Random rnd = new Random();
                            int seatEconomyclass = rnd.Next(6, 11);

                            if (totalSeatArray[seatEconomyclass] != true)
                            {
                                while (totalSeatArray[seatEconomyclass] != true)
                                {
                                    Console.WriteLine("Your seat number is: " + seatEconomyclass);
                                    totalSeatArray[seatEconomyclass] = true;
                                    break;

                                }
                            }
                            else
                            {
                                goto case 2;
                            }
                        }
                        else
                        {
                            Console.WriteLine(
                                "No seats are available please enter option 1 for booking the seat in first class...");
                            int rep = Convert.ToInt32(Console.ReadLine());
                            if (rep == 1)
                            {
                                goto case 1;  
                            }
                            else
                            {
                                Console.WriteLine("Next flight leaves in 3 hours...");
                               
                            }

                           

                        }

                        break;

                    case 3: 

                        Console.WriteLine("Good bye see you next time...");
                        break;
                }
             
                
            }

            

         

                    

                }
        
            }

            // Console.Clear();




        }



        

    






// Part 1 of assignment 1
/*
Console.WriteLine("Enter any character: ");
char responce =  Convert.ToChar(Console.ReadLine());

Console.WriteLine("Your responce was: " + responce);
*/

/*
Console.WriteLine("Do you like programming in C#? (true/false)");
bool answer = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Do you like programming?: {0}" ,answer);
*/

/*   Console.WriteLine("Enter radius of the circle");
   float radius = float.Parse(Console.ReadLine());
   float area = 3.14f * radius * radius;
   Console.WriteLine("Area of circle with given radius is: {0}", area);
*/

/*
Console.WriteLine("Welcome to city zoo...");
Console.WriteLine("-----------------------");
Console.WriteLine("How many adult tickets do you want: ");
int numAdult = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many child tickets do you want: ");
int numChild = Convert.ToInt32(Console.ReadLine());
double total = (numAdult * 3.75) + (numChild * 2.25);
Console.WriteLine("Your total is: {0}", total.ToString("C" ,CultureInfo.CurrentCulture));
*/
/*
Random rndm  = new Random();

int[] ResultArray = new int[12]{0,0,0,0,0,0,0,0,0,0,0,0 };

for (int i = 0; i < 36000; i++)
{
    int dice1 = rndm.Next(1, 7);
    double dice2 = rndm.Next(1, 7);
    double total = dice1 + dice2;
    if (total == 1)
    {
        ResultArray[0] = ResultArray[0] + 1;

    }
    else if (total == 2)
    {
        ResultArray[1] = ResultArray[1] + 1;

    }
    else if (total == 3)
    {
        ResultArray[2] = ResultArray[2] + 1;

    }
    else if (total == 4)
    {
        ResultArray[3] = ResultArray[3] + 1;

    }

       else if (total == 5)
       {
           ResultArray[4] = ResultArray[4] + 1;

       }

       else if (total == 6)
       {
           ResultArray[5] = ResultArray[5] + 1;

       }

       else if (total == 7)
       {
           ResultArray[6] = ResultArray[6] + 1;

       }

       else if (total == 8)
       {
           ResultArray[7] = ResultArray[7] + 1;

       }

       else if (total == 9)
       {
           ResultArray[8] = ResultArray[8] + 1;

       }

    else if (total == 10)
       {
           ResultArray[9] = ResultArray[9] + 1;

       }
    else if (total == 11)
    {
        ResultArray[10] = ResultArray[10] + 1;

    }
    else if (total == 12)
       {
           ResultArray[11] = ResultArray[11] + 1;

       }
   }

Console.WriteLine("Total was number 2: " + ResultArray[1] + " Probabily is: " + ResultArray[1]/36000);
Console.WriteLine("Total was number 3: " + ResultArray[2] + " Probabily is: " + ResultArray[2] / 36000);
Console.WriteLine("Total was number 4: " + ResultArray[3] + " Probabily is: " + ResultArray[3] / 36000);
Console.WriteLine("Total was number 5: " + ResultArray[4] + " Probabily is: " + ResultArray[4] / 36000);
Console.WriteLine("Total was number 6: " + ResultArray[5] + " Probabily is: " + ResultArray[5] / 36000);
Console.WriteLine("Total was number 7: " + ResultArray[6] + " Probabily is: " + ResultArray[6] / 36000);
Console.WriteLine("Total was number 8: " + ResultArray[7] + " Probabily is: " + ResultArray[7] / 36000);
Console.WriteLine("Total was number 9: " + ResultArray[8] + " Probabily is: " + ResultArray[8] / 36000);
Console.WriteLine("Total was number 10: " + ResultArray[9] + " Probabily is: " + ResultArray[9] / 36000);
Console.WriteLine("Total was number 11: " + ResultArray[10] + " Probabily is: " + ResultArray[10] / 36000);
Console.WriteLine("Total was number 12: " + ResultArray[11] + " Probabily is: " + ResultArray[11] / 36000);

   */

