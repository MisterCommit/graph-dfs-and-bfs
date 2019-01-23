using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[100, 100];
            int nodes, edges;
            int a, b, first, second;


      
            Console.WriteLine("Please Enter the No of Nodes");
            nodes = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the No of Edges");
            edges = int.Parse(Console.ReadLine());




            for (a = 1; a <= nodes; a++)
            {
                for (b = 1; b <= nodes; b++)
                {
                    matrix[a, b] = 0;
                }
            }





            for (a = 1; a <= edges; a++)
            {
                Console.WriteLine("please enter first node of the {0} edge", a);
                first = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter second node of the {0} edge", a);
                second = int.Parse(Console.ReadLine());
                if (first <= nodes && second <= nodes)
                {
                    matrix[first, second] = 1;
                    matrix[second, first] = 1;
                }
            }


          
                    for (a = 1; a <= nodes; a++)
                     {
                     Console.WriteLine("\n");

                                 for (b = 1; b <= nodes; b++)
                                        {
                                            Console.Write("   {0}", matrix[a, b]);
                                        }
            }
            //////////////////////////////////////
            ///////////////dfs////////////////////
            ////////////using stack///////////////
            int starting_node;
            int[] status = new int[nodes+1];
            int[] stack = new int[100];
            int top=1;
            for(a=1; a<=nodes; a++)
            {
                status[a] = 1;
            }
            Console.WriteLine("\n\n\n please Enter the starting node");
            starting_node = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================DFS==================");
            stack[top] = starting_node;
            Console.Write(starting_node);
            status[starting_node] = 2;
            while (top!= 0)
            {
                for (a = 1; a <= nodes; a++)
                {
                    if (matrix[stack[top], a] == 1 && status[a] == 1)
                    {
                        top++;
                        stack[top] = a;
                        status[a] = 2;
                        Console.Write("     {0}",a);
                        continue;
                    }

                    if(a== nodes)
                    {
                        top--;
                        status[a] = 3;

                    }



                }

            }


            ///////////////////////////////////
            ///////////////////////////////////
            ///////////////////////////////////
            ///end/////////////////////////////
            Console.ReadLine();
        }
    }
}

