using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaper
{
    class Program
    {
        static void Main(string[] args)
        {
            string a11 = "X", a12 = "X", a13 = "X", b11 = "X", b12 = "X", b13 = "X", c11 = "X", c12 = "X", c13 = "X", a1 = " ", a2 = " ", a3 = " ", b1 = " ", b2 = " ", b3 = " ", c1 = " ", c2 = " ", c3 = " " ;
            int d11, d12, d13, e11, e12, e13, f11, f12, f13, number, rc,i=0,point;
            string shape1=" ", shape2 = " ", shape3 = " ", shape4 = " ", shape5 = " ", shape6 = " ", shape7 = " ", shape8 = " ", shape9 = " ";
            string x11 = " ", x12 = " ", x13 = " ", y11 = " ", y12 = " ", y13 = " ", z11 = " ", z12 = " ", z13 = " ";
            
            Random rnd = new Random();
            d11 = rnd.Next(0, 2);
            d12 = rnd.Next(0, 2);
            d13 = rnd.Next(0, 2);
            e11 = rnd.Next(0, 2);
            e12 = rnd.Next(0, 2);
            e13 = rnd.Next(0, 2);
            f11 = rnd.Next(0, 2);
            f12 = rnd.Next(0, 2);
            f13 = rnd.Next(0, 2);

            if (d11 == 0) x11 = "X";
            else x11 = " ";
            if (d12 == 0) x12 = "X";
            else x12 = " ";
            if (d13 == 0) x13 = "X";
            else x13 = " ";
            if (e11 == 0) y11 = "X";
            else y11 = " ";
            if (e12 == 0) y12 = "X";
            else y12 = " ";
            if (e13 == 0) y13 = "X";
            else y13 = " ";
            if (f11 == 0) z11 = "X";
            else z11 = " ";
            if (f12 == 0) z12 = "X";
            else z12 = " ";
            if (f13 == 0) z13 = "X";
            else z13 = " ";

            do
            {
                i++;
                Console.WriteLine("------ Raund {0} ------", i);
                Console.Write("The Game's Matris\t"); Console.WriteLine("Your Matris");
                Console.Write("  " + " " + "1" + " " + "2" + " " + "3  \t" + "       "); Console.WriteLine("  " + " " + "1" + " " + "2" + " " + "3");
                Console.Write(" +" + " -" + " " + "-" + " " + "- + \t" + "       "); Console.WriteLine(" +" + " -" + " " + "-" + " " + "- +");
                Console.Write("1|" + " " + x11 + " " + x12 + " " + x13 + " |\t       "); Console.WriteLine("1|" + " " + a1 + " " + a2 + " " + a3 + " |" );
                Console.Write("2|" + " " + y11 + " " + y12 + " " + y13 + " |\t       "); Console.WriteLine("2|" + " " + b1 + " " + b2 + " " + b3 + " |\t");
                Console.Write("3|" + " " + z11 + " " + z12 + " " + z13 + " |\t       "); Console.WriteLine("3|" + " " + c1 + " " + c2+ " " + c3 + " |\t"  );
                Console.Write(" +" + " -" + " " + "-" + " " + "- + \t" + "       "); Console.WriteLine(" +" + " -" + " " + "-" + " " + "- +\t" );
                Console.WriteLine("--Your Shape--");

                number = rnd.Next(1, 201);
                if (number >= 1 && number <= 90)
                {
                    shape1 = "|X|X|";
                    Console.WriteLine(shape1);
                }

                else if (number >= 91 && number <= 180)
                {
                    shape2 = "|X|";
                    shape3 = "|X|";
                    Console.WriteLine(shape2);
                    Console.WriteLine(shape3);
                }


                else if (number >= 181 && number <= 185)
                {
                    shape4 = "|X| |";
                    Console.WriteLine(shape4);
                }

                else if (number >= 186 && number <= 190)
                {
                    shape5 = "|X|";
                    shape6 = "| |";
                    Console.WriteLine(shape5);
                    Console.WriteLine(shape6);
                }

                else if (number >= 191 && number <= 195)
                {
                    shape7 = "| |X|";
                    Console.WriteLine(shape7);
                }


                else if (number >= 196 && number <= 200)
                {
                    shape8 = "| |";
                    shape9 = "|X|";
                    Console.WriteLine(shape8);
                    Console.WriteLine(shape9);
                }

                Console.Write("Enter The Row And Column Number: ");
                rc = Convert.ToInt32(Console.ReadLine());
                while ((rc == 13 && (number <= 90 || (number >= 181 && number <= 185) || (number >= 191 && number <= 195))) || (rc == 23 && (number <= 90 || (number >= 181 && number <= 185) || (number >= 191 && number <= 195))) || (rc == 31 && ((number >= 91 && number <= 180) || (number >= 186 && number <= 190) || (number >= 196 && number <= 200))) || (rc == 32 && ((number >= 91 && number <= 180) || (number >= 186 && number <= 190) || (number >= 196 && number <= 200))) || rc == 33||( rc!=11 && rc !=12 && rc != 13 && rc != 21 && rc != 22 && rc != 23 && rc != 31 && rc != 32 && rc != 41 && rc != 42))
                {
                    i++; Console.WriteLine("------ Raund {0} ------", i);
                    if (rc == 13 && (number <= 90 || (number >= 181 && number <= 185) || (number >= 191 && number <= 195))) Console.WriteLine("Out Of The Board!");
                    if (rc == 23 && (number <= 90 || (number >= 181 && number <= 185) || (number >= 191 && number <= 195))) Console.WriteLine("Out Of The Board!");
                    if (rc == 31 && ((number >= 91 && number <= 180) || (number >= 186 && number <= 190) || (number >= 196 && number <= 200))) Console.WriteLine("Out Of The Board!");
                    if (rc == 32 && ((number >= 91 && number <= 180) || (number >= 186 && number <= 190) || (number >= 196 && number <= 200))) Console.WriteLine("Out Of The Board!");
                    if (rc == 33) Console.WriteLine("Out Of The Board!");
                    if (rc != 11 && rc != 12 && rc != 13 && rc != 21 && rc != 22 && rc != 23 && rc != 31 && rc != 32 && rc!=33 && rc != 41 && rc != 42 && rc!=41&&rc!=42) Console.WriteLine("Out Of The Board!");
                    Console.Write("Enter The Row And Column Number: ");
                    rc = Convert.ToInt32(Console.ReadLine());
                } 



                while (rc == 41)
                  {
                    i++; Console.WriteLine("------ Raund {0} ------", i);
                    if (number <= 90)
                        {
                        shape2 = "|X|"; Console.WriteLine(shape2);
                        shape3 = "|X|"; Console.WriteLine(shape3);
                        number = rnd.Next(91,180);
                    }
                    else if (number >= 91 && number <= 180)
                    {
                        shape1 = "|X|X|";
                        Console.WriteLine(shape1);
                        number = rnd.Next(0, 90);
                    }
                    else if (number >= 181 && number <= 185)
                    {
                        shape5 = "|X|"; Console.WriteLine(shape5);
                        shape6 = "| |"; Console.WriteLine(shape6);
                        number = rnd.Next(186, 190);
                    }
                    else if (number >= 186 && number <= 190)
                    {
                        shape7 = "| |X|"; Console.WriteLine(shape7);
                        number = rnd.Next(191, 195);
                    }
                    else if (number >= 191 && number <= 195)
                    {
                        shape8 = "| |"; Console.WriteLine(shape8);
                        shape9 = "|X|"; Console.WriteLine(shape9);
                        number = rnd.Next(196, 200);

                    }
                    else if (number >= 196 && number <= 200)
                    {
                        shape4 = "|X| |"; Console.WriteLine(shape4);
                        number = rnd.Next(181, 185);
                    }

                    Console.Write("Enter The Row And Column Number: ");
                    rc = Convert.ToInt32(Console.ReadLine());
                   }
                while (rc==42)
                  {
                    i++; Console.WriteLine("------ Raund {0} ------", i);
                    if (number <= 90)
                        {
                        shape2 = "|X|"; Console.WriteLine(shape2);
                        shape3 = "|X|"; Console.WriteLine(shape3);
                        number = rnd.Next(91,180);
                    }
                    else if (number >= 91 && number <= 180)
                    {
                        shape1 = "|X|X|";
                        Console.WriteLine(shape1);
                        number = rnd.Next(0, 90);
                    }
                    else if (number >= 181 && number <= 185)
                    {
                        shape8 = "| |"; Console.WriteLine(shape8);
                        shape9 = "|X|"; Console.WriteLine(shape9);
                        number = rnd.Next(196, 200);
                    }
                    else if (number >= 186 && number <= 190)
                    {
                        shape4 = "|X| |"; Console.WriteLine(shape4);
                        number = rnd.Next(181, 185);
                    }
                    else if (number >= 191 && number <= 195)
                    {
                        shape5 = "|X|"; Console.WriteLine(shape5);
                        shape6 = "| |"; Console.WriteLine(shape6);
                        number = rnd.Next(186, 190);

                    }
                    else if (number >= 196 && number <= 200)
                    {
                        shape7 = "| |X|"; Console.WriteLine(shape7);
                        number = rnd.Next(191, 195);
                    }

                    Console.Write("Enter The Row And Column Number: ");
                    rc = Convert.ToInt32(Console.ReadLine());
                   }
                

                switch (rc)
                { case 11:
                        if (number <= 90)
                        {
                            if (a11 == a1) a1 = " ";
                            else a1 = "X";
                            if (a12 == a2) a2 = " ";
                            else a2 = "X";
                        }
                        if (number >= 91 && number <= 180)
                        {
                            if (a11 == a1) a1 = " ";
                            else a1 = "X";
                            if (b11 == b1) b1 = " ";
                            else b1 = "X";
                        }
                        if (number >= 181 && number <= 185)
                        {
                            if (a11 == a1) a1 = " ";
                            else a1 = "X";
                        }
                        if (number >= 186 && number <= 190)
                        {
                            if (a11 == a1) a1 = " ";
                            else a1 = "X";
                        }
                        if (number >= 191 && number <= 195)
                        {
                            if (a12 == a2) a2 = " ";
                            else a2 = "X";
                        }
                        if (number >= 196 && number <= 200)
                        {
                            if (b11 == b1) b1 = " ";
                            else b1 = "X";
                        } break;
                    case 12:
                        if (number <= 90)
                        {
                            if (a12 == a2) a2 = " ";
                            else a2 = "X";
                            if (a13 == a3) a3 = " ";
                            else a3 = "X";
                        }
                        if (number >= 91 && number <= 180)
                        {
                            if (a12 == a2) a2 = " ";
                            else a2 = "X";
                            if (b12 == b2) b2 = " ";
                            else b2 = "X";
                        }
                        if (number >= 181 && number <= 185)
                        {
                            if (a12 == a2) a2 = " ";
                            else a2 = "X";
                        }
                        if (number >= 186 && number <= 190)
                        {
                            if (a12 == a2) a2 = " ";
                            else a2 = "X";
                        }
                        if (number >= 191 && number <= 195)
                        {
                            if (a13 == a3) a3 = " ";
                            else a3 = "X";
                        }
                        if (number >= 196 && number <= 200)
                        {
                            if (b12 == b2) b2 = " ";
                            else b2 = "X";
                        }
                        break;
                    case 13:
                       
                        
                        if (number >= 91 && number <= 180)
                        {
                            if (a13 == a3) a3 = " ";
                            else a3 = "X";
                            if (b13 == b3) b3 = " ";
                            else b3 = "X";
                        }
                       
                       if (number >= 186 && number <= 190)
                        {
                            if (a13 == a3) a3 = " ";
                            else a3 = "X";
                        }
                        

                        if (number >= 196 && number <= 200)
                        {
                            if (b13 == b3) b3 = " ";
                            else b3 = "X";
                        }
                        break;
                    case 21:
                        if (number <= 90)
                        {
                            if (b11 == b1) b1 = " ";
                            else b1 = "X";
                            if (b12 == b2) b2 = " ";
                            else b2 = "X";
                        }
                        if (number >= 91 && number <= 180)
                        {
                            if (b11 == b1) b1 = " ";
                            else b1 = "X";
                            if (c11 == c1) c1 = " ";
                            else c1 = "X";
                        }
                        if (number >= 181 && number <= 185)
                        {
                            if (b11 == b1) b1 = " ";
                            else b1 = "X";
                        }
                        if (number >= 186 && number <= 190)
                        {
                            if (b11 == b1) b1 = " ";
                            else b1 = "X";
                        }
                        if (number >= 191 && number <= 195)
                        {
                            if (b12 == b2) b2 = " ";
                            else b2 = "X";
                        }
                        if (number >= 196 && number <= 200)
                        {
                            if (c11 == c1) c1 = " ";
                            else c1 = "X";
                        }
                        break;
                    case 22:
                        if (number <= 90)
                        {
                            if (b12 == b2) b2 = " ";
                            else b2 = "X";
                            if (b13 == b3) b3 = " ";
                            else b3 = "X";
                        }
                        if (number >= 91 && number <= 180)
                        {
                            if (b12 == b2) b2 = " ";
                            else b2 = "X";
                            if (c12 == c2) c2 = " ";
                            else c2 = "X";
                        }
                        if (number >= 181 && number <= 185)
                        {
                            if (b12 == b2) b2 = " ";
                            else b2 = "X";
                        }
                        if (number >= 186 && number <= 190)
                        {
                            if (b12 == b2) b2 = " ";
                            else b2 = "X";
                        }
                        if (number >= 191 && number <= 195)
                        {
                            if (b12 == b3) b3 = " ";
                            else b3 = "X";
                        }
                        if (number >= 196 && number <= 200)
                        {
                            if (c12 == c2) c2 = " ";
                            else c2 = "X";
                        }
                        break;
                    case 23:
                        if (number >= 91 && number <= 180)
                        {
                            if (b13 == b3) b3 = " ";
                            else b3 = "X";
                            if (c13 == c3) c3 = " ";
                            else c3 = "X";
                        }
                        
                        if (number >= 186 && number <= 190)
                        {
                            if (b13 == b3) b3 = " ";
                            else b3 = "X";
                        }
                        
                        if (number >= 196 && number <= 200)
                        {
                            if (c13 == c3) c3 = " ";
                            else c3 = "X";
                        }
                        break;
                    case 31:
                        if (number <= 90)
                        {
                            if (c11 == c1) c1 = " ";
                            else c1 = "X";
                            if (c12 == c2) c2 = " ";
                            else c2 = "X";
                        }
                        
                        if (number >= 181 && number <= 185)
                        {
                            if (c11 == c1) c1 = " ";
                            else c1 = "X";
                        }
                       
                        if (number >= 191 && number <= 195)
                        {
                            if (c12 == c2) c2 = " ";
                            else c2 = "X";
                        }
                       
                        break;
                    case 32:
                        if (number <= 90)
                        {
                            if (c12 == c2) c2 = " ";
                            else c2 = "X";
                            if (c13 == c3) c3 = " ";
                            else c3 = "X";
                        }
                       if (number >= 181 && number <= 185)
                        {
                            if (c12 == c2) c2 = " ";
                            else c2 = "X";
                        }
                        
                        if (number >= 191 && number <= 195)
                        {
                            if (c13 == c3) c3 = " ";
                            else c3 = "X";
                        }
                       break;

                      
               }

            } while (x11 != a1 || x12 != a2||x13!=a3||y11!=b1||y12!=b2||y13!=b3||z11!=c1||z12!=c2||z13!=c3);
            Console.WriteLine("^Congratulations^");
            point = 200 - 10 * i;
            Console.WriteLine("Your Point: "+point);


            Console.ReadLine();










































        }
    }
}

       
