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
        private string cnt;
        public string CNT
        {
            get
            {
                return cnt;
            }
            set
            {
                cnt = value;
                
                //이름을 불러와야함
                Notify(CNT);
            }
        }
        
        private string good_cnt;
        public string good_CNT
        {
            get
            {
                return good_cnt;
            }
            set
            {
                good_cnt = value;
                Notify(good_CNT);
            }
        }

        private string poor_cnt;
        public string poor_CNT
        {
            get
            {
                return poor_cnt;
            }
            set
            {
                poor_cnt = value;
                Notify(good_CNT);
            }
        }


        private string lose_rate;
        public string lose_RATE
        {
            get
            {
                return lose_rate;
            }
            set
            {
                int rate;
                rate = Int32.Parse(good_cnt) / Int32.Parse(poor_cnt);
                lose_rate = rate.ToString();
                Notify(lose_RATE);
            }
        }

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
                Notify(file_NAME);
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
                Notify(file_PATH);
            }
        }

    }
}
