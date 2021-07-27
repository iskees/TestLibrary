using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace AvaloniaUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        Models.MainModel _mainModel;
        Avalonia.Media.Imaging.Bitmap _mainImage;

        public  MainWindowViewModel(Models.MainModel mainModel)
        {
            _mainModel = mainModel;
            _mainModel.NewData += NewData;
            if (_mainModel.InputData.Color == System.Drawing.Color.Red)
                Color = 0;
            if (_mainModel.InputData.Color == System.Drawing.Color.White)
                Color = 1;
        }

        int _color;
        public int Color
        {
            get => _color;
            set{
                if (value == 0)
                    _mainModel.InputData.Color = System.Drawing.Color.Red;
                if (value == 1)
                    _mainModel.InputData.Color = System.Drawing.Color.White;
                this.RaiseAndSetIfChanged(ref _color, value);
            }
        }

        internal void OnMaimImageClick(PointF point)
        {
            _mainModel.InputData.Points.Add(point);
       
        }

        public Avalonia.Media.Imaging.Bitmap MainImage
        {
            get => _mainImage;
            internal set
            {
                if (_mainImage != value)
                {
                    this.RaiseAndSetIfChanged(ref _mainImage, value);
                }
            }
        }

        string _time;
        public string Time
        {
            get => _time;
            set => this.RaiseAndSetIfChanged(ref _time, value);
        }




        public void NewData(object sender, SDKLibrary.OutputData outputData)
        {
            MemoryStream memoryStream = new MemoryStream();
            outputData.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
            memoryStream.Seek(0, SeekOrigin.Begin);
            MainImage = new Avalonia.Media.Imaging.Bitmap(memoryStream);
            memoryStream.Dispose();
            Time = outputData.DateTime.ToLongTimeString();

        }

        public void OneData() { _mainModel.OneData(); }

        public void StreamData() { _mainModel.StreamData(); }
    }
}
