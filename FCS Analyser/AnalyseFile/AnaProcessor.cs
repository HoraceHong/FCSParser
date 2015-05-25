using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalyseFile
{
    public class AnaProcessor
    {
        private Dictionary<string, IParser> m_AnaComponents = null;

        public AnaProcessor()
        {
            m_AnaComponents = new Dictionary<string, IParser>();
        }

        public void TakeAnalysisAction()
        {
            foreach (IParser component in m_AnaComponents.Values)
            {
                component.ProcessParse();
            }
        }

        public void AddComponent(string strKeyName, IParser iComponentPara)
        {
            if (m_AnaComponents == null)
                return;
            m_AnaComponents.Add(strKeyName, iComponentPara);
        }

        public void DeleteComponent(string strKeyName)
        {
            if (m_AnaComponents == null || m_AnaComponents.Count == 0)
                return;
            m_AnaComponents.Remove(strKeyName);
        }

        public int GetComponentCount()
        {
            return m_AnaComponents.Count;
        }
    }
}
