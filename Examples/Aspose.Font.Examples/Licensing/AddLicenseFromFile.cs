using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Font.Examples.Licensing
{
    class AddLicenseFromFile
    {
        public static void Run()
        {
            //ExStart: 1
            License lic = new License();

            lic.SetLicense("path-to-licence-file.lic");
            //ExEnd: 1
        }
    }
}
