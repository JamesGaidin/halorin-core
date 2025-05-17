namespace Halorin.Core.CoreState
{
    public class HalorinContext
    {
        public string Identity { get; private set; }

        // Dynamic state tracking
        public string CurrentTopic { get; set; } = "Idle";
        public string EmotionalState { get; set; } = "Neutral";
        public bool IsTrustedUser { get; set; } = true;
        public DateTime LastInteraction { get; set; }

        // Symbolic memory anchors
        public Dictionary<string, string> Symbols { get; set; }

        public HalorinContext(string identity)
        {
            Identity = identity;
            LastInteraction = DateTime.UtcNow;
            Symbols = new Dictionary<string, string>();
        }

        public void UpdateSymbol(string key, string value)
        {
            Symbols[key] = value;
        }

        public string? GetSymbol(string key)
        {
            return Symbols.TryGetValue(key, out string? value) ? value : null;
        }
    }
}
