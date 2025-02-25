using ForecastCreator.Core.Base;
using Xunit;

namespace ForecastCreator.Core.Tests.Base;

public class RelayCommandTests
{
    [Fact]
    public void Execute_CallsActionWithParameter()
    {
        // Arrange
        object? parameter = null;
        var command = new RelayCommand(p => parameter = p);

        // Act
        command.Execute("test");

        // Assert
        Assert.Equal("test", parameter);
    }

    [Fact]
    public void CanExecute_WithNullPredicate_ReturnsTrue()
    {
        // Arrange
        var command = new RelayCommand(_ => { });

        // Act & Assert
        Assert.True(command.CanExecute(null));
    }

    [Fact]
    public void CanExecute_WithPredicate_ReturnsPredicateResult()
    {
        // Arrange
        var command = new RelayCommand(_ => { }, _ => false);

        // Act & Assert
        Assert.False(command.CanExecute(null));
    }
}