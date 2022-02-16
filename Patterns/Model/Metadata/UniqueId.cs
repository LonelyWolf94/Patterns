namespace Patterns.Model.Metadata
{
    public class UniqueId
    {
        private static int _id { get; set; } = 1;

        private UniqueId() {}

        public static int GetId()
        {
            return _id++;
        }

    }
}
