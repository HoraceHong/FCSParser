using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalyseFile
{
    public interface IParser
    {
        void Install(string strParaContent);
        void ProcessParse();
        Dictionary<string, string> GetOutput();
    }
}
