namespace WorkingJournal
{
    public class Employee : Human
    {
        public int WorkingDays { get; set; }

        public Employee(string name, string surname) : base(name, surname)
        {
            WorkingDays = 0;
        }
    }

}