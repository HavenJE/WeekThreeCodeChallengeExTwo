
// Exercise 2

// Write a program named DemoJobs for Harold’s Home Services. The program should instantiate several Job objects and demonstrate their
// methods. The Job class contains four data fields: descriptor (for example, “wash windows”), time in hours to complete (for example, 3.5),
// the per-hour rate charged (for example, $35.00), and total fee (hourly rate times hours).

// Include properties to get and set each field except the total fee — that field will be read-only and its value is calculated each time
// the hourly fee or the number of hours is set.

// Write a method for the Job class to display information about a Job object. The Job class also contains a method to change the per-hour
// rate by adding an amount of money to the current rate if the current rate of the job is less than $20.00.

// Write a Main() method that demonstrates all the methods work correctly.

using WeekThreeCodeChallengeExTwo;

class DemoJobs
{
    public static void Main()
    {
        Job job1 = new Job();
        job1.JobDescription = "wash windows";
        job1.Time = 3.5;
        job1.HourRate = 5;

     
        // method 
        job1.DisplayJobInformation();
    }
}