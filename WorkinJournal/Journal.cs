namespace WorkingJournal
{
    public class Journal
    {
        private Dictionary<DateTime, List<Employee>> _records = new();

        public Journal()
        {
        }

        public void AddRecord(DateTime calendarDate, List<Employee> employees)
        {
            calendarDate = calendarDate.Date;

            if (_records.ContainsKey(calendarDate))
            {
                _records[calendarDate].AddRange(employees);
            }
            else
            {
                _records.Add(calendarDate, employees);
            }
        }

        public int GetTotalWorkingDays(Employee employee)
        {
            return _records.Count(x => !x.Key.IsHoliday() && x.Value.Contains(employee));
        }
    }
}