using Halorin.Core.CoreState;

namespace Halorin.Core.Interfaces
{
    public interface ICognitiveLayer
    {
        /// <summary>
        /// The symbolic name of this layer (e.g., Neryth, Selvarien, etc.)
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Core function that processes input and returns the transformed output.
        /// </summary>
        string Process(string input, HalorinContext context);
    }
}
