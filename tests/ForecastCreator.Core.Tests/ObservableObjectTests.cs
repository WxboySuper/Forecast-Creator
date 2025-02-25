using ForecastCreator.Core.Base;
using ForecastCreator.Core.Tests.TestObjects;
using Xunit;

namespace ForecastCreator.Core.Tests;

public class ObservableObjectTests
{
    [Fact]
    public void SetField_WhenValueChanges_RaisesPropertyChanged()
    {
        // Arrange
        var testObject = new TestObservableObject { TestProperty = null };
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
        var testObject = new TestObservableObject { TestProperty = "initial" };
        var propertyChanged = false;
        testObject.PropertyChanged += (s, e) => propertyChanged = true;

        // Act
        testObject.TestProperty = "initial";

        // Assert
        Assert.False(propertyChanged);
    }
}