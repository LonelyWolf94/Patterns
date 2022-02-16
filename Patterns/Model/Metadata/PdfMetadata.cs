namespace Patterns.Model.Metadata
{
    public class PdfMetadata : Metadata
    {
        public int QuantityPages { get; set; } = 0;

        public override string ToString()
        {
            return $"{base.ToString()}, Quantity of pages: {QuantityPages}";
        }
    }
}
