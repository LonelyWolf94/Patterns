namespace Patterns.Model.Metadata
{
    public class VideoMetadata : Metadata
    {
        public int Duration { get; set; } = 0;

        public override string ToString()
        {
            return $"{base.ToString()}, Duration: {Duration}";
        }
    }
}
