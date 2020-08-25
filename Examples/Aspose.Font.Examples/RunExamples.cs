using Aspose.Font.Examples.WorkingWithCFFFonts;
using Aspose.Font.Examples.WorkingWithTrueTypeAndOpenTypeFonts;
using Aspose.Font.Examples.WorkingWithType1Fonts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Font.Examples
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");


            // Set License
            //License lic = new License();
            //lic.SetLicense("C:\\Program Files (x86)\\Aspose\\Licenses\\Aspose.Font.NET.lic");

            #region Working wtih TTF Fonts
            WorkingWithTrueTypeAndOpenTypeFonts.DetectLatinSymbolsSupport.Run();
            WorkingWithTrueTypeAndOpenTypeFonts.ExtractLicenseRestrictions.Run();
            WorkingWithTrueTypeAndOpenTypeFonts.GetFontMetrics.Run();
            WorkingWithTrueTypeAndOpenTypeFonts.RenderingText.Run();
            LoadTrueTypeFonts.Run();
            SaveTTFToDisc.Run();
            #endregion

            #region Wroking Type1 Fonts
            WorkingWithType1Fonts.DetectLatinSymbolsSupport.Run();
            WorkingWithType1Fonts.GetFontMetrics.Run();
            WorkingWithType1Fonts.RenderingText.Run();
            LoadType1Fonts.Run();
            #endregion

            #region Wroking CFF Fonts
            LoadCFFFont.Run();
            LoadCFFFont.LoadCffFromByteArray();
            SaveCFFToDisc.Run();
            #endregion
            
            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }

        public static string GetDataDir_Data()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return Path.Combine(startDirectory, "Data\\");
        }
    }
}
