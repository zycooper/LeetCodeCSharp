class Program
    {
        static void Main(string[] args)
        {
           string[] lines =
           {
                "/*", "", "*/","",
                " /********************************************************************************",
                " Solution Category: 0",
                " *********************************************************************************",
                " Time Range:",
                " From: ",
                " To: ",
                " *********************************************************************************",
                " Submission Result:",
                "",
                " *********************************************************************************",
                " Note: ",
                "",
                " *********************************************************************************/",
            };

            List<string> list = new List<string>();
            foreach (string dirFile in Directory.GetDirectories(@"C:\Users\T1703001\Desktop\LC\"))
            {
                foreach (string path in Directory.GetFiles(dirFile))
                {
                    // fileName  is the file name
                    if (new System.IO.FileInfo(path).Length ==0)
                    {
                        File.WriteAllLines(path, lines);
                    }
                }
            }                
        }
    }