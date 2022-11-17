namespace Interfaces
{
    internal class Ticket : IEquatable<Ticket>
    {
        internal int DurationHours { get; set; }

        public Ticket(int durationhours)
        {
            DurationHours = durationhours;
        }
    }
}
