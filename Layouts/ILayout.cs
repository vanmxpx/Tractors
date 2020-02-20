using System.Collections.Generic;
using System.Collections.Immutable;

namespace Tractors.Layouts
{
    public interface ILayout
    {
        // html
        string? advantages_block { get;  }
        string video { get;  }
        bool? disable_main { get;  }
        string? product_name { get;  }
        string? product_id { get;  }
        string s1_bt1 { get;  }
        bool? ukr { get;  }
        //  string | string[];
        ImmutableList<string> this1 { get;  }
        string but_text { get;  } 
        string? but_text_credit { get;  } 
        ImmutableList<string>? this1_credit { get;  }  
        ImmutableList<string> name { get;  }
        string price { get;  }
        string logo { get;  }
        ImmutableList<string> menu { get;  }
        bool? disable_menu { get;  }
        
        Dictionary<string, string>? first_form { get;  }
        object? s3 { get;  }
        string? s1_h1_style { get;  }
        string s1_h1 { get;  }
        string s1_background { get;  }
        string s2_background { get;  }
        string s3_background { get;  }
        string s4_background { get;  }
        string s5_background { get;  }
        string recall_dialog { get;  }
        ImmutableList<string> phone { get;  }
    }
}