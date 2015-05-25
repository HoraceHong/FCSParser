using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalyseFile
{
    public class Header : IParser
    {
        enum KeyWord
        {
            Version = 0,
            TextStartPos,
            TextEndPos,
            DataStartPos,
            DataEndPos,
            AnalysisStartPos,
            AnalysisEndPos,
            OtherPos
        }
        List<int[,]> lstPosArray = new List<int[,]>();    

        private Dictionary<int, string> m_KeyPairValue;

        public Header()
        {
            int[,] temp = new int[0, 5];
            lstPosArray.Add(temp);
            temp = new int[6, 9];
            lstPosArray.Add(temp);

        }

        public void Install(string strParaContent)
        {
 
        }
        public void ProcessParse()
        { 

        }
        public Dictionary<string, string> GetOutput()
        {
            return null;
        }
    }
}
