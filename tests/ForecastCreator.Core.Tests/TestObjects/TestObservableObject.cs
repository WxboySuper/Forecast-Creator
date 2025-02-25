using ForecastCreator.Core.Base;

namespace ForecastCreator.Core.Tests.TestObjects;
{
    public class TestObservableObject : ObservableObject
    {
        private string? _testProperty;
        public string? TestProperty
        {
            get => _testProperty;
            set => SetField(value, ref _testProperty);
        }
    }
}
