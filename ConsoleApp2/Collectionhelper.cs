
global using System;
global using System.Collections.Generic;
global using ConsoleApp2;


namespace ConsoleApp2
{
   
    public class Collectionhelper
    {
        public void DirectoryPrint()
        {
            Dictionary<int, string> directoryObj = new Dictionary<int, string>(5);

            directoryObj.Add(101, "Kirtesh Shah");
            directoryObj.Add(102, "Nitya Shah");
            directoryObj.Add(103, "Sweta Shah");
            directoryObj.Add(104, "Hansa Shah");
            directoryObj.Add(105, "Dilip Shah");

            for (int i = 101; i < (101 + directoryObj.Count); i++)
            {
                Console.WriteLine(directoryObj[i]);
            }
        }
    }
}
