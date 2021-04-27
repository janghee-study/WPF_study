namespace jang0426.WINDOWS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Threading;
    using System.Xml;
    using System.ComponentModel;
    using System.Drawing;
    

    //Vars 싱글톤 디자인패턴으로 묶음
    static class Vars
    {
        
        static public Filemethods _filemethods = new Filemethods();
        static public Counter _counter = new Counter();
        static public Testcheck _testcheck = new Testcheck();
        static public ViewModels _viewmodel = new ViewModels();
        static public Volt  _volt = new Volt();

        
    }
}