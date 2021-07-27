using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaUI.Models
{
    public class MainModel
    {
        SDKLibrary.MainClass _main;

        bool endShow = false;
        public MainModel(SDKLibrary.MainClass main)
        {
            _main = main;
            _main.NewData += (s,e)=> { if (endShow) _main.SendData = false; NewData?.Invoke(s, e); };
        }

        public event EventHandler<SDKLibrary.OutputData> NewData;

        public SDKLibrary.InputData InputData => _main.InputData;

        public void OneData() { endShow = true; _main.SendData = true; }

        public void StreamData() { endShow = false; _main.SendData = !_main.SendData; }

    }
}
