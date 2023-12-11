using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Application.FileIO
{
    class FileStreamClass
    {
        void fileSteamClass()
        {
            /*
             * The FileStream class in the System.IO namespace helps in reading from, writing to and closing files. 
             * This class derives from the abstract class Stream.
             */
        }

        void handlingFile()
        {
            /* You need to create a FileStream object to create a new file or open an existing file */
            /*
                FileStream <object_name> = new FileStream( <file_name>, <FileMode Enumerator>,
                   <FileAccess Enumerator>, <FileShare Enumerator>);
             */
            FileStream Fobj = new FileStream("sample.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            for (int i = 1; i <= 20; i++)
            {
                Fobj.WriteByte((byte)i);
            }
            Fobj.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(Fobj.ReadByte() + " ");
            }
            /* closing file */
            Fobj.Close();
        }

        void fileMode()
        {
            /*
                FileMode

                The FileMode enumerator defines various methods for opening files.
                The members of the FileMode enumerator are −            
            */
            {
                /* Truncate − It opens an existing file and truncates its size to zero bytes. */
                FileStream fobj = new FileStream("sample.txt", FileMode.Truncate, FileAccess.Read, FileShare.Read);
                fobj.Close();
            }
            {
                /* Append − It opens an existing file and puts cursor at the end of file, or creates the file, if the file does not exist. */
                FileStream fobj = new FileStream("sample.txt", FileMode.Append, FileAccess.Read, FileShare.Read);
                fobj.Close();
            }
            {
                /* Create − It creates a new file. */
                FileStream fobj = new FileStream("sample.txt", FileMode.Create, FileAccess.Read, FileShare.Read);
                fobj.Close();
            }
            {
                /* CreateNew − It specifies to the operating system, that it should create a new file. */
                FileStream fobj = new FileStream("sample.txt", FileMode.CreateNew, FileAccess.Read, FileShare.Read);
                fobj.Close();
            }
            {
                /* Open − It opens an existing file. */
                FileStream fobj = new FileStream("sample.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
                fobj.Close();
            }
            {
                /* OpenOrCreate − It specifies to the operating system that it should open a file if it exists, otherwise it should create a new file. */
                FileStream fobj = new FileStream("sample.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                fobj.Close();
            }
        }
        void fileAccess()
        {
            /*
             * FileAccess -> FileAccess enumerators have members
             */
            {
                /*  */
                FileStream fobj = new FileStream("sample.txt", FileMode.Create, FileAccess.Read, FileShare.Read);
                fobj.Close();
            }
            {
                /*  */
                FileStream fobj = new FileStream("sample.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                fobj.Close();
            }
            {
                /*  */
                FileStream fobj = new FileStream("sample.txt", FileMode.Create, FileAccess.Write, FileShare.Read);
                fobj.Close();
            }
        }
        void fileShare()
        {
            /*
             * FileShare
             * FileShare enumerators have the following members 
             */
            {
                /* Inheritable − It allows a file handle to pass inheritance to the child processes */
                FileStream fobj = new FileStream("sample.txt", FileMode.Create, FileAccess.Read, FileShare.Inheritable);
                fobj.Close();
            }
            {
                /* Read − It allows opening the file for reading. */
                FileStream fobj = new FileStream("sample.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                fobj.Close();
            }
            {
                /* None − It declines sharing of the current file */
                FileStream fobj = new FileStream("sample.txt", FileMode.Create, FileAccess.Write, FileShare.None);
                fobj.Close();
            }
            {
                /* ReadWrite − It allows opening the file for reading and writing */
                FileStream fobj = new FileStream("sample.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                fobj.Close();
            }
            {
                /* Write − It allows opening the file for writing */
                FileStream fobj = new FileStream("sample.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
                fobj.Close();
            }
        }
        public static void Example()
        {
            FileStreamClass obj = new FileStreamClass();
            obj.fileSteamClass();
            obj.handlingFile();
            obj.fileMode();
            obj.fileAccess();
            obj.fileShare();
        }
    }
}
