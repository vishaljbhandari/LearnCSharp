using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FileIO
{
    class FileInputOutput
    {
        void fileAndStream()
        {
            /*
             * A file is a collection of data stored in a disk with a specific name and a directory path. 
             * When a file is opened for reading or writing, it becomes a stream
             * 
             * The stream is basically the sequence of bytes passing through the communication path
             * 
             * Two streams -> input stream & output stream
             *  The input stream is used for reading data from file (read operation)
             *  The output stream is used for writing into the file (write operation)
             */
        }
        public static void Example()
        {
            FileInputOutput obj = new FileInputOutput();
            obj.fileAndStream();

            FileOperation.Example();
            FileStreamClass.Example();
            IOClasses.Example();
        }
    }
}
