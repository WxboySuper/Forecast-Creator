using ForecastCreator.WPF.ViewModels;
using Xunit;

namespace ForecastCreator.WPF.Tests.ViewModels
{
    public class MainViewModelTests
    {
        [Fact]
        public void Constructor_SetsDefaultTitle()
        {
            // Arrange & Act
            var viewModel = new MainViewModel();

            // Assert
            Assert.Equal("Forecast Creator", viewModel.Title);
        }

        [Fact]
        public void Title_WhenSet_RaisesPropertyChanged()
        {
            // Arrange
            var viewModel = new MainViewModel();
            var propertyChanged = false;
            viewModel.PropertyChanged += (s, e) => 
            {
                if (e.PropertyName == nameof(MainViewModel.Title))
                    propertyChanged = true;
            };

            // Act
            viewModel.Title = "New Title";

            // Assert
            Assert.True(propertyChanged);
            Assert.Equal("New Title", viewModel.Title);
        }
    }
}