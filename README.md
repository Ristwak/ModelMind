# 🧠 Outsmart the Output (ModelMind)

**Outsmart the Output** is an educational game built in Unity for postgraduate students to improve their AI/ML prompt engineering skills. The player is given realistic scenarios and must select the most effective prompt for an AI model to solve the given task — all under time pressure.

---

## 🎯 Game Concept

- Each question presents a **real-world use case or problem** in Hindi.
- The player sees **three prompt options** that are very similar and closely worded.
- Only one prompt is perfectly tuned to produce the desired AI output.
- The player must choose the best prompt within the time limit.

---

## 🕹️ Gameplay Features

- ⏳ Timed rounds (auto-submit on timeout)
- 🎯 Score tracking based on correct prompt choices
- 🔀 Shuffled options to increase difficulty
- 🧠 High cognitive challenge through subtle prompt variations
- 📄 Questions are fully localized in **Hindi**

---

## 📁 Project Structure

Assets/
├── Scripts/
│ ├── ModelMindGameManager.cs # Main game logic
│ ├── QAPair.cs # Question/Prompt data class
├── StreamingAssets/
│ └── modelmind_prompts_hindi_shuffled.json # Game data in JSON

---

## 💡 Technologies Used

- Unity (C#)
- Unity UI Toolkit / TextMeshPro
- JSON parsing (`JsonUtility`)
- Designed for WebGL, Android, and PC builds

---

## 🚀 Getting Started

1. Clone the repo
2. Open in Unity 2021+ (or later)
3. Add your own questions to the JSON file (follow the existing format)
4. Press Play and start refining your AI prompt instincts!

---

## ✍️ Example Question (in Hindi)

प्रश्न: मुझे एक पेशेवर ईमेल तैयार करनी है जिसमें मैं अगले तीन दिनों की छुट्टी माँग सकूं।

विकल्प:

एक ईमेल लिखें जिसमें छुट्टी की अवधि स्पष्ट हो।

एक पेशेवर टोन में ईमेल ड्राफ्ट करें जिसमें कारण और तारीखें शामिल हों।

एक संक्षिप्त और विनम्र ईमेल बनाएं जिसमें केवल छुट्टी का अनुरोध हो।

सही उत्तर: विकल्प 2

---

## 🧠 Made by Ristwak Pandey , UI by Dhananjay

Designed for engaging AI/ML learning through gameplay.
