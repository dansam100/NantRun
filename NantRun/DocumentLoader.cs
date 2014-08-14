using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NantRun.Document;
using NantRun.Loader;

namespace NantRun
{
    public class DocumentLoader
    {
        public string FileName{ get; set; }
        public static LoadedDocument Document{ get; set; }

        private static IAsyncResult iAsyncResult = null;


        public DocumentLoader(string filename)
        {
            this.FileName = filename;
        }

        /// <summary>
        /// Load specified file and return instance
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static LoadedDocument Load(string filename)
        {
            ParameterizedThreadStart threadStart = ThreadLoader.Load;
            iAsyncResult = threadStart.BeginInvoke(filename, null, null);
            
            //do other things

            threadStart.EndInvoke(iAsyncResult);
            
            return Document;
        }

        /// <summary>
        /// Open the specified document and return an instance
        /// </summary>
        /// <returns></returns>
        public LoadedDocument Load()
        {
            return Load(this.FileName);
        }
    }
}
