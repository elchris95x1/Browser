using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Media
{
    class data
    {
        public static List<string> history { get; set; } = new List<string>();

        public void FileIn()
        {
            //this try catch is complete to read file and place information in list of structures
            try
            {

                StreamReader inputFile;     //to read the file
                string strLine;                //to hold the line from the file
                //open the CSV file
                inputFile = File.OpenText(@"...\...\Files\History.dat");
                //place data from file into _vbTeam
                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file
                    strLine = inputFile.ReadLine();
                    history.Add(strLine);
                }
                //closes inputFile
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //displays an error message
                MessageBox.Show(ex.Message);
            }
        }

        public void FileOut()
        {
            //writing data back to existing file.
            try
            {
                // using StringBuilder to build the data to go to the file
                //creates an intance of StringBuilder
                StringBuilder outputStr = new StringBuilder();
                //while used to get all data in from the List
                for(int i = 0; i < history.Count; i++)
                {
                    outputStr.AppendLine(history[i]);
                }
                string filePath = (@"...\...\Files\History.dat");
                //This will actually write a new file with the text and closes it, then if 
                //the file already exist will overwrite the existing file. 
                File.WriteAllText(filePath, outputStr.ToString());
            }
            catch (Exception ex)
            {
                //displays an error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
