# Forecast Creator

A Windows desktop application for creating graphical weather forecasts, with support for offline operations and meteorological data visualization.

## Current Status
- ✅ Initial project setup complete
- ✅ MVVM architecture implemented
- ✅ SkiaSharp graphics library integrated
- 🚧 Base map display (in progress)

## Features (Planned)
- Interactive CONUS map with drawing tools
- Support for multiple data overlays (radar, satellite, mesoanalysis)
- Offline capability with local data storage
- Export forecasts in multiple formats
- Custom drawing tools for weather features

## Technical Stack
- WPF (.NET 8)
- SkiaSharp 2.88.6 for graphics
- MVVM architecture with observable patterns
- C# 12.0

## Project Structure
- `ForecastCreator.Core`: Base libraries and shared components
  - Base MVVM implementations
  - Common interfaces and models
- `ForecastCreator.WPF`: Main WPF application
  - User interface components
  - ViewModels and Views
  - Graphics rendering logic

## Requirements
- Windows 10/11
- .NET 8.0 SDK
- Visual Studio 2022 or VS Code with C# dev kit

## Getting Started
1. Clone the repository
2. Open the solution in Visual Studio/VS Code
3. Restore NuGet packages:
   ```bash
   dotnet restore
   ```
4. Build and run:
    ```bash
    dotnet build
    dotnet run -- project src/ForecastCreator.WPF
    ```

## Contributing
See CONTRIBUTING.md for development guidelines.
