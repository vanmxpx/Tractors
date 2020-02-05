import { ModuleInfo } from './module-info';

class DefaultInfo implements ModuleInfo { 
    $logo = 'images/logo.png';
    $menu = Array('Главная', 'Преимущества', 'Рассчитать', 'Отзывы', 'Контакты');
}

export let params: ModuleInfo = new DefaultInfo();