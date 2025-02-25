# Forecast Creator Roadmap

## Phase 1 - Foundation (Current)
- [x] Setup GitHub Repository
- [x] Initialize WPF project structure
- [x] Setup basic MVVM architecture
- [x] Configure SkiaSharp integration
- [ ] Implement base CONUS map display
- [ ] Basic drawing infrastructure with SkiaSharp

## Phase 2 - Core Features
- [ ] Implement drawing tools
  - [ ] Freehand drawing
  - [ ] Polygons/shapes
  - [ ] Text annotations
  - [ ] Contours
- [ ] Layer management system
- [ ] Save/load forecasts (JSON)
- [ ] Basic export functionality (PNG, KML)

## Phase 3 - Weather Data Integration
- [ ] Basic radar/satellite data plotting
- [ ] Mesoanalysis data support
  - [ ] NetCDF/GRIB2 file handling
  - [ ] Data visualization layers
- [ ] Weather report overlays
- [ ] Layer customization (opacity, colors)

## Phase 4 - User Experience
- [ ] Enhanced UI controls
- [ ] Tool presets and customization
- [ ] Map navigation (zoom, pan)
- [ ] Layer manager interface
- [ ] Quick access toolbar

## Phase 5 - Offline Capabilities
- [ ] Local data storage system
- [ ] Cached base maps
- [ ] Manual data import support
- [ ] Offline mode toggle

## Future Extensions
### Game Mode Concept
- Reanalysis-based forecast challenges
- Scoring system based on verification
- Multiple forecast periods (12z, 16:30z, 20z, 01z)
- Chase simulation mode