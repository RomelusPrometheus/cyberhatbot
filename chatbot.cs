using System;
using System.Collections.Generic;

class Chatbot
{
    public static void StartChat()
    {
        Console.Write("What is your name? ");
        Console.ForegroundColor = ConsoleColor.Red;
        string userName = Console.ReadLine();
        Console.ResetColor();

        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.WriteLine("Please enter a valid name.");
            Console.Write("What is your name? ");
            Console.ForegroundColor = ConsoleColor.Red;
            userName = Console.ReadLine();
            Console.ResetColor();
        }

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nAI Bot: Hello, {userName}! I'm your Cybersecurity Assistant. I'm here to help you stay safe online. 🔒\n");
        Console.ResetColor();

        Console.WriteLine("You can ask me questions like:");
        Console.WriteLine("🔹 What is phishing?");
        Console.WriteLine("🔹 How do I create a strong password?");
        Console.WriteLine("🔹 How can I recognize a scam email?");
        Console.WriteLine("🔹 What should I do if my account gets hacked?");
        Console.WriteLine("🔹 Type 'exit' to leave the chat.\n");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nYou: ");
            string userInput = Console.ReadLine()?.ToLower();
            Console.ResetColor();

            if (userInput == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nAI Bot: Goodbye! Stay safe online. 👋");
                Console.ResetColor();
                break;
            }

            string[] questions = userInput.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var question in questions)
            {
                string trimmedQuestion = question.Trim();
                string response = GetResponse(trimmedQuestion);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"AI Bot: {response}");
                Console.ResetColor();
            }
        }
    }

    private static string GetResponse(string userInput)
    {
        Dictionary<string, string> responses = new Dictionary<string, string>
        {
            { "how are you", "I'm just a bot, but I'm here to help you stay safe! My purpose is to provide you with information and tips on cybersecurity." },
            { "what's your purpose", "I help educate users about cybersecurity and how to stay safe online. My goal is to empower you with knowledge to protect yourself." },
            { "what is phishing", "Phishing is a cyber-attack where hackers trick you into revealing personal information by pretending to be someone you trust. They often use emails or messages that look legitimate to lure you into providing sensitive data." },
            { "how do i create a strong password", "To create a strong password, use at least 12 characters and mix uppercase & lowercase letters, numbers, and special symbols. Avoid using easily guessable information like birthdays or common words. A strong password is your first line of defense!" },
            { "how can i recognize a scam email", "To recognize a scam email, look for poor grammar, urgent requests, suspicious links, and email addresses that don’t match the official domain. Always verify the sender's identity before clicking on any links or providing information." },
            { "what should i do if my account gets hacked", "If your account gets hacked, immediately change your password and enable two-factor authentication. Check for unauthorized activity and consider notifying your contacts to prevent further issues." },
            { "how do i know if a website is safe", "To determine if a website is safe, check if the URL starts with 'https://' and look for a padlock icon in the address bar. Be cautious of sites that look suspicious or ask for personal information unnecessarily." },
            { "what is social engineering", "Social engineering is a technique hackers use to manipulate people into giving up confidential information by pretending to be someone they trust. It often involves psychological tricks to exploit human behavior." },
            { "how can i protect myself from malware", "To protect yourself from malware, avoid downloading files from unknown sources, keep your software updated, and use a trusted antivirus program. Regularly scanning your devices can also help catch threats early." },
            { "how do i enable two-factor authentication", "To enable two-factor authentication, go to your account settings, find the 'Security' or '2FA' section, and follow the steps to link it with an authenticator app or SMS verification. This adds an extra layer of security to your accounts." },
            { "what are common cyber threats", "Common cyber threats include phishing, malware, ransomware, identity theft, and social engineering attacks. Being aware of these threats is crucial for protecting your personal information." }
        };

        foreach (var question in responses.Keys)
        {
            if (userInput.Contains(question))
            {
                return responses[question];
            }
        }

        return "Hmm... I’m not sure about that. Can you try asking in a different way?";
    }
}
