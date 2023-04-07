namespace WorkingJournal
{
    public static class HolidayExtensions
    {
        public static bool IsHoliday(this DateTime date)
        {
            return Holiday.Holidays.Any(x => x.Date == date.Date);
        }
    }

    public class Holiday
    {
        public string Name { get; }
        public DateTime Date { get; }

        public Holiday(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public static List<Holiday> GetHolydays()
        {
            return Holidays.ToList();
        }

        public static readonly List<Holiday> Holidays = new()
        {
            new Holiday("New Year's Day", new DateTime(DateTime.Now.Year, 1, 1)),
            new Holiday("New Year's Day", new DateTime(DateTime.Now.Year, 1, 2)),
            new Holiday("Christmas Day", new DateTime(DateTime.Now.Year, 1, 7)),
            new Holiday("Epiphany", new DateTime(DateTime.Now.Year, 1, 19)),
            new Holiday("Mother's day", new DateTime(DateTime.Now.Year, 3, 3)),
            new Holiday("International Women's day", new DateTime(DateTime.Now.Year, 3, 8)),
            new Holiday("April 9 Memorial Day", new DateTime(DateTime.Now.Year, 4, 9)),

            //This holidays are moveable

            new Holiday("Good Friday", new DateTime(2023, 4, 14 )),
            new Holiday("Great Saturday", new DateTime(2023, 4, 15 )),
            new Holiday("Easter", new DateTime(2023, 4, 16 )),
            new Holiday("Second day of Easter", new DateTime(2023, 4, 17 )),

            new Holiday("The day of victory over fascism", new DateTime(DateTime.Now.Year, 5, 9 )),
            new Holiday("Saint Andrew the Apostle Memorial Day", new DateTime(DateTime.Now.Year, 5, 12 )),
            new Holiday("Independence Day of Georgia", new DateTime(DateTime.Now.Year, 5, 26 )),
            new Holiday("Assumption Day of the Most Holy Mother of God (Mary).", new DateTime(DateTime.Now.Year, 8, 28 )),
            new Holiday("Svetitskhovloba (Mtskhetoba) robe holiday", new DateTime(DateTime.Now.Year, 10, 14 )),
            new Holiday("St. George's Day", new DateTime(DateTime.Now.Year, 11, 23 ))
        };
    }

}