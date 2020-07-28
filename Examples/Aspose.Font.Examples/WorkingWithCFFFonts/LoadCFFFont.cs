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
    class LoadCFFFont
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();
            //ExStart: LoadCFFFromDisc
            string fileName = dataDir + "OpenSans-Regular.cff"; //Font file name with full path

            FontDefinition fd = new FontDefinition(FontType.CFF, new FontFileDefinition("cff", new FileSystemStreamSource(fileName)));
            CffFont ttfFont = Aspose.Font.Font.Open(fd) as CffFont;
            //ExEnd: LoadCFFFromDisc
        }

        public static void LoadCffFromByteArray()
        {
            string dataDir = RunExamples.GetDataDir_Data();
            //ExStart: LoadCffFromByteArray
            byte[] fontMemoryData = File.ReadAllBytes(dataDir + "OpenSans-Regular.cff");
            FontDefinition fd = new FontDefinition(FontType.CFF, new FontFileDefinition("cff", new ByteContentStreamSource(fontMemoryData)));
            CffFont cffFont = Aspose.Font.Font.Open(fd) as CffFont;
            //ExEnd: LoadCffFromByteArray
        }
    }
}
