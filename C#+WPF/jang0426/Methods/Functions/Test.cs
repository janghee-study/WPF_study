namespace jang0426.WINDOWS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Testcheck : PropertyUpdate
    {

        //레시피(테스트조건(이))가 존재한다면 조건 맞춤
        public void CHECK()
        {
            Random rand = new Random();
            int seed = rand.Next();

            if ((seed % 2) != 0)
            {
                if (Vars._viewmodel.good_CNT != null)
                {
                    int good = int.Parse(Vars._viewmodel.good_CNT);
                    good++;

                    Vars._viewmodel.good_CNT = good.ToString();
                    Vars._viewmodel.pass_STABLE = "P A S S";
                }
            }
            else
            {
                if (Vars._viewmodel.poor_CNT != null)
                {
                    int poor = int.Parse(Vars._viewmodel.poor_CNT);
                    poor++;

                    Vars._viewmodel.poor_CNT = poor.ToString();
                    Vars._viewmodel.pass_STABLE = "F A I L";
                }
            }
        }
    }
}
