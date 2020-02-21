using System.Collections.Generic;
using System.Collections.Immutable;

namespace Tractors.Layouts.LayoutItems
{
    public static class SharedItems
    {
        public static readonly List<string> phone = new List<string>() {
			"<span class='binct-phone-number-1'><span class='part-phone'>976-01-05</span></span>",
			"<span class='binct-phone-number-2'>+38&nbsp(050) <span class='part-phone'>976-01-05</span></span>",
			"<span class='binct-phone-number-3'>+38&nbsp(073) <span class='part-phone'>976-01-05</span></span>",
			"&nbsp<span class='part-phone'>&nbsp</span>",
			"",
			"",
        };
        public static readonly string email = "info.tdtz@gmail.com";

        public static readonly List<string> map = new List<string>() {
            "48.409050", 
            "34.998631"
        };

        public static readonly string loc = "Украина, г. Днепр, <br> ул. Краснопольская 9";
    }
}