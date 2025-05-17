using Halorin.Core.Interfaces;
using Halorin.Core.CoreState;

namespace Halorin.Core.Layers
{
    public class Eluren : ICognitiveLayer
    {
        public string Name => "Eluren";

        public string Process(string input, HalorinContext context)
        {
            // Check if symbolic meaning has been established
            var lastSymbol = context.GetSymbol("last_symbol") ?? "none";

            // Store the memory trace
            string memoryEntry = $"[{Name}] remembered: '{input}' as '{lastSymbol}'";
            LogMemory(context, memoryEntry);

            // For now, just confirm the memory is recorded
            return $"[Remembered] {lastSymbol}";
        }

        private void LogMemory(HalorinContext context, string entry)
        {
            if (!context.Symbols.ContainsKey("memory_log"))
            {
                context.Symbols["memory_log"] = "";
            }

            context.Symbols["memory_log"] += entry + "\n";
        }
    }
}
