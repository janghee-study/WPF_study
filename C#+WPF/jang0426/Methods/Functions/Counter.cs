namespace jang0426.WINDOWS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Counter : PropertyUpdate
    {

        public void Upcount()
        {
            int total;
            if (Vars._viewmodel.CNT != null) {

                total = int.Parse(Vars._viewmodel.CNT);
                total++;
                Vars._viewmodel.CNT = total.ToString();

            }
        }
        
        public void Ratecaluration()
        {
            float rate = float.Parse(Vars._viewmodel.poor_CNT) / float.Parse(Vars._viewmodel.CNT);
            rate *= 100;
            string str_rate = rate.ToString();
            //Vars._viewmodel.lose_RATE = rate.ToString();
            Vars._viewmodel.lose_RATE = string.Format("{0:0.00} ", float.Parse(str_rate));
        }

    }
}
