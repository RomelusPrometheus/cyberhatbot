# Cybersecurity Awareness Chatbot

## Overview

This project is a **Cybersecurity Awareness Chatbot** developed in C#. The chatbot educates users on cybersecurity best practices, answering questions about online safety, phishing, strong passwords, scam emails, malware protection, and more.

The program also features:

- **Text-based chatbot interaction**: The user communicates with the bot via the console.
- **ASCII Art Rendering**: Converts an image to ASCII art using bitmap processing.
- **Audio Greeting**: Plays a greeting sound when the chatbot starts.

---

## Features

### 1. Chatbot Functionality

- The chatbot interacts with the user and responds to cybersecurity-related queries.
- It provides predefined responses for common cybersecurity topics.
- Uses a dictionary to store and retrieve responses.

### 2. ASCII Art Rendering

- Converts an image into ASCII art using pixel intensity to determine ASCII characters.
- Uses `Bitmap` and `Color` classes to process the image.
- The ASCII art is displayed in the console.

### 3. Sound Playback

- The chatbot plays a greeting audio file (`greeting.wav`) upon startup.
- Uses the `System.Media.SoundPlayer` class to play the sound file.

---

## File Structure

```
CybersecurityChatbot/
│-- bin/Debug/         (Executable files)
│-- OIP.jpg            (Image used for ASCII conversion)
│-- greeting.wav       (Audio greeting file)
│-- Program.cs         (Entry point for running the chatbot)
│-- Chatbot.cs         (Contains chatbot logic and responses)
│-- Utils.cs           (Handles ASCII conversion and audio playback)
│-- README.md          (This file)
```

---

## Installation & Setup

### Prerequisites

Ensure you have:

- **.NET SDK installed** (for running C# applications)
- A **C# IDE** (Visual Studio, JetBrains Rider, or VS Code with C# extension)

### Steps to Run

1. **Clone the repository** or download the source code.
2. Place `OIP.jpg` and `greeting.wav` in the project root.
3. Open the project in **Visual Studio**.
4. Build and run the project.

Alternatively, you can run the executable in the `bin/Debug` folder after building the project.

---

## How It Works

### **Chatbot Interaction**

- The program prompts the user for their name.
- It provides a list of cybersecurity-related questions.
- The user enters a question, and the chatbot responds accordingly.
- If an unrecognized question is entered, the bot suggests rephrasing.

### **ASCII Art Rendering**

- The `DisplayAsciiArt()` function reads an image and converts it into ASCII characters.
- The ASCII art is displayed in the console upon execution.

### **Audio Greeting**

- The `PlayGreeting()` method loads and plays `greeting.wav` upon chatbot startup.
- If the file is missing or inaccessible, an error message is displayed.

---

## Customization

### Adding More Responses

To add more responses, update the `responses` dictionary in `Chatbot.cs`:

```csharp
responses.Add("how do I avoid phishing scams", "Be cautious of suspicious emails and never click unknown links!");
```

### Changing the ASCII Image

Replace `OIP.jpg` with another image and ensure it is in the correct format. Modify the ASCII conversion logic in `Utils.cs` if needed.

### Modifying the Audio File

Replace `greeting.wav` with a new audio file. Ensure it has the same name or update the path in `Utils.cs`.

---

## Future Enhancements

- Implement **Machine Learning** for dynamic responses.
- Add a Graphical User Interface (GUI).
- Integrate **text-to-speech** functionality.

---

## Author

[Rashokeng Romello Molokomme] - Cybersecurity & Software Development Enthusiast.

🚀 Stay safe online!

