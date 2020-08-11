using Aspose.Font.Glyphs;
using Aspose.Font.Sources;
using Aspose.Font.Type1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Font.Examples.WorkingWithType1Fonts
{
    class GetFontMetrics
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();
            //ExStart: 1
            string fileName = dataDir + "courier.pfb"; //Font file name with full path

            FontDefinition fd = new FontDefinition(FontType.Type1, new FontFileDefinition("pfb", new FileSystemStreamSource(fileName)));
            Type1Font font = Aspose.Font.Font.Open(fd) as Type1Font;

            string name = font.FontName;
            Console.WriteLine("Font name: " + name);
            Console.WriteLine("Glyph count: " + font.NumGlyphs);
            string metrics = string.Format(
                "Font metrics: ascender - {0}, descender - {1}, typo ascender = {2}, typo descender = {3}, UnitsPerEm = {4}",
                font.Metrics.Ascender, font.Metrics.Descender,
                font.Metrics.TypoAscender, font.Metrics.TypoDescender, font.Metrics.UnitsPerEM);

            Console.WriteLine(metrics);
            //ExEnd: 1
        }
    }
}
