namespace jang0426.WINDOWS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Windows;
    using System.Windows.Input;

    public class Volt : PropertyUpdate
    {
        public void TypeConfirm_VOLT()
        {
            float voltCut = float.Parse(Vars._viewmodel.volt_LEVEL);

            if (voltCut > 15.0)
            {
                System.Windows.MessageBox.Show("Volt High");
            }
            else if(voltCut < 0.5)
            {
                System.Windows.MessageBox.Show("Volt Low");
            }
            else
            {
                System.Windows.MessageBox.Show("Volt Good");
            }

        }

        public void TypeConfirm_SPEED()
        {
            float speedCut = float.Parse(Vars._viewmodel.speed_LEVEL);

            if (speedCut > 25.0)
            {
                System.Windows.MessageBox.Show("Speed High");
            }
            else if (speedCut < 5.0)
            {
                System.Windows.MessageBox.Show("Speed Low");
            }
            else
            {
                System.Windows.MessageBox.Show("Speed Good");
            }

        }

    }
}
