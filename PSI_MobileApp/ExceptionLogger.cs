﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_MobileApp
{
    public class ExceptionLogger : IDisposable
    {
        private string path = "C:\\Users\\Rokas\\source\\repos\\merges-psi-project\\PSI_MobileApp\\Log.txt";
        private FileStream fileStream;
        public ExceptionLogger() {
            if (!File.Exists(path))
            {
                fileStream = File.Create(path);
            }
        }
        public ExceptionLogger(string path)
        {
            this.path = path;
            if (!File.Exists(path))
            {
                fileStream = File.Create(path);
            }
        }

        public void Dispose()
        {
            fileStream.Close();
        }

        public void Log(Exception ex)
        {    
            if (fileStream != null)
            {
                using (var writer = new StreamWriter(fileStream))
                {
                    string LogMessage = DateTime.Now.ToString() + Environment.NewLine + "Exception " + ex.GetType().ToString() + " thrown: " + ex.Message + " " + ex.StackTrace + "\n";
                    writer.WriteAsync(LogMessage);

                }
            }
            else
            {
                using (var stream = new FileStream(path, FileMode.Append, FileAccess.Write))
                {
                    using (var writer = new StreamWriter(stream))
                    {
                        string LogMessage = DateTime.Now.ToString() + Environment.NewLine + "Exception " + ex.GetType().ToString() + " thrown: " + ex.Message + " " + ex.StackTrace + "\n";
                        writer.WriteAsync(LogMessage);

                    }
                }
            }
                              
        }
    }
}
