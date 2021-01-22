using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Paractice1
{
    class Program
    {
        class program
        {
            float radius, height, BaseArea, LateralArea, TotalArea, Volume;


            public void Process()
            {
                Console.WriteLine("Enter the dimenstions of the cylinder");
                Console.Write("Radius: ");
                radius = Convert.ToSingle(Console.ReadLine());
                Console.Write("Height: ");
                height = Convert.ToSingle(Console.ReadLine());
                BaseArea = (float)(radius * radius * Math.PI);
                LateralArea = (float)(2 * Math.PI * radius * height);
                TotalArea = (float)(2 * Math.PI * radius * (height + radius));
                Volume = (float)(Math.PI * radius * radius * height);
            }
            public void Result()
            {
                Console.WriteLine("Cylinder Characteristics");
                Console.Write("Raidus: {0:F2}. Height: {1:F2}", radius, height);
                Console.WriteLine("Base: {0:F2} : Lateral: {1:F2} : Total: {2:F2} : Volume: {3:F2}", BaseArea, LateralArea, TotalArea, Volume);
            }
            static void Main(string[] args)
            {
                program objCylinder = new program();
                objCylinder.Process();
                objCylinder.Result();

            }
        }
    }
}