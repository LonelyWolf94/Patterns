using Patterns.Model.Metadata;

namespace Patterns.Model.MetadataFactory
{
    public class MetadataFactory 
    {
        public static Metadata.Metadata GetMetadata(string type)
        {
            if (type.Equals("pdf"))
            {
                return new PdfMetadata();
            }
            else
            {
                return new VideoMetadata();
            }
        }
    }
}
