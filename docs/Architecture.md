# Architecture Overview

## MVVM Implementation
- `ObservableObject`: Base class for implementing INotifyPropertyChanged
- `RelayCommand`: ICommand implementation for view-model commands
- `MainViewModel`: Primary view model managing application state

## Project Structure
### Core Library (ForecastCreator.Core)
- Base /
    - ObservableObject.cs
    - RelayCommand.cs
- Models/ (planned)
- Services/ (planned)

### WPF Application (ForecastCreator.WPF)
- ViewModels/
    - MainViewModel.cs
- Views/ (planned)
- Controls/ (planned)

## Dependencies
- SkiaSharp (2.88.6)
- SkiaSharp.Views.WPF (2.88.6)
- .NET 8.0 Windows Desktop Runtime

## Design Decisions
1. MVVM Pattern
    - Separation of concerns
    - Testable view models
    - Data binding support

2. SkiaSharp Graphics
    - Cross-platform capability
    - High-performance 2D graphics
    - Hardware acceleration support