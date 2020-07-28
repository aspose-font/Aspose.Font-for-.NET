using Aspose.Font.Examples.WorkingWithCFFFonts;
using Aspose.Font.Examples.WorkingWithTrueTypeAndOpenTypeFonts;
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

            License lic = new License();
            lic.SetLicense("J://Aspose.Total.Product.Family.lic");

            #region Working wtih TTF Fonts
            DetectLatinSymbolsSupport.Run();
            ExtractLicenseRestrictions.Run();
            GetFontMetrics.Run();
            LoadTrueTypeFonts.Run();
            RenderingText.Run();
            SaveTTFToDisc.Run();
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
