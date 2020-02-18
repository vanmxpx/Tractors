import { ModuleInfo } from './module-info';
import * as phone from './phone';


class DefaultInfo implements ModuleInfo { 
    $but_text = '��������� � �������������! ���:';
    $name = Array('�����������', '������������', '������������', '�������������');
    $price = '59 000';
    $logo = 'logo.png';
    $menu = Array('Главная', 'Преимущества', 'Рассчитать', 'Отзывы', 'Контакты');
    $this1 = Array('�������', '�������', '���������');
    $s1_h1 = '<br>����� ��� ������ <br> ' + this.$name[0] + '? <br> <span class="mini-t">' + this.$name[2] + ' �� <span class="mini-p">' + this.$price + '</span> ���</span><div>3 ���� ��������</div>';
    $s1_bt1 =  '�������� <br><span>' + this.$name[0] + ' ����� � ������';
    $s1_background = "mototraktor/s1.jpg";
    $s2_background = "mototraktor/s2.jpg";
    $s3_background = "mototraktor/s3.jpg";
    $s4_background = "mototraktor/s4.jpg";
    $s5_background = "mototraktor/s5.jpg";
    $phone = phone.$phone;
    $recall_dialog = '�� ����������!';
    $first_form = {
        'class' : 'first-form-box first-form-box-redesign',
        'background' : 'form-first/4.png',
        'body': `			<div class="first-form-title first-form-title-redesign">
                                ������ ����� ������ <br>
                                ������������ <br>
                                ��
                                <span>
                                
                                </span>
                            </div>

                            <img class="first-form-img first-form-img-redesign first-form-img__boz-shadow" src={ require("../../images/form-first/gift4.jpg") }>

                            <div class="first-form-gift first-form-gift-redesign">
                                � �������� ������-����� �� 1.25 � <br>
                                � �������  <br>
                                <span>
                                    � �������!
                                </span>
                            </div>`,
  'form':  `<form id="contactForm" class="first-form first-form-redesign" novalidate="">
                                <ol>
                                    <li class="form-group">
                                      <input id="name" name="name" type="text" placeholder="���� ���" required="" data-validation-required-message="������� ���� ���" aria-invalid="false">
                                      <p class="help-block text-danger"></p>
                                    </li>
                                    <li class="form-group">
                                      <input id="phone" name="phone" type="text" placeholder="+38 ( _ _ _ ) _ _ _-_ _-_ _" required="" data-validation-required-message="������� ���� �������">
                                      <p class="help-block text-danger"></p>
                                    </li>
                                    <li class="form-group">
                                      <input id="email" name="email" type="text" placeholder="��� e-mail" required="" data-validation-required-message="������� ���� email">
                                      <p class="help-block text-danger"></p>
                                    </li>
                                    <li class="form-group">
                                        <button onclick="ga('send','event','button','send_offer')" class="btn btn-md btn-primary bt-popup bt-first-form bt-first-form-redesign">�������� <br><span>����������� ����� � ������</span></button>
                                    </li>
                                </ol>
            </form>`
        };
    
}

export let params: ModuleInfo = new DefaultInfo();