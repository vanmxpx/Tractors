using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace MIS.Data.Persons.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ContactMeController : ControllerBase 
    {
        private readonly ILogger<ContactMeController> _logger;

        public ContactMeController (
            ILogger<ContactMeController> logger
        ) {
            _logger = logger;
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] MessageDTO body) 
        {
            if(body.message == null)
                body.message = "";

            string name = body.name;// strip_tags(htmlspecialchars($_POST['name']));
            string phone = body.phone; // strip_tags(htmlspecialchars($_POST['phone']));

            
            string message = body.message; //strip_tags(htmlspecialchars($_POST['message']));

            string message2;
            if(body.message2 != null)
                message2 = body.message2;

            string email;
            if(body.email != null)
                email = body.email;

            if(body.file != null)
            {
                var allowed_extensions = new string[] { "jpg", "jpeg", "gif", "bmp" };
                string uploaddir = @"./attach/";
                string uploadfile = uploaddir ;//+ basename($_FILES['file']['name']); TODO:

                // $type_of_uploaded_file = substr($uploadfile, strrpos($uploadfile, '.') + 1);

                // $allowed_ext = false;
                // for($i=0; $i<sizeof($allowed_extensions); $i++){
                // if(strcasecmp($allowed_extensions[$i],$type_of_uploaded_file) == 0){
                //     $allowed_ext = true;
                // }
                // }

                // if($type_of_uploaded_file != 'php') {
                //     move_uploaded_file($_FILES['file']['tmp_name'], $uploadfile);
                //     $message2 .= "Фото: <a href=\"http://tdtz.in.ua/$uploadfile\">просмотр</a>";
                // }

            }

            string to = "info.tdtz@gmail.com, gvp731117@ukr.net";
            string email_subject = "Заказ с сайта tdtz.in.ua:  $name";
            string email_body = "Вы получили новое сообщение.<br>" + " Подробности:<br> Имя: $name<br> Телефон: $phone<br> Email: $email <br>Сообщение: $message<br>  $message2";
            string headers = "From: info.tdtz@gmail.com\n";
            headers += "Content-Type: text/html; charset=utf-8\n";
            // mail($to,$email_subject,$email_body,$headers);

            // require_once("handler.php");

            return true;
        }
        
    }
    public class MessageDTO 
    { 
        public string message { get; set; }
        
        public string message2 { get; set; }
        
        public string name { get; set; }
        
        public string phone { get; set; }
        
        public string email { get; set; }
        
        public string file { get; set; }
    }
}