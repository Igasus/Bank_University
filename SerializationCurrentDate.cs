using Bank_Logic;
using System.Text.Json;



namespace Bank_Serialization
{
    public class SerializationCurrentDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int SecondsPerDay { get; set; }



        public SerializationCurrentDate()
        {
            Day = Date.CurrentDate.Day;
            Month = Date.CurrentDate.Month;
            Year = Date.CurrentDate.Year;
            SecondsPerDay = Date.SecondsPerDay;
        }



        static public SerializationCurrentDate Deserialize(string json)
        {
            SerializationCurrentDate result =
                JsonSerializer.Deserialize<SerializationCurrentDate>(json);

            return result;
        }
    }
}
