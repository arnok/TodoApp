using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{

    class Error
    {

        public static void recoverable_error(string message)
        {
            Logger.log(Logger.logLevel.error, message);
            MessageBox.Show(string.Format("Error occurred: {0}", message));
        }

        public static void terminal_error(string message)
        {
            Logger.log(Logger.logLevel.emergency, message);
            MessageBox.Show(
                string.Format("Error occurred: {0} The program will terminate.", message)
            );
            terminate_program();
        }

        private static void terminate_program()
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit(); // WinForms app
            }
            else
            {
                System.Environment.Exit(1); // Console app
            }
        }
    }
}
