using Patterns.Model;
using Patterns.Model.Metadata;
using Patterns.Model.MetadataFactory;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfMetadata pdfMetadata = (PdfMetadata)MetadataFactory.GetMetadata("pdf");
            VideoMetadata videoMetadata = (VideoMetadata)MetadataFactory.GetMetadata("video");
            
            pdfMetadata.Title = "How to write good code";
            pdfMetadata.Description = "How to write excellent code";
            pdfMetadata.QuantityPages = 25;

            videoMetadata.Title = "How to drive car very well";
            videoMetadata.Description = "How to drive car safely";
            videoMetadata.Duration = 60 * 19;

            Console.WriteLine(pdfMetadata);
            Console.WriteLine(videoMetadata);

            SenderManager senderManager = new SenderManager();

            senderManager.SendByEmail(pdfMetadata).SendByTelegram(pdfMetadata);
            senderManager.SendByFacebook(videoMetadata).SendByEmail(videoMetadata);

            var text = "How to cook tasty borsh,In this brochure tells how to cook tasty borsh,3";

            var borshPdfMetadata = Converter.ConvertTextToPdfMetadata(text);

            Console.WriteLine(borshPdfMetadata);
            senderManager.SendByEmail(borshPdfMetadata);
        }
    }
}
