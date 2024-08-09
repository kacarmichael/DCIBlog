namespace DCIBlog.Server.Utils
{
    public struct DeltaValues
    {
        public int years;
        public int months;
        public int days;
        public int hours;
    };

    public class DateTimeDelta
    {
        public DateTimeDelta(DateTime alpha, DateTime omega) { }

        public DeltaValues Values { get; private set; }
    }
}
