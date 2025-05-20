using Halorin.Shared;

namespace Halorin.Core.CoreState
{
    public class HalorinContext : Loglevels
    {

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
        public void SetLogLevel(string mode)
        {
            switch (mode.Trim().ToLower())
            {
                case "none":
                    CurrentLogLevel = LogLevel.None;
                    break;
                case "prod":
                case "production":
                    CurrentLogLevel = LogLevel.Production;
                    break;
                case "debug":
                    CurrentLogLevel = LogLevel.Debug;
                    break;
                case "trace":
                case "deep":
                case "deeptrace":
                    CurrentLogLevel = LogLevel.DeepTrace;
                    break;
                default:
                    Console.WriteLine($"[WARN] Unknown log level '{mode}', defaulting to Production.");
                    CurrentLogLevel = LogLevel.Production;
                    break;
            }
        }
    }
}
