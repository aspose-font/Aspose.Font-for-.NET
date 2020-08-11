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
    class DetectLatinSymbolsSupport
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();
            //ExStart: 1
            string fileName = dataDir + "courier.pfb"; //Font file name with full path

            FontDefinition fd = new FontDefinition(FontType.Type1, new FontFileDefinition("pfb", new FileSystemStreamSource(fileName)));
            Type1Font font = Aspose.Font.Font.Open(fd) as Type1Font;

            bool latinText = true;


            for (uint code = 65; code < 123; code++)
            {
                GlyphId gid = font.Encoding.DecodeToGid(code);
                if (gid == null || gid == GlyphUInt32Id.NotDefId)
                {
                    latinText = false;
                }
            }

            if (latinText)
            {
                Console.WriteLine(string.Format("Font {0} supports latin symbols.", font.FontName));
            }
            else
            {
                Console.WriteLine(string.Format("Latin symbols are not supported by font {0}.", font.FontName));
            }
            //ExEnd: 1
        }
    }
}