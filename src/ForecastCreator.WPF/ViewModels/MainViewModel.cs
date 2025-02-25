using ForecastCreator.Core.Base;

namespace ForecastCreator.WPF.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private string _title = "Forecast Creator";
        public string Title
        {
            get => _title;
            set => SetField(value, ref _title);
        }
    }
}