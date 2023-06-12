using System;

class Program
{
    public class Job
        {
            public string _company;
            public string _jobTitle;
            public int _startYear;
            public int _endYear;
            public void DisplayJobInformation()
            {
                Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
            }
        }
    
    public class Resume
        {
            public string _name;
            public List<Job> _listOfJobs = new List<Job>();
            public void DisplayResume()
            {
                Console.WriteLine($"Name: {_name}\nJobs:");
                foreach (Job job in _listOfJobs)
                {
                    job.DisplayJobInformation();
                }
            }
        }

    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2000;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._jobTitle = "Mechanical Engineer";
        job2._company = "Amazon";
        job2._startYear = 2016;
        job2._endYear = 2018;

        Resume myResume = new Resume();
        myResume._name = "Blaine";
        myResume._listOfJobs.Add(job1);
        myResume._listOfJobs.Add(job2);
        myResume.DisplayResume();
    }
}