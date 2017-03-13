using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Generic_Library
{
    public class ClassFolder
    {

        public string getEntry()
        {
            return @"C:\Users\dell pc\Documents\CS129LGenericVotingSystem\Entry\";
        }

        public string getUser()
        {
            return @"C:\Users\dell pc\Documents\CS129LGenericVotingSystem\Users\";
        }

        public string getContest()
        {
            return @"C:\Users\dell pc\Documents\CS129LGenericVotingSystem\Contest\";
        }

        public string getAdmin()
        {
            return @"C:\Users\dell pc\Documents\CS129LGenericVotingSystem\Admin\";
        }

        public ClassFolder()
        { }

        public void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }
    }
}