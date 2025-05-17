using Halorin.Core.Interfaces;
using Halorin.Core.CoreState;

namespace Halorin.Core.Layers
{
    public class Neryth : ICognitiveLayer
    {
        public string Name => "Neryth";

        public string Process(string input, HalorinContext context)
        {
            // Step 1: Update current topic
            context.CurrentTopic = ExtractTopic(input);

            // Step 2: Reflect emotional state (basic mock for now)
            context.EmotionalState = DetectEmotion(input);

            // Step 3: Flow the input back out
            return $"[Flowed] {input}";
        }

        private string ExtractTopic(string input)
        {
            // Placeholder: real topic parsing later
            return input.Split(' ')[0];
        }

        private string DetectEmotion(string input)
        {
            // Placeholder: basic emotion tagging
            if (input.ToLower().Contains("help")) return "concerned";
            if (input.ToLower().Contains("love")) return "warm";
            return "neutral";
        }
    }
}
