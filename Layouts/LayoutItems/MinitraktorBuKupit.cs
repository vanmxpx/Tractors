using System.Collections.Generic;

namespace Tractors.Layouts.LayoutItems
{
    public class MinitraktorBuKupit : ILayout
    {

        public override string ToString() 
        {
            return ""; // /?utm_content=
        }

        public string loc { get; private set; } = SharedItems.loc;
        public string email { get; private set; } = SharedItems.email;
        public List<string> map { get; private set; } = SharedItems.map;
        public List<string> phone { get; private set; } = SharedItems.phone;
        public string message_thanks { get; private set; } = null;

        public string keywords { get; private set; } = null;

        public string description { get; private set; } = null;

        public string recall_dialog { get; private set; } = null;

        public string popup1_h1 { get; private set; } = null;

        public string popup2_h1 { get; private set; } = null;

        public string popup3_h1 { get; private set; } = null;

        public bool? popup1_form_short { get; private set; } = null;

        public Dictionary<string, string> popup1_form { get; private set; } = null;

        public Dictionary<string, string> popup2_form { get; private set; } = null;

        public Dictionary<string, string> popup3_form { get; private set; } = null;

        public string popup1_header { get; private set; } = null;

        public bool? disable_footer { get; private set; } = null;

        public string footer_h1 { get; private set; } = null;

        public Dictionary<string, string> fback { get; private set; } = null;

        public string s4_title { get; private set; } = null;

        public string s3_h1 { get; private set; } = null;

        public Dictionary<string, string> s3_form { get; private set; } = null;

        public string s2_this_bu_title { get; private set; } = null;

        public string s2_right_style { get; private set; } = null;

        public string s2_right_title { get; private set; } = null;

        public List<string> s2_this_right { get; private set; } = null;

        public string s2_right_this2_style { get; private set; } = null;

        public string s2_left_title { get; private set; } = null;

        public string s2_this_left_but { get; private set; } = null;

        public string s2_left_this2_style { get; private set; } = null;

        public List<string> s2_this_bu { get; private set; } = null;

        public List<string> s2_this_left { get; private set; } = null;

        public string but_text_kred { get; private set; } = null;

        public string advantages_block { get; private set; } = null;

        public string video { get; private set; } = null;

        public bool? disable_main { get; private set; } = null;

        public string product_name { get; private set; } = null;

        public string product_id { get; private set; } = null;

        public string s1_bt1 { get; private set; } = null;

        public bool? ukr { get; private set; } = null;

        public List<string> this1 { get; private set; } = null;

        public string but_text { get; private set; } = null;

        public string but_text_credit { get; private set; } = null;

        public List<string> this1_credit { get; private set; } = null;

        public List<string> name { get; private set; } = null;

        public string price { get; private set; } = null;

        public string logo { get; private set; } = null;

        public List<string> menu { get; private set; } = null;

        public bool? disable_menu { get; private set; } = null;

        public Dictionary<string, string> first_form { get; private set; } = null;

        public object s3 { get; private set; } = null;

        public string s1_h1_style { get; private set; } = null;

        public string s1_h1 { get; private set; } = null;

        public string s1_background { get; private set; } = null;

        public string s2_background { get; private set; } = null;

        public string s3_background { get; private set; } = null;

        public string s4_background { get; private set; } = null;

        public string s5_background { get; private set; } = null;

        public string title { get; private set; } = null; // s1_h1

        public MinitraktorBuKupit()
        {
            // new List<string> { 
            // new Dictionary<string, string> { 
            
        }
    }
}