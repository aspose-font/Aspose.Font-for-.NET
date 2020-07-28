using Aspose.Font.Sources;
using Aspose.Font.Ttf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Font.Examples.WorkingWithTrueTypeAndOpenTypeFonts
{
    class GetFontMetrics
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();

            //ExStart: 1
            string fileName = dataDir + "YourSignature.ttf"; //Font file name with full path

            FontDefinition fd = new FontDefinition(FontType.TTF, new FontFileDefinition("ttf", new FileSystemStreamSource(fileName)));
            TtfFont font = Aspose.Font.Font.Open(fd) as TtfFont;

            string name = font.FontName;
            Console.WriteLine("Font name: " + name);
            Console.WriteLine("Glyph count: " + font.NumGlyphs);
            string metrics = string.Format(
                "Font metrics: ascender - {0}, descender - {1}, typo ascender = {2}, typo descender = {3}, UnitsPerEm = {4}",
                font.Metrics.Ascender, font.Metrics.Descender,
                font.Metrics.TypoAscender, font.Metrics.TypoDescender, font.Metrics.UnitsPerEM);

            Console.WriteLine(metrics);

            //Get cmap unicode encoding table from font as object TtfCMapFormatBaseTable to access information about font glyph for symbol 'A'.
            //Also check that font has object TtfGlyfTable (table 'glyf') to access glyph.
            Aspose.Font.TtfCMapFormats.TtfCMapFormatBaseTable cmapTable = null;
            if (font.TtfTables.CMapTable != null)
            {
                cmapTable = font.TtfTables.CMapTable.FindUnicodeTable();
            }
            if (cmapTable != null && font.TtfTables.GlyfTable != null)
            {
                Console.WriteLine("Font cmap unicode table: PlatformID = " + cmapTable.PlatformId + ", PlatformSpecificID = " + cmapTable.PlatformSpecificId);

                //Code for 'A' symbol
                char unicode = (char)65;

                //Glyph index for 'A'
                uint glIndex = cmapTable.GetGlyphIndex(unicode);

                if (glIndex != 0)
                {
                    //Glyph for 'A'
                    Glyph glyph = font.GetGlyphById(glIndex);
                    if (glyph != null)
                    {
                        //Print glyph metrics
                        Console.WriteLine("Glyph metrics for 'A' symbol:");
                        string bbox = string.Format(
                            "Glyph BBox: Xmin = {0}, Xmax = {1}" + ", Ymin = {2}, Ymax = {3}",
                            glyph.GlyphBBox.XMin, glyph.GlyphBBox.XMax,
                            glyph.GlyphBBox.YMin, glyph.GlyphBBox.YMax);
                        Console.WriteLine(bbox);
                        Console.WriteLine("Width:" + font.Metrics.GetGlyphWidth(new GlyphUInt32Id(glIndex)));
                    }
                }
            }
            //ExEnd: 1
        }
    }
}
