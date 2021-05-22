using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace mini_total_commander
{
    public class Model
    {

        public Model()   
        { }
        internal string[] LoadPath(string path)
        {
            //Dr
                if (Directory.Exists(path)) 
                {
                    string[] dir = Directory.GetDirectories(path);
                    string[] files = Directory.GetFiles(path);
                    List<string> allItems = new List<string>();

                    foreach (String d in dir)
                    {
                        allItems.Add("<D>" + d.Remove(0, Path.GetDirectoryName(d).Length));
                    }
                    foreach (String f in files)
                    {
                        allItems.Add(f.Remove(0, Path.GetDirectoryName(f).Length));
                    }
                    return allItems.ToArray();
                }

                else
            {
                Process.Start(path);
                return null;
            }

  
        }
            
  

        internal string[] LoadDrives()
        {
            List<string> readyDrives = new List<string>();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {

               if (d.IsReady)
                {
                    readyDrives.Add(d.ToString());
                }

            }
            return readyDrives.ToArray();
        }

        internal bool CopyDir( string sourceDir, string targetDir)  
        {
            if (Directory.Exists(sourceDir)) 
            {
                Console.WriteLine(sourceDir + " target: " + targetDir);
                DirectoryCopy(sourceDir, targetDir, true);
            }
            else
            {
                
                    Console.WriteLine(sourceDir + " target: " + targetDir);
                    File.Copy(sourceDir, targetDir);  
            }
            return true;          

       }

        internal bool MoveDir(string sourceDir, string targetDir) 
        {

            if (Directory.Exists(sourceDir))  
            {
                Console.WriteLine(sourceDir + " target: " + targetDir);

                if (Directory.GetDirectoryRoot(sou­rceDir) == Directory.GetDirectoryRoot(targetDir)) 
                {
                    Directory.Move(sourceDir, targetDir);
                }
                else
                {
                    DirectoryCopy(sourceDir, targetDir, true);
                    Directory.Delete(sourceDir,true);
                }
               
            }
            else File.Move(sourceDir, targetDir);
            return true;

        }
        internal  bool RemoveDir(string dir)      
        {
            if (Directory.Exists(dir)) 
            {
                Directory.Delete(dir, true);
            }
            else
            {
                    File.Delete(dir);

            }
            return true;

        }

        internal string ReturnPath(string path)
        {
                if (Path.GetDirectoryName(path) == null) return "";
                else return Path.GetDirectoryName(path);

        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            

            DirectoryInfo[] dirs = dir.GetDirectories();
          
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

           
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name); 
                file.CopyTo(temppath, false);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }


}
