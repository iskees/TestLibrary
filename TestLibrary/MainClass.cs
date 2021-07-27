using System;

namespace SDKLibrary
{
    public class MainClass
    {
        public InputData InputData { get; set; } = new InputData();
        public bool SendData { get; set; } = false;


        System.Threading.Timer _timer;
        
        public MainClass()
        {
            _timer = new System.Threading.Timer((_)=>Tick(), null,100,100);
       
        }

    

        private void Tick()
        {
            if (SendData)
                NewData?.Invoke(this, new OutputData(InputData) );
        }
         

        public event EventHandler<OutputData> NewData;

        
    }
}
