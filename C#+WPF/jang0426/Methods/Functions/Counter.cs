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
    }
}
