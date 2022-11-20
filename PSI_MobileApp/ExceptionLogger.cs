using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_MobileApp
{
    public class ExceptionLogger
    {
        private string path = "C:\\Users\\Matas\\source\\repos\\psi1-project-new\\PSI_MobileApp\\Log.txt";
        public void Log(Exception ex)
        {
            if(!File.Exists(path))
            {
                File.Create(path);
            }
            
            using(var context = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using(var writer = new StreamWriter(context))
                {
                    string LogMessage = DateTime.Now.ToString() + Environment.NewLine + "Exception " + ex.GetType().ToString() + " thrown: " + ex.Message + " " + ex.StackTrace+ "\n";
                    writer.WriteAsync(LogMessage);
                }

                    
            }
        }
    }
}
