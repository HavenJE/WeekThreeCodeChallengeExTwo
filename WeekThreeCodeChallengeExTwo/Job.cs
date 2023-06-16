using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekThreeCodeChallengeExTwo
{
    internal class Job
    {
        // Data fields
        private string jobDescription;
        private double time;
        private double hourRate;
        private double totalFee;

        // Properties
        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }
        
        public double Time
        {
            get { return time; }
            set { time = value;
                CalculateTotalFees();
            }
        }
        public double HourRate
        {
            get { return hourRate; }
            set { hourRate = value;
                CalculateTotalFees();
            }
        }
        public double TotalFee { get; }

        // constructors
        // The constructor below is to eliminate an error in the Program.cs file 
        public Job()
        {

        }

        // writing a second constructor 
        public Job(string jobDescription, double time, double hourRate)
        {
            jobDescription = JobDescription;
            time = Time;
            hourRate = HourRate;
        }

        // method to display job information
        public void DisplayJobInformation()
        {
            Console.WriteLine("Job description is: {0}, takes {1} hours time, with an hour rate of {2} costs: {3}", JobDescription, Time, HourRate, totalFee);
        }

        // method to change the HourRate if curent rate is < $20
        public void UpdateJobHourReate(double amount) 
        {
            if (hourRate < 20)
            {
                hourRate += amount;
            }
        }

        // method to calculate total fees
        public void CalculateTotalFees()
        {
            totalFee = Time * HourRate;
        }
    }
}
