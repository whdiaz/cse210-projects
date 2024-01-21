using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2026;
        job1._endYear = 2036;

        job2._jobTitle = "CEO";
        job2._company = "Microsoft";
        job2._startYear = 2036;
        job2._endYear = 2045;

        job1.DisplayInformationAboutJob();
        job2.DisplayInformationAboutJob();

        Resume resume1 = new Resume();
        resume1._name = "Willian Diaz";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayInformationAboutResume();
        
    }
}