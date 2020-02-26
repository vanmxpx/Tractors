using System.Collections.Generic;

namespace Tractors.Layouts.LayoutItems
{
    public class MinitraktorDostavka : ILayout
    {

        public override string ToString() 
        {
            return "minitraktor_dostavka"; // /?utm_content=
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

        public MinitraktorDostavka()
        {
            // new List<string> { 
            // new Dictionary<string, string> { 
            
            name = new List<string> { "минитрактор", "минитрактора", "минитракторы", "минитракторов" };

            logo = "images/logo.png";
            // mexicano = "Студия HC Landing Page Mexicano";

            price = "61 835";

            title = "Купить "+ name[0] +"";
            keywords = "Купить "+ name[0] +"";
            description = "Купить "+ name[0] +"";
            s1_h1 = ""+ name[2] +" от производителя с бесплатной доставкой по Украине <br> <span class='mini-t'>"+ name[2] +" ОТ <span class='mini-p'>"+ price +"</span> ГРН</span><div>3 года гарантии</div>";
            s1_bt1 = "ЗАКАЗАТЬ <br><span>"+ name[0] +" прямо с завода";
            s2_left_title = ""+ name[2] +" <span>ДМТЗ</span>";
            s2_right_title = "<span>ДРУГИЕ</span> " + name[2];
            s3_h1 = "РАССЧИТАЙТЕ СТОИМОСТЬ <br>  <span class='tw'>ВАШЕГО "+ name[1] +"</span> <br> <span class='with-line'>УЖЕ СЕЙЧАС!</span>";



            s1_background = "../images/minitraktor/s1.jpg";
            s2_background = "../images/minitraktor/s2.jpg";
            s3_background = "../images/minitraktor/s3.jpg";
            s4_background = "../images/minitraktor/s4.jpg";
            s5_background = "../images/minitraktor/s5.jpg";
            menu = new List<string> { "Глвная", "Преимущества", "Рассчитать", "Отзывы", "Контакты" };
            recall_dialog = "МЫ ПЕРЕЗВОНИМ!";
            // free_call_text = "Звонок бесплатный";
            but_text = "ПОКУПАЙТЕ У ПРОИЗВОДИТЕЛЯ! ЭТО:";
            this1 = new List<string> { "ВЫГОДНО", "НАДЕЖНО", "БЕЗОПАСНО" };

            first_form = new Dictionary<string, string> { 
                {"class" ,"first-form-box first-form-box-redesign"},
                {"background" ,"/images/form-first/4.png"},
                {"body" ,LayoutsService.ReadHtml("MinitraktorDostavkaFirstFormBody")},
                {"form" ,LayoutsService.ReadHtml("MinitraktorDostavkaFirstFormForm")},
             };

            advantages_block =  LayoutsService.ReadHtml("MinitraktorDostavkaAdvantages");
            s2_left_this2_style = "";
            s2_right_this2_style = "margin-top: 27px;";
            s2_this_left = new List<string> { 
                "Являемся заводом-изготовителем",
                "Работаем без посредников",
                "Даем гарантию 3 года",
                "Предоставляем сервис по всей Украине",
                "Бесплатная доставка",
                "Оплата только после получения",
                "На связи 24/7 до и после покупки",
                "С вами работает личный менеджер",
                "Качественная украинская сборка",
                "Качественные комплектующие",
                "Навесное оборудование от производителя по оптовым ценам и  бесплатной доставкой",
             };
            s2_this_left_but = "УЗНАТЬ ПОДРОБНЕЕ";

            s2_this_right = new List<string> { 
                "Являются посредниками",
                "Взимают плату за посредничество",
                "Гарантия 1 год либо не дают гарантий вовсе",
                "Не имеют собственного сервиса",
                "Вы платите за доставку",
                "Требуют 100% предоплату",
                "Не отвечают на звонки, бросают трубки",
                "Каждый раз новый менеджер",
                "Поставляют некачественную китайскую сборку",
                "Некачественные китайские комплектующие",
                "Вам придется покупать навесное оборудование в 2 раза дороже и переплачивать за доставку",
             };


            s3_form = new Dictionary<string, string> { 
                {"placeholder1" ,"Меня зовут"},
                {"required_message1" ,"Введите свое имя"},
                {"placeholder2" ,"Мой телефон"},
                {"required_message2" ,"Введите свой телефон"},
                {"placeholder3" ,"Мне нужен "+ name[0] +"... "},
                {"button" ,"РАССЧИТАТЬ"}
             };


            s4_title = "ЧТО ГОВОРЯТ</span> <br> НАШИ КЛИЕНТЫ ";
            fback = new Dictionary<string, string> { 
                {"name1" ,"<span>Михаил</span>, фермер"},
                {"comment1" ,"Рассматривая для себя варианты минитехники, остановился на минитракторах ДМТЗ, знакомый фермер посоветовал.  Оплатил после получения, да и сэкономил на доставке хорошо. Уже 2 года работает, пока никаких проблем нет. "},
                {"name2" ,"<span>Олег</span>, предприниматель"},
                {"comment2" ,"Искали недорогой и надежный вариант по минитракторам для своего производства, нашли в интернете Торговый Дом Тракторный Завод. За нами закрепили собственного менеджера, который оказался отличным специалистом в сельхозтехнике, подобрал именно то, что нам было нужно. Спасибо за сотрудничество!"},
                {"name6" ,"<span>Николай</span>, владелец фермерского хозяйства"},
                {"comment6" ,"Приятно работать с компетентными людьми. Не просто по телефону проконсультировали, но и на завод пригласили. Посмотрел все модели, каждую при мне завели. Действительно помогли выбрать, а не “втюхали”. Пользуюсь уже полгода как, пока никаких проблем нет."},
                {"name4" ,"<span>Наталья</span>, фермер"},
                {"comment4" ,"Заказали себе уже второй минитрактор ДМТЗ. Хорошо, что у нас в Украине есть такая качественная сельхозтехника отечественного производства!"},
                {"name5" ,"<span>Игорь</span>, водитель сельхозтехники"},
                {"comment5" ,"Мне, как профессионалу, в первую очередь было важно, чтобы с техникой было комфортно работать. Когда заглянул под капот ДМТЗ - сразу стало понятно, что все сделано качественно и надежно. Чувствуется отличие от китайской сборки. Думаю, обновлять парк в дальнейшем будем только в ООО «Торговый Дом «Тракторный Завод»."},
                {"name3" ,"<span>Александр</span>, помощник руководителя предприятия"},
                {"comment3" ,"Пользуемся трактором ДМТЗ уже не первый год. Качество хорошее, но техника есть техника, в какой-то момент понадобилась помощь специалиста. Теперь я знаю, как важно чтобы у производителя был собственный сервис по всей стране. Знакомый купил трактор другой фирмы, уже третий месяц стоит - нигде починить не может. Спасибо ООО «Торговый Дом «Тракторный Завод» за оперативность. Отдельная благодарность Юрию, за то что рассказал, как ухаживать за техникой в дальнейшем."}
             };


            footer_h1 = "<span>КАК</span> НАС НАЙТИ?";


            popup1_form_short = true;
            popup1_h1 = "КАК С ВАМИ СВЯЗАТЬСЯ ?";
            popup1_header = "Не нашли что искали? <br> Оставьте номер, мы перезвоним и поможем!";
            popup1_form = new Dictionary<string, string> { 
                {"placeholder1" ,"Меня зовут"},
                {"required_message1" ,"Введите свое имя"},
                {"placeholder2" ,"Мой телефон"},
                {"required_message2" ,"Введите свой телефон"},
                {"placeholder3" ,"Мне нужен "+ name[0] +""},
                {"button" ,"ОСТАВИТЬ ЗАЯВКУ"}
             };

            popup2_h1 = "ЗАКАЗАТЬ " + name[0] + " <br> ПРЯМО С ЗАВОДА";
            popup2_form = new Dictionary<string, string> { 
                {"placeholder1" ,"Меня зовут"},
                {"required_message1" ,"Введите свое имя"},
                {"placeholder2" ,"Мой телефон"},
                {"required_message2" ,"Введите свой телефон"},
                {"placeholder3" ,"Мне нужен "+ name[0] +""},
                {"button" ,"ОСТАВИТЬ ЗАЯВКУ"}
             };

            message_thanks = "Мы свяжемся с Вами. Спасибо.";
            // mexicano = "Студия HC Landing Page Mexicano";

        }
    }
}