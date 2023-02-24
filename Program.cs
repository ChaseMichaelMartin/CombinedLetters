using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace PostageSaver
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Represents Files sent from each department each processing day. Recieved on 'Start' *_Click* 
            string[] inputFile1 = File.ReadAllLines(@"C:\Users\maudy\source\repos\PostageSaver\Input\Admission\20220125\admission-00000987.txt");
            string[] inputFile2 = File.ReadAllLines(@"C:\Users\maudy\source\repos\PostageSaver\Input\Scholarship\20220125\scholarship-00000987.txt");
            string[] inputFile3 = File.ReadAllLines(@"C:\Users\maudy\source\repos\PostageSaver\Input\Admission\20220125\admission-00000980.txt");
            string[] inputFile4 = File.ReadAllLines(@"C:\Users\maudy\source\repos\PostageSaver\Input\Scholarship\20220125\scholarship-00000980.txt");
            string[] inputFile5 = File.ReadAllLines(@"C:\Users\maudy\source\repos\PostageSaver\Input\Admission\20220125\admission-00000982.txt");
            string[] inputFile6 = File.ReadAllLines(@"C:\Users\maudy\source\repos\PostageSaver\Input\Scholarship\20220125\scholarship-00000981.txt");


            string[] combinedLetters = File.ReadAllLines(@"C:\Users\maudy\source\repos\PostageSaver\Output\LettersCombined.txt");
             
            using (StreamWriter archive = File.CreateText(@"C:\Users\maudy\source\repos\PostageSaver\Archive\ArchivedLetters.txt"))
            {

                for (int i = 0; i < inputFile1.Length || i < inputFile2.Length; i++)
                {
                    archive.WriteLine(inputFile1[i]);
                    archive.WriteLine(inputFile2[i]);   
                }
                for (int i = 0; i < inputFile3.Length || i < inputFile4.Length; i++)
                {
                    archive.WriteLine(inputFile3[i]);
                    archive.WriteLine(inputFile4[i]);
                }

                for (int i = 0; i < inputFile5.Length || i < inputFile6.Length; i++)
                {
                    archive.WriteLine(inputFile5[i]);
                    archive.WriteLine(inputFile6[i]);
                }

                using (StreamWriter combine = File.CreateText(@"C:\Users\maudy\source\repos\PostageSaver\Output\LettersCombined.txt"))
                {
                    Student student = new Student();

                    for (int i = 0; i < inputFile1.Length || i < inputFile2.Length; i++)
                    {

                        String fileID = System.IO.File.ReadAllText(@"C:\Users\maudy\source\repos\PostageSaver\Input\Admission\20220125\admission-00000987.txt");

                        if (inputFile2.Contains(fileID))
                        {
                            combine.WriteLine(inputFile1[i]);
                            combine.WriteLine(inputFile2[i]);

                            student.Letters = 2;
                            student.ID = fileID;
                        }

                    }

                    Student student1 = new Student();

                    for (int i = 0; i < inputFile3.Length || i < inputFile4.Length; i++)
                    {

                        String fileID = System.IO.File.ReadAllText(@"C:\Users\maudy\source\repos\PostageSaver\Input\Admission\20220125\admission-00000980.txt");

                        if (inputFile3.Contains(fileID))
                        {
                            combine.WriteLine(inputFile3[i]);
                            combine.WriteLine(inputFile4[i]);

                            student1.Letters = 2;
                            student1.ID = fileID;
                        }

                    }

                    Student student2 = new Student();

                    for (int i = 0; i < inputFile5.Length || i < inputFile6.Length; i++)
                    {

                        String fileID = System.IO.File.ReadAllText(@"C:\Users\maudy\source\repos\PostageSaver\Input\Admission\20220125\admission-00000982.txt");

                        if (inputFile6.Contains(fileID))
                        {
                            combine.WriteLine(inputFile5[i]);
                            combine.WriteLine(inputFile6[i]);

                            student2.Letters = 2;
                            student2.ID = fileID;
                        }
                        else
                        {
                            student2.ID = "";
                        }

                    }

                    using (StreamWriter sw2 = File.CreateText(@"C:\Users\maudy\source\repos\PostageSaver\Output\Report.txt"))
                    {

                        if (0 < combinedLetters.Count())

                            sw2.WriteLine("01/25/2022 Report" + "\r\n" + "-------------------" + "\r\n" + "Number of Combined Letters: " + combinedLetters.Count() / 2 + "\r\n" + student.ID + "\r\n" + student1.ID + student2.ID + "\r\n");
                    }
                }
            }

        }
    }
}

