namespace jang0426.WINDOWS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Reflection;
    
    public class IOProperty : PropertyUpdate
    {
        private int cnt;
        public int CNT
        {
            get
            {
                return cnt;
            }
            set
            {
                cnt = value;
                string str_cnt = cnt.ToString();
                str_cnt += " ";
                Notify(str_cnt);
            }
        }

    }

}