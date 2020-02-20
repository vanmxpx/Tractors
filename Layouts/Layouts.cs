using System.Collections.Generic;
using System.Collections.Immutable;
using Tractors.Layouts.LayoutItems;

namespace Tractors.Layouts
{
    public class LayoutsService
    {
        private readonly ImmutableDictionary<string, ILayout> store;
        public LayoutsService()
        {
            store = new Dictionary<string, ILayout> 
            { 
                { "", new MototraktorKupit() }, 
                { "mototraktor_kupit_v2", new MototraktorKupit() }, 
            }.ToImmutableDictionary();
        }
    }
}