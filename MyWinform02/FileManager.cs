using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MyWinform02
{
    
    class FileManager
    {
        private Form1 form;

        public FileManager(Form1 form)
        {
            this.form = form;
        }

        public bool Copy(string SrcFile, string  DestFile)
        {
            byte[] buffer = new byte[1024]; //1kb
            int pointer01 = 0;

            try
            {
                //file size
                var f1 = new FileInfo(SrcFile);
                var fileSize = f1.Length;


                using (BinaryReader rd = new BinaryReader(File.Open(SrcFile, FileMode.Open)))
                using (var wt = new BinaryWriter(File.Open(SrcFile, FileMode.Create)))
                {
                    while (pointer01 < fileSize)
                    {
                        int cnt = rd.Read(buffer, 0, buffer.Length);
                        wt.Write(buffer, 0, cnt);
                        pointer01 += cnt;

                        double pct = (pointer01 / (double)fileSize) * 100.0;
                        form.progressBar1.Value = (int)pct;
                        form.TXT_SHOW_PERSENT.Text = string.Format("{0} %", (int)pct);
                    }
                }
                return true;
            }
            catch (FileNotFoundException e)
            {
                return false;
            }

        }
    }
}
