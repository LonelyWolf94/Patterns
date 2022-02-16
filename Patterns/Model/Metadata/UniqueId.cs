namespace Patterns.Model.Metadata
{
    public class UniqueId
    {
        private static int Id { get; set; } = 1;

        private UniqueId() {}

        public static int GetId()
        {
            return Id++;
        }

    }
}
