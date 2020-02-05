import { ModuleInfo } from './module-info';

class TractorsInfo implements ModuleInfo { 
    $logo = 'images/logo.png';
    $menu = Array('Главная', 'Преимущества', 'Рассчитать', 'Отзывы', 'Контакты');
}

export let params: ModuleInfo = new TractorsInfo();