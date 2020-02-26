using System.Collections.Generic;

namespace Tractors.Layouts.LayoutItems
{
    public class MinitraktorBuProdat : ILayout
    {

        public override string ToString()
        {
            return "minitraktor_bu_prodat";
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

        public MinitraktorBuProdat()
        {

            // new List<string> { 
            // new Dictionary<string, string> { 
            name = new List<string> { "б/у минитрактор", "минитрактора б/у", "б/у минитракторы", "минитракторов б/у"};

		price = "61 835";

		logo = "images/logo.png";
		// mexicano = "Студия HC Landing Page Mexicano";


		title = "ХОТИТЕ ВЫГОДНО ПРОДАТЬ МИНИТРАКТОР? Купим ваш минитрактор с пробегом на выгодных условиях";
		keywords = "Купить "+ name[0] +"";
		description = "Купить "+ name[0] +"";
		s1_h1 = "ХОТИТЕ ВЫГОДНО ПРОДАТЬ <br> МИНИТРАКТОР ?<br> <span class='mini-t'> Купим ваш минитрактор с пробегом <br> на выгодных условиях </span>";
		s1_h1_style = "background-color: rgba(0, 0, 0, 0.67};";


		s1_bt1 = "ОСТАВЬТЕ ЗАЯВКУ <br><span> и мы свяжемся с Вами в течение 20 минут</span>";
		s3_h1 = "РАССЧИТАЙТЕ СТОИМОСТЬ <br>  <span class='tw'>ВАШЕГО "+ name[1] +"</span> <br> <span class='with-line'>УЖЕ СЕЙЧАС!</span>";


		s1_background = "../images/minitraktor_bu/s1.jpg";
		s2_background = "../images/minitraktor_bu/s2.jpg";
		s3_background = "../images/minitraktor_bu/s3.jpg";
		s4_background = "../images/minitraktor_bu/s4.jpg";
		s5_background = "../images/minitraktor_bu/s5.jpg";


		menu = new List<string> { "Главная", "Преимущества", "Рассчитать", "Отзывы", "Контакты"};
		recall_dialog = "МЫ ПЕРЕЗВОНИМ!";
		// free_call_text = "Звонок бесплатный";
		but_text = "";
		this1 = new List<string> { };

		s2_left_title = "";
		s2_right_title = "";
		s2_left_this2_style = "";
		s2_right_this2_style = "";
		s2_this_left = new List<string> { };
		s2_this_right = new List<string> { };
		
		s2_this_bu_title = "<span>ПРОДАЙТЕ ТРАКТОР</span> УЖЕ СЕЙЧАС";
		s2_this_bu = new List<string> { 
            "<div>Не платите никаких <br> скрытых платежей</div>",
            "<div>Бесплатная предпродажная <br> подготовка</div>",
            "<div>Не затрачиваетесь <br> на доставку</div>",
            "<div>Получаете выгодное <br> вознаграждение</div>",

        };

		
		s2_this_left_but = "УЗНАТЬ ПОДРОБНЕЕ";

		
		// 3_form_style = "";
		s3_form =  new Dictionary<string, string> { 
            {"placeholder1" , "Меня зовут"},
            {"required_message1" , "Введите свое имя"},
            {"placeholder2" , "Мой телефон"},
            {"required_message2" , "Введите свой телефон"},
            {"placeholder3" , "Мне нужен "+ name[0] +""},
            {"button" , "РАССЧИТАТЬ"}
        };

		s4_title = "ЧТО ГОВОРЯТ</span> <br> НАШИ КЛИЕНТЫ ";
        fback = new Dictionary<string, string> { 

            {"name1" , "<span>Михаил</span>, фермер"},
            {"comment1" , "Как-то сложилось, что у нас в парке оказался лишний минитрактор, который стоял напостой без работы, и в конце концов мы решили его продать. Совершенно не было времени заниматься объявлениями, и знакомый посоветовал обратиться в ООО «Торговый Дом «Тракторный Завод» - он им уже два своих старых трактора продал, и купил новые. Все сделали быстро, и по стоимости я доволен. Спасибо. "},




            {"name2" , "<span>Олег</span>, предприниматель"},
            {"comment2" , "Искали где продать свой минитрактор с пробегом, нашли в интернете Торговый Дом Тракторный Завод. Оценили очень быстро, буквально на следующий день уже увезли. "},




            {"name6" , "<span>Николай</span>, владелец фермерского хозяйства"},
            {"comment6" , "Приятно работать с компетентными людьми. Не пришлось никому ничего объяснять, что за аппарат, и какие у него проблемы. Приехали, посмотрели, договорились. Все оперативно, и по деньгам никого не обидели."},




            {"name4" , "<span>Наталья</span>, фермер"},
            {"comment4" , "Давно решили обзавестись новым минитрактором, а старый все никак не получалось продать - то ли навыков нету, то ли времени не хватало. Да и по средствам немного не вписывались. В итоге понедельник нашли  ООО «Торговый Дом «Тракторный Завод», и закрыли вопрос с покупкой нового трактора уже в конце недели. Будем рекомендовать коллегам и знакомым."},




            {"name5" , "<span>Игорь</span>, водитель сельхозтехники"},
            {"comment5" , "Решили обновить парк, старые трактора продать, и купить новые. Обратились в ООО «Торговый Дом «Тракторный Завод», все в течение нескольких дней оформили. Приятно иметь дело с профессионалами."},



            {"name3" , "<span>Александр</span>, помощник руководителя предприятия"},
            {"comment3" , "Выгодно продать б/у трактор не так просто, особенно если по нему есть вопросы, а заниматься ими некогда. Ребята приехали, все оценили, сказали что предпродажную подготовку сами сделают, обсудили все детали и в этот же день пожали друг другу руки. Спасибо!"},



            {"name7" , "<span></span>, фермер"},
            {"comment7" , ""}

        };

		
		footer_h1 = "<span>КАК</span> НАС НАЙТИ?";


		popup1_form_short = true;
		popup1_h1 = "КАК С ВАМИ СВЯЗАТЬСЯ ?";
		popup1_header = "Не нашли что искали? <br> Оставьте номер, мы перезвоним и поможем!";
		popup1_form = new Dictionary<string, string> { 
            {"placeholder1" , "Меня зовут"},
            {"required_message1" , "Введите свое имя"},
            {"placeholder2" , "Мой телефон"},
            {"required_message2" , "Сообщение"},
            {"placeholder3" , "Сообщение..."},
            {"button" , "ОСТАВИТЬ ЗАЯВКУ"}
        };


		popup3_h1 = "Я ХОЧУ ПРОДАТЬ <br> МИНИТРАКТОР";
		popup3_form = new Dictionary<string, string> { 
            {"placeholder1" , "Меня зовут"},
            {"required_message1" , "Введите свое имя"},
            {"placeholder2" , "Мой телефон"},
            {"required_message2" , "Сообщение"},

            {"placeholder3" , "Марка и модель трактора"},
            {"placeholder4" , "Дата изготовления трактора"},
            {"placeholder5" , "Мощность"},
            {"placeholder6" , "Состояние"},
            {"placeholder7" , "true"}, //фото

            {"button" , "ОСТАВИТЬ ЗАЯВКУ"}
        };


		message_thanks = "Мы свяжемся с Вами. Спасибо.";

		s3 = false;
        }
    }
}