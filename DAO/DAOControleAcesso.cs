using System;
using System.Windows.Forms;
using System.IO;

namespace DAO
{
    public class DAOControleAcesso
    {
        public void arquivo(string msg)
        {
            string text = Application.StartupPath + @"\LOG\logs_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";

            FileInfo fi = new FileInfo(text);
            if (!fi.Directory.Exists)
                Directory.CreateDirectory(fi.Directory.FullName);
            File.AppendAllText(fi.FullName, msg + Environment.NewLine + Environment.NewLine);
        }
    }
}
