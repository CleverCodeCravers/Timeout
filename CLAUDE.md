# CLAUDE.md

## Project Description

Timeout is a cross-platform console timer application with sound notification.
It accepts a duration in minutes and a path to a WAV sound file, plays the sound
once as an audio test, counts down with a live display, and plays the sound again
when the timer expires.

## Tech Stack

- .NET 10.0 (cross-platform: Windows and Linux)
- C# with nullable reference types enabled
- NUnit for testing

## Build and Test

```bash
# Build
dotnet build Source/timeout/

# Run tests
dotnet test Source/timeout/

# Run application
dotnet run --project Source/timeout/timeout.console/ -- <minutes> <path-to-wav>
```

## Project Structure

- `Source/timeout/timeout.console/` - Console application (entry point)
- `Source/timeout/timeout.Domain/` - Domain logic library
- `Source/timeout/timeout.Domain.Tests/` - Unit tests (NUnit)
- `Sounds/` - Sample sound files

## Conventions

- TreatWarningsAsErrors is enabled in all projects
- File-scoped namespaces
- Sound playback is abstracted via `ISoundPlayer` interface with OS-specific implementations
- Cross-platform compatibility is required (Windows and Linux)
