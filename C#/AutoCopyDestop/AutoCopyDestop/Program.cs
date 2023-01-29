using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using System.Reflection;
using System.IO;


namespace AutoCopyDestop
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start...");
            CopyDestop();

            Console.WriteLine("Finish...");
        }

        private static void CopyDestop()
        {
            string targetPath = @"H:\\DISK-BAHADIR\\";
            string sourcePath = @"d:\\Users\\dtbsenyayla\\Desktop\\DISK-BAHADIR\\";

            CheckAndCreateFolder(targetPath);
            CheckAndCreateFolder(sourcePath);

            string[] notInStr = new string[] { "ini", "lnk" };

            foreach (string newPath in Directory.GetFiles(@"d:\\Users\\dtbsenyayla\\Desktop\\", "*.*", SearchOption.TopDirectoryOnly))
            {
                string[] fileExtension = newPath.Split('.');
                if (ContainsAll(fileExtension[1], notInStr))
                {
                    continue;
                }

                File.Copy(newPath, newPath.Replace(@"d:\\Users\\dtbsenyayla\\Desktop\\", sourcePath), true);
            }

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == "H:\\")
                {
                    foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                    {
                        File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
                    }
                }
            }


        }


        private static bool ContainsAll(string s, string[] predicates)
        {
            foreach (string str in predicates)
            {
                if (s == str)
                {
                    return true;
                }
            }
            return false;
        }


        private static void CheckAndCreateFolder(string path)
        {
            bool exists = System.IO.Directory.Exists(path);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(path);
            }

        }

    }
}

