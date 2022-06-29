using System.Collections.Generic;

namespace MLearning
{
    public class Topology
    {
        public int InputCount { get; }
        public int OutputCount { get; }
        public List<int> HiddenLayers { get; }
        public Topology(int inputCoint, int outputCount, params int[] layers)
        {
            InputCount = inputCoint;
            OutputCount = outputCount;
            HiddenLayers = new List<int>();
            HiddenLayers.AddRange(layers);
        }
    }
}
