namespace CRUDCSharpWebApi.Persistence
{
    public class DevEventsDbContext
    {
        public List<EventArgs> Events { get; set; }

        public DevEventsDbContext()
        {
            Events = new List<EventArgs> { };
        }

    }
}
