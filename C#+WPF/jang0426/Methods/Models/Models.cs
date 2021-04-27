namespace jang0426.WINDOWS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Reflection;
    using System.Windows.Threading;
    using System.Windows;

    public class ViewModels : PropertyUpdate
    {
        //COUNT
        private string cnt = "0";
        public string CNT
        {
            get
            {
                return cnt;
            }
            set
            {
                cnt = value;

                var Method = MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                Notify(Method);
            }
        }
        
        private string good_cnt = "0";
        public string good_CNT
        {
            get
            {
                return good_cnt;
            }
            set
            {
                good_cnt = value;
                var Method = MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                Notify(Method);
            }
        }

        private string poor_cnt = "0";
        public string poor_CNT
        {
            get
            {
                return poor_cnt;
            }
            set
            {
                poor_cnt = value;
                var Method = MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                Notify(Method);
            }
        }

        private string lose_rate = "0";
        public string lose_RATE
        {
            get
            {
                return lose_rate;
            }
            set
            {
                lose_rate = value;
                var Method = MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                Notify(Method);
            }
        }


        //STABLE
        private string pass_stable = "S T A B L E";
        public string pass_STABLE
        {
            get
            {
                return pass_stable;
            }
            set
            {
                pass_stable = value;
                var Method = MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                Notify(Method);
            }
        }
        

        //FILEPATH
        private string file_name;
        public string file_NAME
        {
            get
            {
                return file_name;
            }
            set
            {
                file_name = value;
                var Method = MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                Notify(Method);
            }
        }

        private string file_path;
        public string file_PATH
        {
            get
            {
                return file_path;
            }
            set
            {
                file_path = value;
                var Method = MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                Notify(Method);
            }
        }


        //VOLT
        private string volt_level = "0.0";
        public string volt_LEVEL
        {
            get
            {
                return volt_level;
            }
            set
            {
                volt_level = value;
                var Method = MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                Notify(Method);
            }
        }

        //VOLT
        private string speed_level = "0.0";
        public string speed_LEVEL
        {
            get
            {
                return speed_level;
            }
            set
            {
                speed_level = value;
                var Method = MethodBase.GetCurrentMethod().Name.Replace("set_", "");
                Notify(Method);
            }
        }

    }
}
