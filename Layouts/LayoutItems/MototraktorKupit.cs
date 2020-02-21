using System.Collections.Generic;
using System.Collections.Immutable;

namespace Tractors.Layouts.LayoutItems
{
    public class MototraktorKupit : ILayout
    {

        public override string ToString() 
        { 
            return "mototraktor_kupit_v2";
        }
        public string advantages_block { get; private set; } = null;
        public string but_text_kred { get; private set; } = null;

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

        public string recall_dialog { get; private set; } = null;

        public List<string> phone => SharedItems.phone;

        public string video { get; private set; } = null;

        public string s2_this_bu_title { get; private set; } = null;
        
        public string s2_this_left_but { get; private set; } = null;
        public string s2_left_this2_style { get; private set; } = null;
        
        public string s2_left_title { get; private set; } = null;
        public List<string> s2_this_left { get; private set; } = null;

        public List<string>? s2_this_bu { get; private set; } = null;

        public string s2_right_style { get; private set; } = null;

        public string s2_right_title { get; private set; } = null;

        public List<string> s2_this_right { get; private set; } = null;

        public string s2_right_this2_style { get; private set; } = null;

        public MototraktorKupit() 
        { 
            disable_main = null;
            product_name = null;
            product_id = null;
            video = "tracktor_960x350.mp4";

		    name = new List<string> { "минитрактор", "минитрактора", "минитракторы", "минитракторов" };

		    price = "56 000";

		    logo = "images/logo.png";
		    //mexicano = "Студия HC Landing Page Mexicano";

		    //title = "Купить "+ name[0] + "";
		    //keywords = "Купить "+ name[0] + "";
		   // description = "Купить "+ name[0] + "";
		    s1_h1 = "ИЩЕТЕ ГДЕ КУПИТЬ <br> "+ name[0] + "? <br> <span class='mini-t'>"+ name[2] + " ОТ <span class='mini-p'>" + price +"</span> ГРН</span><div>3 года гарантии</div>";
		    s1_bt1 = "ПОЛУЧИТЬ КОНСУЛЬТАЦИЮ";
		    s2_left_title = "" + name[2] + " <span>ДМТЗ</span>";
		    s2_right_title = "<span>ДРУГИЕ</span> " + name[2];
		    //s3_h1 = "РАССЧИТАЙТЕ СТОИМОСТЬ <br>  <span class='tw'>ВАШЕГО "+ name[1] + "</span> <br> <span class='with-line'>УЖЕ СЕЙЧАС!</span>";

		    first_form = new Dictionary<string, string> {
			{"class", "first-form-box first-form-box-redesign" } ,
			{"background" , "/images/form-first/4.png"} ,
			{ "body" , "			<div class='first-form-title first-form-title-redesign'>"
                                    +" КУПИТЕ ЛЮБУЮ МОДЕЛЬ <br>"
                                    +"МИНИТРАКТОРА <br>"
                                    +"до"
                                    +"<span>"
                                    
                                    +"</span>"
                             +"   </div>"

                               +" <img class='first-form-img first-form-img-redesign first-form-img__boz-shadow media-width_150' src='/images/form-first/gift4.jpg'>"

                               +" <div class='first-form-gift first-form-gift-redesign'>"
                               +"    и получите лопату-отвал на 1.25 м <br>"
                    
                                   +" <span>"
                                  +"      В ПОДАРОК"
                                   +" </span>"
                               +" </div>"},
      {"form" , "<form id='contactForm' class='first-form first-form-redesign' novalidate=''>"
                                   +"  <ol>"
                                      +"   <li class='form-group hide'>"
                                       +"    <input id='name' name='name' type='text' placeholder='Ваше имя' required='' data-validation-required-message='Введите свое имя' aria-invalid='false'>"
                                       +"    <p class='help-block text-danger'></p>"
                                        +"</li>"
                                     +"    <li class='form-group'>"
                                      +"     <input id='phone' name='phone' type='text' placeholder='+38 ( _ _ _ ) _ _ _-_ _-_ _' required='' data-validation-required-message='Введите свой телефон'>"
                                       +"    <p class='help-block text-danger'></p>"
                                     +"    </li>"
                                      +"   <li class='form-group hide'>"
                                      +"     <input id='email' name='email' type='text' placeholder='Ваш e-mail' required='' data-validation-required-message='Введите свой email'>"
                                      +"     <p class='help-block text-danger'></p>"
                                      +"   </li>"
                                      +"   <li class='form-group'>"
                                            +"<button class='btn btn-md btn-primary bt-popup bt-first-form bt-first-form-redesign' >ПОЛУЧИТЬ <br> КОНСУЛЬТАЦИЮ</button>"
                                     +"    </li>"
                                +"     </ol>"
              +"   </form>"}
		};


		s1_background = "../images/back1.jpg";
		s2_background = "../images/mototraktor/s2.jpg";
		s3_background = "../images/mototraktor/s3.jpg";
		s4_background = "../images/mototraktor/s4.jpg";
		s5_background = "../images/mototraktor/s5.jpg";
		// s6_background = "../images/mototraktor/s6.jpg";
		// s7_background = '../images/mototraktor/s7.jpg';


		menu = new List<string> { "Главная", "Преимущества","Обзор","Модели", "Рассчитать", "Отзывы", "Контакты" };
		recall_dialog = "МЫ ПЕРЕЗВОНИМ!";
		// free_call_text = "Звонок бесплатный";
		but_text = "ПОКУПАЙТЕ У ПРОИЗВОДИТЕЛЯ! ЭТО:";
		this1 = new List<string> { "ВЫГОДНО", "НАДЕЖНО", "БЕЗОПАСНО"};

		advantages_block = "<section class='bg-image bg-fixed why-choose-section'>"
                            +"<div class='container'>"
                                +"<div class='why-choose-box'>"
                                    +"<div class='row'>"
                                        +"<div class='col-lg-12'>"
                                            +"<h1>ПОЧЕМУ ВЫБИРАЮТ МИНИТРАКТОРЫ ДМТЗ</h1>"
                                            +"<p>мы производим минитракторы на собственном заводе, что позволяет<br> гарантировать высокое качество каждой детали</p>"
                                        +"</div> "
                                    +"</div>"
                                    +"<div class='row'>"
                                        +"<div class='col-lg-3 col-md-6 col-sm-12'>"
                                            +"<img src='images/choose-1.png' alt='choose-1'>"
                                            +"<h6>КАЧЕСТВЕННАЯ УКРАИНСКАЯ СБОРКА</h6>"
                                        +"</div>"
                                        +"<div class='col-lg-3 col-md-6 col-sm-12'>"
                                            +"<img src='images/choose-2.png' alt='choose-2'>"
                                            +"<h6>КАЧЕСТВЕННЫЕ КОМПЛЕКТУЮЩИЕ</h6>"
                                        +"</div>"
                                        +"<div class='col-lg-3 col-md-6 col-sm-12'>"
                                            +"<img src='images/choose-3.png' alt='choose-3'>"
                                            +"<h6>НАВЕСНОЕ <br> ОБОРУДОВАНИЕ</h6>"
                                            +"<p>по оптовым ценам и с бесплатной доставкой</p>"
                                        +"</div>"
                                    +"<div class='col-lg-3 col-md-6 col-sm-12'>"
                                            +"<img src='images/choose-4.png' alt='choose-4'>"
                                            +"<h6>БЕСПЛАТНАЯ<br> ДОСТАВКА</h6>"
                                        +"</div> "
                                    +"</div>"
                                +"</div>"
                            +"</div>"
                        +"</section>"
                        +"<section class='back3 text-center' id='vidos'>"
                        +"<h2>ВИДЕО ОБЗОР</h2>"
                        +"<iframe width='560' height='315' data-loader='youtube' data-src='xRt6fYL9QNA' frameborder='0'  allowfullscreen></iframe>"
                        +"</section>"


                        +"<section class='why-choose-wrapper'>"
                            +"<h1>Почему наши тракторы лучше</h1>"
                            +"<div class='container'>"
                                +"<div class='row'>"
                                    +"<div class='col-lg-23'>"
                                        +"<ul class='advantages-list'>"
                                            +"<li>ДВИГАТЕЛЬ: 16 л.с. (надёжный и экономичный)</li>"
                                            +"<li>РАЗМЕРЫ (ДхШхВ): 2500 х 1300 х 1350 (мм)</li>"
                                            +"<li>КЛИРЕНС: 300 мм</li>"
                                            +"<li>МАССА: 580 кг</li>"
                                        +"</ul>"
                                    +"</div>"
                                +"</div>"
                            +"</div>"

                            +"<div class='dot dot-1' data-value='1'></div>"
                            +"<div class='dot dot-2' data-value='2'></div>"
                            +"<div class='dot dot-3' data-value='3'></div>"
                            +"<div class='dot dot-4' data-value='4'></div>"
                            +"<div class='dot dot-5' data-value='5'></div>"
                            +"<div class='dot dot-6' data-value='6'></div>"
                            +"<div class='dot dot-7' data-value='7'></div>"
                            +"<div class='dot dot-8' data-value='8'></div>"
                            +"<div class='dot dot-9' data-value='9'></div>"
                            +"<div class='dot dot-10' data-value='10'></div>"

                            +"<div class='why-item-box why-item-box-1 hide'>"
                                +"<div class='arrow-1 arrow1-1'></div>"
                                +"<div class='arrow-2 arrow1-2'></div>"
                                +"<div class='item-container'>"
                                    +"<h6>Передний гидроцилиндр</h6>"
                                    +"<p>Увеличивает функциональные возможности трактора, позволяет использовать переднюю сенокосилку, лопатуотвал, щётку подметальную.</p>"
                                    +"<img src='images/why-choose-items/why-item-2.jpg' alt=''>"
                                    +"<div class='item-box-btn-close'>"
                                        +"<div class='stick stick-1'></div>"
                                        +"<div class='stick stick-2'></div>"
                                    +"</div>"
                                +"</div>"
                            +"</div>"

                            +"<div class='why-item-box why-item-box-2 hide'>"
                                +"<div class='arrow-1 arrow2-1'></div>"
                                +"<div class='arrow-2 arrow2-2'></div>"
                                +"<div class='item-container'>"
                                    +"<h6>Регулируемые колии колёс</h6>"
                                    +"<p>Позволяет регулировать размер колеи трактора при работе в междурядье.</p>"
                                    +"<img src='images/why-choose-items/why-item-7.jpg' alt=''>"
                                    +"<div class='item-box-btn-close'>"
                                        +"<div class='stick stick-1'></div>"
                                        +"<div class='stick stick-2'></div>"
                                    +"</div>"
                                +"</div>"
                            +"</div>"

                            +"<div class='why-item-box why-item-box-3 hide'>"
                                +"<div class='arrow-1 arrow3-1'></div>"
                                +"<div class='arrow-2 arrow3-2'></div>"
                                +"<div class='item-container'>"
                                    +"<h6>5-ти ручейных шкив двигателя</h6>"
                                    +"<p>Увеличивает функциональные возможности трактора позволяя агрегатировать трактор различными механическими механизмами. </p>"
                                    +"<img src='images/why-choose-items/why-item-5.jpg' alt=''>"
                                    +"<div class='item-box-btn-close'>"
                                        +"<div class='stick stick-1'></div>"
                                        +"<div class='stick stick-2'></div>"
                                    +"</div>"
                                +"</div>"
                            +"</div>"

                            +"<div class='why-item-box why-item-box-4 hide'>"
                                +"<div class='arrow-1 arrow4-1'></div>"
                                +"<div class='arrow-2 arrow4-2'></div>"
                                +"<div class='item-container'>"
                                    +"<h6> Воздушный фильтр за пределами панели приборов</h6>"
                                    +"<p>Удобность в обслуживании фильтра и экономия времени на проведении ТО.</p>"
                                    +"<img src='images/why-choose-items/why-item-10.jpg' alt=''>"
                                    +"<div class='item-box-btn-close'>"
                                        +"<div class='stick stick-1'></div>"
                                        +"<div class='stick stick-2'></div>"
                                    +"</div>"
                                +"</div>"
                            +"</div>"

                            +"<div class='why-item-box why-item-box-5 hide'>"
                                +"<div class='arrow-1 arrow5-1'></div>"
                                +"<div class='arrow-2 arrow5-2'></div>"
                                +"<div class='item-container'>"
                                    +"<h6>Трос декомпрессора и ручной газ</h6>"
                                    +"<p>С лёгкостью и без усилий вы запустите двигатель даже в самых суровых зимних условиях.</p>"
                                    +"<img src='images/why-choose-items/why-item-8.jpg' alt=''>"
                                    +"<div class='item-box-btn-close'>"
                                        +"<div class='stick stick-1'></div>"
                                        +"<div class='stick stick-2'></div>"
                                    +"</div>"
                                +"</div>"
                            +"</div>"

                            +"<div class='why-item-box why-item-box-6 hide'>"
                                +"<div class='arrow-1 arrow6-1'></div>"
                                +"<div class='arrow-2 arrow6-2'></div>"
                                +"<div class='item-container'>"
                                    +"<h6>Прямое натяжение ремней привода двигателя и КПП</h6>"
                                    +"<p>Передаёт обороты двигателя на муфту сцепления КПП без потери мощности, в разы увеличивает срок службы приводных ремней.</p>"
                                    +"<img src='images/why-choose-items/why-item-4.jpg' alt=''>"
                                    +"<div class='item-box-btn-close'>"
                                        +"<div class='stick stick-1'></div>"
                                        +"<div class='stick stick-2'></div>"
                                    +"</div>"
                                +"</div>"
                            +"</div>"

                            +"<div class='why-item-box why-item-box-7 hide'>"
                                +"<div class='arrow-1 arrow7-1'></div>"
                                +"<div class='arrow-2 arrow7-2'></div>"
                                +"<div class='item-container'>"
                                    +"<h6>Отдельный рычаг повышенных и пониженных передач</h6>"
                                    +"<p>Удобность в управлении минитрактором.  Исключается возможность включения двух передач одновременно. </p>"
                                    +"<img src='images/why-choose-items/why-item-9.jpg' alt=''>"
                                    +"<div class='item-box-btn-close'>"
                                        +"<div class='stick stick-1'></div>"
                                        +"<div class='stick stick-2'></div>"
                                    +"</div>"
                                +"</div>"
                            +"</div>"

                             +"<div class='why-item-box why-item-box-8 hide'>"
                                +"<div class='arrow-1 arrow8-1'></div>"
                                +"<div class='arrow-2 arrow8-2'></div>"
                                +"<div class='item-container'>"
                                    +"<h6>Блокировка дифференциала</h6>"
                                    +"<p>Увеличивает проходимость трактора, позволяет эксплуатировать трактор в тяжёлых дорожных условиях, как при размытых грунтах, так и при гололёде. </p>"
                                    +"<img src='images/why-choose-items/why-item-1.jpg' alt=''>"
                                    +"<div class='item-box-btn-close'>"
                                        +"<div class='stick stick-1'></div>"
                                        +"<div class='stick stick-2'></div>"
                                    +"</div>"
                                +"</div>"
                            +"</div>"

                            +"<div class='why-item-box why-item-box-9 hide'>"
                                +"<div class='arrow-1 arrow9-1'></div>"
                                +"<div class='arrow-2 arrow9-2'></div>"
                                +"<div class='item-container'>"
                                    +"<h6>Задний гидравлический навесной механизм с плавающим режимом</h6>"
                                    +"<p>Позволяет равномерно и качественно обрабатывать почву и растительные культуры на склонах и холмах. </p>"
                                    +"<img src='images/why-choose-items/why-item-3.jpg' alt=''>"
                                    +"<div class='item-box-btn-close'>"
                                        +"<div class='stick stick-1'></div>"
                                        +"<div class='stick stick-2'></div>"
                                    +"</div>"
                                +"</div>"
                            +"</div>"

                            +"<div class='why-item-box why-item-box-10 hide'>"
                                +"<div class='arrow-1 arrow10-1'></div>"
                                +"<div class='arrow-2 arrow10-2'></div>"
                                +"<div class='item-container'>"
                                    +"<h6>Регулируемые колии колёс</h6>"
                                    +"<p>Позволяет регулировать размер колеи трактора при работе в междурядье.</p>"
                                    +"<img src='images/why-choose-items/why-item-6.jpg' alt=''>"
                                    +"<div class='item-box-btn-close'>"
                                        +"<div class='stick stick-1'></div>"
                                        +"<div class='stick stick-2'></div>"
                                    +"</div>"
                                +"</div>"
                            +"</div>"

                        +"</section>";

		s2_left_this2_style = "";
		//s2_right_styles2_right_style = "padding-bottom: 88px;";
		s2_right_this2_style = "margin-top: 20px;";
		s2_this_left = new List<string> { 
			"Являемся заводом-изготовителем",
			"Работаем без посредников",
			"Даем гарантию 3 года",
			"Предоставляем сервис по всей Украине",
			"Бесплатная доставка",
			"Доставка машиной завода-изготовителя",
			"Демонстрируем работу трактора при получении",
			"Оплата только после получения",
			"На связи 24/7 до и после покупки",
			"С вами работает личный менеджер",
			"Вас обслуживает специалист по сельхозтехнике",
			"100% возврат денег",
			"Накопительные скидки и приятные бонусы",
			// "Качественная украинская сборка",
			// "Качественные комплектующие",
			// "Навесное оборудование от производителя по оптовым ценам и  бесплатной доставкой",
			// "В комплекте с мототрактором идет почвофреза 110 см и 2-х корпусный плуг",
		};
 		s2_this_left_but = "УЗНАТЬ ПОДРОБНЕЕ";

		s2_this_right = new List<string> {
			"Являются посредниками",
			"Взимают плату за посредничество",
			"Гарантия 1 год либо не дают гарантий вовсе",
			"Не имеют собственного сервиса",
			"Вы платите за доставку",
			"Доставляют сторонними курьерскими службами",
			"Вам просто отгружают товар",
			"Требуют 100% предоплату",
			"Не отвечают на звонки, бросают трубки",
			"Каждый раз новый менеджер",
			"Вас консультирует обычный “продажник”",
			"Вам уже не вернут Ваши средства",
			"Не имеют партнерской программы",

			// "Поставляют некачественную китайскую сборку",
			// "Некачественные китайские комплектующие",
			// "Указывают цену на трактор без комплекта",
		};


// 		s3_form = array(
// 			"placeholder1" => "Меня зовут",
// 			"required_message1" => "Введите свое имя",
// 			"placeholder2" => "Мой телефон",
// 			"required_message2" => "Введите свой телефон",
// 			"placeholder3" => "Мне нужен "+ name[0] + "... ",
// 			"button" => "РАССЧИТАТЬ"
// 		);


// 		s4_title = "ЧТО ГОВОРЯТ</span> <br> НАШИ КЛИЕНТЫ ";
// fback = array(


// 			"name1" => "<span>Михаил</span>, фермер",
// 			"comment1" => "Рассматривая для себя варианты минитехники, остановился на минитракторах ДМТЗ, знакомый фермер посоветовал.  Оплатил после получения, да и сэкономил на доставке хорошо. Уже 2 года работает, пока никаких проблем нет. ",




// 			"name2" => "<span>Олег</span>, предприниматель",
// 			"comment2" => "Искали недорогой и надежный вариант по минитракторам для своего производства, нашли в интернете Торговый Дом Тракторный Завод. За нами закрепили собственного менеджера, который оказался отличным специалистом в сельхозтехнике, подобрал именно то, что нам было нужно. Спасибо за сотрудничество!",




// 			"name6" => "<span>Николай</span>, владелец фермерского хозяйства",
// 			"comment6" => "Приятно работать с компетентными людьми. Не просто по телефону проконсультировали, но и на завод пригласили. Посмотрел все модели, каждую при мне завели. Действительно помогли выбрать, а не “втюхали”. Пользуюсь уже полгода как, пока никаких проблем нет.",




// 			"name4" => "<span>Наталья</span>, фермер",
// 			"comment4" => "Заказали себе уже второй минитрактор ДМТЗ. Хорошо, что у нас в Украине есть такая качественная сельхозтехника отечественного производства!",




// 			"name5" => "<span>Игорь</span>, водитель сельхозтехники",
// 			"comment5" => "Мне, как профессионалу, в первую очередь было важно, чтобы с техникой было комфортно работать. Когда заглянул под капот ДМТЗ - сразу стало понятно, что все сделано качественно и надежно. Чувствуется отличие от китайской сборки. Думаю, обновлять парк в дальнейшем будем только в ООО «Торговый Дом «Тракторный Завод».",




// 			"name3" => "<span>Александр</span>, помощник руководителя предприятия",
// 			"comment3" => "Пользуемся минитрактором ДМТЗ уже не первый год. Качество хорошее, но техника есть техника, в какой-то момент понадобилась помощь специалиста. Теперь я знаю, как важно чтобы у производителя был собственный сервис по всей стране. Знакомый купил минитрактор другой фирмы, уже третий месяц стоит - нигде починить не может. Спасибо ООО «Торговый Дом «Тракторный Завод» за оперативность. Отдельная благодарность Юрию, за то что рассказал, как ухаживать за техникой в дальнейшем.",


// 		);


// 		footer_h1 = "<span>КАК</span> НАС НАЙТИ?";


//         popup1_form_short = true;
// 		popup1_h1 = "КАК С ВАМИ СВЯЗАТЬСЯ ?";
//         popup1_header = "Не нашли что искали? <br> Оставьте номер, мы перезвоним и поможем!";
// 		popup1_form = array(
// 			"placeholder1" => "Меня зовут",
// 			"required_message1" => "Введите свое имя",
// 			"placeholder2" => "Мой телефон",
// 			"required_message2" => "Введите свой телефон",
// 			"placeholder3" => "Мне нужен "+ name[0] + "... ",
// 			"button" => "ОСТАВИТЬ ЗАЯВКУ"
// 		);

// 		popup2_h1 = "ЗАКАЗАТЬ ". name[0]. " <br> ПРЯМО С ЗАВОДА";
// 		popup2_form = array(
// 			"placeholder1" => "Меня зовут",
// 			"required_message1" => "Введите свое имя",
// 			"placeholder2" => "Мой телефон",
// 			"required_message2" => "Введите свой телефон",
// 			"placeholder3" => "Мне нужен "+ name[0] + "... ",
// 			"button" => "ОСТАВИТЬ ЗАЯВКУ"
// 		);

// 		message_thanks = "Мы свяжемся с Вами. Спасибо.";
        }
    }
}