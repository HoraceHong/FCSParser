using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace AnalyseFile
{
    public class FileOperator
    {
        FileStream m_File = null;
        public FileOperator(string strPath)
        {
            FileMode fMode = FileMode.Open;
            m_File = new FileStream(strPath, fMode);
            
        }

        public string ReadFile(int iStartPos, int iEndPos)
        {
            List<byte> bContent = new List<byte>();
            m_File.Read(bContent.ToArray(), iStartPos, iEndPos - iStartPos);

            return bContent.ToString();
        }

        public void WriteFile()
        {
 
        }

        public void CloseFile()
        {
            m_File.Close();
            m_File = null;
        }
    }
}
