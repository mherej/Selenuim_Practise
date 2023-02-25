using System;
using System.Collections.Generic;
using System.Text;

namespace CL
{
    public class Trip
    {
        string destination { get; set; }
        double distanceTravelled { get; set; }
        double totalCostOfFuel { get; set; }
        double numberOfLitersConsumed { get; set; }

        public Trip(string dest, int distanceTrav, double totcost, double litersConsumend)
        {
            destination = dest;
            distanceTravelled = distanceTrav;
            totalCostOfFuel = totcost;
            numberOfLitersConsumed = litersConsumend;
        }

        public double KilometersPerLiter(double kilometers, double liters)
        {
            return kilometers / liters;
        }

        public double CostPerKilometer(double cost, double disatanceInKilometers)
        {
            return cost / disatanceInKilometers;
        }

        public override string ToString()
        {
            return ($" Travellinmg to {destination} distsance {distanceTravelled} kilometers, total cost of is {totalCostOfFuel} eoros that is {this.CostPerKilometer(this.totalCostOfFuel, this.distanceTravelled)} liters per kilometers!");
        }
    } 
}
