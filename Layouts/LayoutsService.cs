using System.Collections.Generic;
using System.Collections.Immutable;
using Tractors.Layouts.LayoutItems;

namespace Tractors.Layouts
{
    public class LayoutsService
    {
        public static string ReadHtml(string name) 
        {
            return System.IO.File.ReadAllText("./Layouts/LayoutItems/" + name + ".html");
        }
        private readonly ImmutableDictionary<string, ILayout> store;
        public LayoutsService()
        {
            store = new Dictionary<string, ILayout> 
            { 
                { "", new MototraktorKupitV2() }, 
                { "mototraktor_kupit_v2", new MototraktorKupitV2() },
                { "minitraktor_bu_prodat", new MinitraktorBuProdat() },
                { "minitraktor_dostavka", new MinitraktorDostavka() }
            }.ToImmutableDictionary();
        }

        public ILayout FindLayout(string layoutName) 
        { 
            return store[layoutName];
        }
    }
}