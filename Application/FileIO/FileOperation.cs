using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FileIO
{
    class FileOperation
    {
        void readingFromWritingIntoTextFiles()
        {
            /* Reading from and Writing into Text files
                It involves reading from and writing into text files. The StreamReader and StreamWriter class helps to accomplish it */

        }
        void readingFromWritingIntoBinaryFiles()
        {
            /* Reading from and Writing into Binary files
                It involves reading from and writing into binary files. The BinaryReader and BinaryWriter class helps to accomplish this. */

        }
        void manipulatingWindowsFileSystem()
        {
            /* Manipulating the Windows file system
                It gives a C# programamer the ability to browse and locate Windows files and directories. */

        }
        public static void Example()
        {
            FileOperation obj = new FileOperation();
            obj.readingFromWritingIntoTextFiles();
            obj.readingFromWritingIntoBinaryFiles();
            obj.manipulatingWindowsFileSystem();
        }
    }
}
