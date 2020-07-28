using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Font.Sources;
using Aspose.Font.Ttf;

namespace Aspose.Font.Examples.WorkingWithTrueTypeAndOpenTypeFonts
{
    class LoadTrueTypeFonts
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();
            //ExStart: 1
            string fileName= dataDir+"YourSignature.ttf"; //Font file name with full path

            FontDefinition fd = new FontDefinition(FontType.TTF, new FontFileDefinition("ttf", new FileSystemStreamSource(fileName)));
            TtfFont ttfFont = Aspose.Font.Font.Open(fd) as TtfFont;
            //ExEnd: 1
        }
    }
}
