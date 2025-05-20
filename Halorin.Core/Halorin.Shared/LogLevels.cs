namespace Halorin.Shared
{
    public class Loglevels
    {
        public string Identity { get; protected set; }

        // Dynamic state tracking
        public string CurrentTopic { get; set; } = "Idle";
        public string EmotionalState { get; set; } = "Neutral";
        public bool IsTrustedUser { get; set; } = true;
        public DateTime LastInteraction { get; set; }
        public enum LogLevel
        {
            None,
            Production,
            Debug,
            DeepTrace
        }
        public LogLevel CurrentLogLevel { get; set; } = LogLevel.Production;

        // Symbolic memory anchors
        public Dictionary<string, string> Symbols { get; set; }

    }
}
