using System.Collections.Generic;
using System.Collections.Immutable;

namespace Tractors.Layouts
{
    public interface ILayout
    {
        string ToString();
        string message_thanks { get; }
        string keywords { get; }
        string description { get; }
        string? loc { get; }
        string? email { get; }
        string title { get; }

        List<string> phone { get;  }
        
        List<string>? map { get; }
        
        string recall_dialog { get;  }
        string? popup1_h1 { get; }
        string? popup2_h1 { get; }
        string? popup3_h1 { get; }
        bool? popup1_form_short { get; }
        
        Dictionary<string, string>? popup1_form { get; }
        Dictionary<string, string>? popup2_form { get; }
        Dictionary<string, string>? popup3_form { get; }
        
        string? popup1_header { get; }
        bool? disable_footer { get; }
        string footer_h1 { get; }
        Dictionary<string, string>? fback { get; }
        string s4_title { get; }
        string s3_h1 { get; }
        Dictionary<string, string>? s3_form { get; }
        string? s2_this_bu_title { get; }
        
        string? s2_right_style { get; }
        string? s2_right_title { get; }
        List<string>? s2_this_right { get; }
        string? s2_right_this2_style { get; }
        
        string? s2_left_title { get; }
        string? s2_this_left_but { get; }
        string? s2_left_this2_style { get; }
        List<string>? s2_this_bu { get; }
        
        List<string>? s2_this_left { get; }
        string? but_text_kred { get; }
        // html
        string? advantages_block { get;  }
        string video { get;  }
        bool? disable_main { get;  }
        string? product_name { get;  }
        string? product_id { get;  }
        string s1_bt1 { get;  }
        bool? ukr { get;  }
        //  string | string[];
        List<string> this1 { get;  }
        string but_text { get;  } 
        string? but_text_credit { get;  } 
        List<string>? this1_credit { get;  }  
        List<string> name { get;  }
        string price { get;  }
        string logo { get;  }
        List<string> menu { get;  }
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
    }
}