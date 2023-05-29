# Timeout

A timer application that will play a sound after a specified time is up.

## Requirements

- This is a console application.
- The application gets two command line parameters:
    - The duration of the countdown timer in minutes.
    - The path to the sound file that it should play when finished. (The application supports the wav format.)

1. The application will play the sound. (That is a test if the audio works properly. You might want to adjust your headphones.)
2. It will then show the remaining time in a loop (incl. seconds). The output will remain on one line so that the console output does not need to scroll.
3. When the time is up the application will play the sound again.

- The application should be able to run on windows and linux alike.

- Everything that has to do with playing the sound should be encapsulated in separate classes.
- The implementation for windows and linux should both be derived from an interface ISoundPlayer .
- The implementations of ISoundPlayer should for each operating system check if the necessary tools that you use for playback are available and if not give installation hints.
- The program should select the appropriate implementation for the operating system it is working on right now.

- Please remember: You are using dotnet , not the .Net Framework, as you need to be cross platform compatible.


## Sound 

### Gong Sound

This project uses a gong sound by Daniel Simon, licensed under CC BY 3.0:

- Gong sound by Daniel Simon is licensed under Attribution 3.0.
- Source: [Gong Sound](https://soundbible.com/2148-Chinese-Gong.html)
- License: [CC BY 3.0](https://creativecommons.org/licenses/by/3.0/)

