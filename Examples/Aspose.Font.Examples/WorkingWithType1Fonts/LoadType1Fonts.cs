using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Font.Sources;
using Aspose.Font.Type1;


namespace Aspose.Font.Examples.WorkingWithType1Fonts
{
    class LoadType1Fonts
    {
        public static void Run()
        {
            string dataDir = RunExamples.GetDataDir_Data();
            //ExStart: 1
            string fileName = dataDir + "courier.pfb"; //Font file name with full path

            FontDefinition fd = new FontDefinition(FontType.Type1, new FontFileDefinition("pfb", new FileSystemStreamSource(fileName)));
            Type1Font font = Aspose.Font.Font.Open(fd) as Type1Font;
            //ExEnd: 1
        }
    }
}
