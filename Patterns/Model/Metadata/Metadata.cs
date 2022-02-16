namespace Patterns.Model.Metadata
{
    public abstract class Metadata
    {
        public string Title { get; set; } = "NoTitle";
        public int Id { get; } = UniqueId.GetId();
        public string Description { get; set; } = "Description";

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Description: {Description}";
        }
    }
}
