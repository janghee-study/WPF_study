namespace jang0426.WINDOWS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Testcheck : PropertyUpdate
    {

        //레시피가 존재한다면 조건 맞춤
        public void CHECK()
        {
            Random rand = new Random();
            int seed = rand.Next();

            if (seed / 2 != 1)
            {
                if (Vars._viewmodel.good_CNT != null)
                {
                    int good = int.Parse(Vars._viewmodel.good_CNT);
                    good++;

                    Vars._viewmodel.good_CNT.ToString();

                }
            }
            else
            {
                if (Vars._viewmodel.poor_CNT != null)
                {
                    int poor = int.Parse(Vars._viewmodel.poor_CNT);
                    poor++;

                    Vars._viewmodel.poor_CNT.ToString();
                    
                }
            }
        }
        
    }
}
