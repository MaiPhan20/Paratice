using System;

namespace Ex2_Paratice2
{
    class Animal
    {
        float weight;
        string name;

        public void Show()
        {
            Console.WriteLine("Name: {0}, Weight: {1}\n", name, weight);
        }
        public void SetMe(float weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

    }
}