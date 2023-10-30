using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace NextPlayGround
{
    public class MyPickerPageViewModel : INotifyPropertyChanged
    {
        public ICommand DoPickerCommand { get; set; }
        public ICommand DoLabelCommand { get; set; }

        public MyPickerPageViewModel()
        {
            DoPickerCommand = new Command(DoPicker);
            DoLabelCommand = new Command(DoLabel);
        }

        private void DoLabel(object obj)
        {
            App.Current.MainPage.DisplayAlert("label Tapped", "Label was tapped with XCT", "Ok");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void DoPicker(object obj)
        {
            App.Current.MainPage.DisplayAlert("Picker Tapped", "Picker was tapped", "Ok");
        }
    }
}
