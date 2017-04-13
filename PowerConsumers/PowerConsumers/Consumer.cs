namespace PowerConsumers.Controllers
{
    public class Consumer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public uint ConsumerNumber { get; set; }

        public NotificationPreferences PersonalPreferences { get; set; }
    }

    public class NotificationPreferences
    {
        public bool IsSmsEnabled { get; set; }

        public bool IsEmailEnabled { get; set; }
    }
}