using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLExtractor
{
    public enum Mode
    {
        Mode1=0, Mode2=1
    }
    public class XMLExtractor
    {
        public static Mode mode = Mode.Mode1;
        public static bool isNbLigneComplete { get; set; }

        // On découpe le fichier en packet de nbLigne
        public static void getFilesByNbLine(MainWindows windows, string inputFile, int nbLine, string path)
        {
            int index = 0;
            int counter = 0;
            double nbLineDone = 0.0;
            string fileNameFull = inputFile.Split('\\')[inputFile.Split('\\').Length - 1];
            string fileName = fileNameFull.Split('.')[0];
            string extension = fileNameFull.Split('.')[1];
            using (System.IO.StreamReader file = new System.IO.StreamReader(inputFile))
            {
                int count = File.ReadLines(inputFile).Count();
                // Read the file and display it line by line.

                bool append = false;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    nbLineDone++;
                    using (System.IO.StreamWriter fileWriter = new System.IO.StreamWriter(string.Concat(path, "\\", fileName, "_", index, ".", extension), append))
                    {
                        fileWriter.WriteLine(line);
                        if (counter >= nbLine)
                        {
                            counter = 0;
                            index++;
                            append = false;
                        }
                        else
                        {
                            append = true;
                        }
                        counter++;
                    }

                    windows.Progress = (int)(((double)(nbLineDone / (double)count)) * 100);
                }
                file.Close();

            }
        }


        public static string FileLocation { get; set; }

       
    }
}
