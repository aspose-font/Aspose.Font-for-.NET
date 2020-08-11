using Aspose.Font.Sources;
using Aspose.Font.Ttf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Font.Examples.WorkingWithTrueTypeAndOpenTypeFonts
{
    class ExtractLicenseRestrictions
    {
        public static void Run()
        {
            //ExStart: 1
            string dataDir = RunExamples.GetDataDir_Data();
            //Font to check
            string fileName = dataDir + "Montserrat-Regular.ttf"; //Font file name with full path

            FontDefinition fd = new FontDefinition(FontType.TTF, new FontFileDefinition("ttf", new FileSystemStreamSource(fileName)));
            TtfFont font = Aspose.Font.Font.Open(fd) as TtfFont;
            LicenseFlags licenseFlags = null;
            if (font.TtfTables.Os2Table != null)
            {
                licenseFlags = font.TtfTables.Os2Table.GetLicenseFlags();
            }

            if (licenseFlags == null || licenseFlags.FSTypeAbsent)
            {
                Console.WriteLine(string.Format("Font {0} has no embedded license restrictions", font.FontName));
            }
            else
            {
                if (licenseFlags.IsEditableEmbedding)
                {
                    Console.WriteLine(
                        string.Format("Font {0} may be embedded, and may be temporarily loaded on other systems.", font.FontName)
                        + " In addition, editing is permitted, including ability to format new text"
                        + " using the embedded font, and changes may be saved.");
                }
                else if (licenseFlags.IsInstallableEmbedding)
                {
                    Console.WriteLine(
                        string.Format("Font {0} may be embedded, and may be permanently installed", font.FontName)
                        + " for use on a remote systems, or for use by other users.");
                }
                else if (licenseFlags.IsPreviewAndPrintEmbedding)
                {
                    Console.WriteLine(
                        string.Format("Font {0} may be embedded, and may be temporarily loaded", font.FontName)
                        + "  on other systems for purposes of viewing or printing the document.");
                }
                else if (licenseFlags.IsRestrictedLicenseEmbedding)
                {
                    Console.WriteLine(
                        string.Format("Font {0} must not be modified, embedded or exchanged in any manner", font.FontName)
                        + " without first obtaining explicit permission of the legal owner.");
                }
            }
            //ExEnd: 1
        }
    }
}
