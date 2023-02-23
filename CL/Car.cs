using System;
using System.Collections.Generic;
using System.Text;

namespace CL
{
    public class Car
    {
        int numberOfDoors;
        string color;

        public Car(int nrOfDoors, string color, bool isCon)
        {
            NumberOfDoors = nrOfDoors;
            Color = color;
            IsConvertible = isCon;
        }

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {
                if (numberOfDoors < 5)
                {
                    numberOfDoors = value;
                }
                else
                {
                    Console.WriteLine($"The number of doors {numberOfDoors} is not valid");
                }

            }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool IsConvertible { get; set; }

        public void Accelerate()
        {
            Console.WriteLine("Put the pedal to the floor!");
        }

        public bool IsFamilityCar()
        {
            if (numberOfDoors >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
           return base.ToString();
        }

    }
}
