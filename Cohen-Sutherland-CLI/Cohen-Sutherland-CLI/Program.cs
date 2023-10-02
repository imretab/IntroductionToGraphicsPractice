using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Cohen_Sutherland_CLI
{
    internal class Program
    {
        public const int INSIDE = 0; 
        public const int LEFT = 1; 
        public const int RIGHT = 2; 
        public const int BOTTOM = 4; 
        public const int TOP = 8;

        static int x_max, y_max, x_min, y_min;
        static double x1, y1, x2, y2;
        public static int computeCode(double x, double y)
        {
            int code = INSIDE;

            if (x < x_min) 
                code |= LEFT;
            else if (x > x_max) 
                code |= RIGHT;
            if (y < y_min) 
                code |= BOTTOM;
            else if (y > y_max) 
                code |= TOP;

            return code;
        }
        public static void cohenSutherlandClip(double x1, double y1,
                                double x2, double y2)
        {
            int code1 = computeCode(x1, y1);
            int code2 = computeCode(x2, y2);
            bool accept = false;

            while (true)
            {
                if ((code1 == 0) && (code2 == 0))
                {
                    accept = true;
                    break;
                }
                else if ((code1 & code2) != 0)
                {
                    break;
                }
                else
                {
                    int code_out;
                    double x = 0.0;
                    double y = 0.0;
                    if (code1 != 0)
                        code_out = code1;
                    else
                        code_out = code2;
                    if ((code_out & TOP) != 0)
                    {
                        x = x1 + (x2 - x1) * (y_max - y1) / (y2 - y1);
                        y = y_max;
                    }
                    else if ((code_out & BOTTOM) != 0)
                    {
                        x = x1 + (x2 - x1) * (y_min - y1) / (y2 - y1);
                        y = y_min;
                    }
                    else if ((code_out & RIGHT) != 0)
                    {
                        y = y1 + (y2 - y1) * (x_max - x1) / (x2 - x1);
                        x = x_max;
                    }
                    else if ((code_out & LEFT) != 0)
                    {
                        y = y1 + (y2 - y1) * (x_min - x1) / (x2 - x1);
                        x = x_min;
                    }
                    if (code_out == code1)
                    {
                        x1 = x;
                        y1 = y;
                        code1 = computeCode(x1, y1);
                    }
                    else
                    {
                        x2 = x;
                        y2 = y;
                        code2 = computeCode(x2, y2);
                    }
                }
            }
            if (accept)
            {
                Console.WriteLine($"Line accepted from {x1};{y1} to {x2};{y2}");
                //"Line accepted from " + x1 + ", +y1 + " to " + x2 + ", " + y2
            }
            else
                Console.WriteLine("Line rejected");
        }
        static void Main(string[] args)
        {
            int[] intervalInputsToInt = new int[4]; 
            string inputs;
            bool areInputsRight = false;
            do
            {
                Console.WriteLine("Input x and y min/max values in the following format: (x_min,y_min,x_max,y_max):");
                inputs= Console.ReadLine();
                string[] splittedInputs = inputs.Split(',');
                for (int i = 0; i < splittedInputs.Length; i++)
                {
                    if (!int.TryParse(splittedInputs[i], out intervalInputsToInt[i]))
                    {
                        areInputsRight = false;
                        break;
                    }
                    intervalInputsToInt[i] = int.Parse(splittedInputs[i]);
                    if (i == splittedInputs.Length - 1)
                    {
                        areInputsRight = true;
                    }
                }
                x_min = intervalInputsToInt[0];
                y_min = intervalInputsToInt[1];
                x_max = intervalInputsToInt[2];
                y_max = intervalInputsToInt[3];
            } while (!areInputsRight);
            areInputsRight = false;
            double[] pointValuesToInt = new double[4];
            inputs = string.Empty;
            do
            {
                Console.WriteLine("Input x1,y1,x2,y2 in the given format:");
                inputs = Console.ReadLine();
                string[] splittedInputs = inputs.Split(',');
                for (int i = 0; i < splittedInputs.Length; i++)
                {
                    if (!double.TryParse(splittedInputs[i], out pointValuesToInt[i]))
                    {
                        areInputsRight = false;
                        break;
                    }
                    pointValuesToInt[i] = double.Parse(splittedInputs[i]);
                    if (i == splittedInputs.Length - 1)
                    {
                        areInputsRight = true;
                    }
                    x1 = pointValuesToInt[0];
                    y1 = pointValuesToInt[1];
                    x2 = pointValuesToInt[2];
                    y2 = pointValuesToInt[3];
                }
            } while (!areInputsRight);
            cohenSutherlandClip(x1,y1,x2,y2);
            Console.ReadKey();
        }
    }
}
