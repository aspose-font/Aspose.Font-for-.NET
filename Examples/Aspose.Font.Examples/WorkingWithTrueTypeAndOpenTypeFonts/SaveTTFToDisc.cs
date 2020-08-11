using Aspose.Font.Sources;
using Aspose.Font.Ttf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Font.Examples.WorkingWithTrueTypeAndOpenTypeFonts
{
    class SaveTTFToDisc
    {
        public static void Run()
        {
            //ExStart: 1
            //byte array to load Font from
            string dataDir = RunExamples.GetDataDir_Data();
            
            byte[] fontMemoryData = File.ReadAllBytes(dataDir + "Montserrat-Regular.ttf");
            FontDefinition fd = new FontDefinition(FontType.TTF, new FontFileDefinition("ttf", new ByteContentStreamSource(fontMemoryData)));
            TtfFont ttfFont = Aspose.Font.Font.Open(fd) as TtfFont;

            //Work with data from just loaded TtfFont object

            //Save CffFont to disk
            //Output Font file name with full path
            string outputFile = RunExamples.GetDataDir_Data() + "Montserrat-Regular_out.ttf";

            ttfFont.Save(outputFile);
            //ExEnd: 1
        }
    }
}
