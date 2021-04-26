namespace jang0426.WINDOWS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Forms;

    public class Filemethods : PropertyUpdate
    {

        public void OpenMethod(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            dlgOpenFile.Filter = "Image Files (*.jpg, *.png) | *.jpg; *.png; | All files (*.*) | *.*";

            if (dlgOpenFile.ShowDialog().ToString() == "OK")
            {
                Vars._viewmodel.file_PATH = dlgOpenFile.FileName;
                System.Windows.MessageBox.Show(Vars._viewmodel.file_PATH);
            }
            throw new NotImplementedException();
        }
    }
}
