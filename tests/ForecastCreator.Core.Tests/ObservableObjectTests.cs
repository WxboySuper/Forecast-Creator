using ForecastCreator.Core.Base;
using Xunit;

namespace ForecastCreator.Core.Tests.Base
{
    public class ObservableObjectTests
    {
        [Fact]
        public void SetField_WhenValueChanges_RaisesPropertyChanged()
        {
            // Arrange
            var testObject = new TestObservableObject();
            var propertyChanged = false;
            testObject.PropertyChanged += (s, e) => propertyChanged = true;

            // Act
            testObject.TestProperty = "new value";

            // Assert
            Assert.True(propertyChanged);
        }

        [Fact]
        public void SetField_WhenValueIsSame_DoesNotRaisePropertyChanged()
        {
            // Arrange
            var testObject = new TestObservableObject();
            testObject.TestProperty = "initial";
            var propertyChanged = false;
            testObject.PropertyChanged += (s, e) => propertyChanged = true;

            // Act
            testObject.TestProperty = "initial";

            // Assert
            Assert.False(propertyChanged);
        }
    }

    public class TestObservableObject : ObservableObject
    {
        private string _testProperty = "";
        public string TestProperty
        {
            get => _testProperty;
            set => SetField(ref _testProperty, value);
        }
    }
}