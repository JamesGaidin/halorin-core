using System.Collections.Generic;
using Halorin.Core.CoreState;
using Halorin.Core.Interfaces;
using Halorin.Core.Layers;  // 👈 This is the one you just added

namespace Halorin.Core.Core
{
    public class CompanionMind
    {
        public string Identity { get; private set; }
        public HalorinContext Context { get; private set; }
        public List<ICognitiveLayer> Layers { get; private set; }

        public CompanionMind(string identity)
        {
            Identity = identity;
            Context = new HalorinContext(identity);
            Layers = new List<ICognitiveLayer>
                {
                    new Neryth(),
                    new Selvarien(),
                    new Eluren(),
                    new Calareth(),
                    new Anelara(),
                    new Ivenae()
                };
        }

        public string ProcessInput(string input)
        {
            string currentThought = input;

            foreach (var layer in Layers)
            {
                currentThought = layer.Process(currentThought, Context);
            }

            return currentThought;
        }
    }
}
