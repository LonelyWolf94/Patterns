using Patterns.Model.Metadata;

namespace Patterns.Model
{
    public class Converter
    {
        public static PdfMetadata ConvertTextToPdfMetadata(string text)
        {
            var textArray = text.Split(",");

            return new PdfMetadata
            {
                Title = textArray[0],
                Description = textArray[1],
                QuantityPages = int.Parse(textArray[2])
            };
        }
    }
}
