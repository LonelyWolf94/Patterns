using System;

namespace Patterns.Model
{
    public class SenderManager
    {
        public SenderManager SendByEmail(Metadata.Metadata metadata)
        {
            Console.WriteLine($"Sending '{metadata.Id}' by email to client");
            return this;
        }

        public SenderManager SendByFacebook(Metadata.Metadata metadata)
        {
            Console.WriteLine($"Sending '{metadata.Id}' by Facebook to client");
            return this;
        }

        public SenderManager SendByTelegram(Metadata.Metadata metadata)
        {
            Console.WriteLine($"Sending '{metadata.Id}' by Telegram to client");
            return this;
        }
    }
}
