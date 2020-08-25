using Aspose.Font.Cff;
using Aspose.Font.Sources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Font.Examples.WorkingWithCFFFonts
{
    class SaveCFFToDisc
    {
        public static void Run()
        {
            //ExStart: 1
            //byte array to load Font from
            string dataDir = RunExamples.GetDataDir_Data();

            byte[] fontMemoryData = File.ReadAllBytes(dataDir + "OpenSans-Regular.cff");
            FontDefinition fd = new FontDefinition(FontType.CFF, new FontFileDefinition("cff", new ByteContentStreamSource(fontMemoryData)));
            CffFont cffFont = Aspose.Font.Font.Open(fd) as CffFont;

            //Work with data from just loaded TtfFont object

            //Save TtfFont to disk
            //Output Font file name with full path
            string outputFile = RunExamples.GetDataDir_Data() + "OpenSans-Regular_out.cff";

            cffFont.Save(outputFile);
            //ExEnd: 1
        }
    }
}
