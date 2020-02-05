import React from 'react'
import './header.scss';
import { ModuleProps } from '../../App';

interface HeaderState { 
    xIsNext: boolean,
    winner: string | null
}
export default class HeaderModule extends React.Component<ModuleProps, HeaderState> {
    state: HeaderState = { 
        xIsNext: true,
        winner: null
    }
    navbarItem(content: string, href: string, text: string) {
        if(this.props.$utm_content === content) {
            return (
                <li>
                    <a href={href}>
                        <span>{text}</span>
                    </a>
                </li>
            );
        } else {
            return null;
        }
    }
    navbarItemS3() {
        if(this.props.params.$s3) {
            return (
                <li>
                    <a href="#advantages">
                        <span>{this.props.params.$menu[3]}</span>
                    </a>
                </li>
            );
        } else {
            return null;
        }
    }

    videoMototractor() {
        if(this.props.$utm_content === 'mototraktor_kupit_vd') {
            return (
                <section id="video" style={{ height: "70%", width: "100%" }}>
                   <div className="relative-block" style={{position: 'relative'}}>
                        <div className="video-block" style={{display: 'block'}}>
                            <video playsinline autoPlay muted loop width="100%" id="video1" style={{ display: "inline-block" }}>
                                <source src="https://tdtz.in.ua/video/minitracktor.mp4" type="video/mp4"></source>
                            </video>
                        </div>
                    </div>
                </section>
            );
        } else {
            return null;
        }
    }

    this1Credit() {
        if(this.props.params.$this1_credit) {
            return (
                <div>
                    <div className="but-text">{ this.props.params.$but_text_credit }</div>
                    <div className="this">
                        <div className="this1"> <img src="images/star.png"  alt="" /> {this.props.params.$this1_credit[0]}</div>
                        <div className="this2"> <img src="images/star.png"  alt="" /> {this.props.params.$this1_credit[1]}</div>
                        <div className="this3"> <img src="images/star.png"  alt="" /> {this.props.params.$this1_credit[2]}</div>
                    </div>
                </div>
            );
        } else {
            return null;
        }
    }
    butText() {
        if(this.props.params.$but_text) {
            return (
                <div className="but-text">{this.props.params.$but_text}</div>
            );
        } else {
            return null;
        }
    }
    this1() {
        if(Array.isArray(this.props.params.$this1)) {
            return (
                <div className="this">
                    <div className="this1"> <img src="images/star.png"  alt=""/> {this.props.params.$this1[0]}</div>
                    <div className="this2"> <img src="images/star.png"  alt=""/> {this.props.params.$this1[1]}</div>
                    <div className="this3"> <img src="images/star.png"  alt=""/> {this.props.params.$this1[2]}</div>
                </div>
            );
        } else if (this.props.params.$this1 == 'запч' || this.props.params.$this1 == 'запч_кред') {
            return (
                <div className="container">
                    <div className="row kredit-box">
                        <div className="col-xs-6 col-sm-4 col-md-2 col-lg-2 text-center " >
                            <img src="images/tm-logo/foton.png" alt=""/>
                        </div>
                        <div className="col-xs-6 col-sm-4 col-md-2 col-lg-2 text-center " >
                            <img src="images/tm-logo/2.png" alt=""/>
                        </div>
                        <div className="col-xs-6 col-sm-4 col-md-2 col-lg-2 text-center " >
                            <img src="images/tm-logo/dfm.png" alt=""/>
                        </div>
                        <div className="col-xs-6 col-sm-4 col-md-2 col-lg-2 text-center " >
                            <img src="images/tm-logo/1.png" alt=""/>
                        </div>
                        <div className="col-xs-6 col-sm-4 col-md-2 col-lg-2 text-center " >
                            <img src="images/tm-logo/dw.png" alt=""/>
                        </div>
                        <div className="col-xs-6 col-sm-4 col-md-2 col-lg-2 text-center " >
                            <img src="images/tm-logo/3.png" alt=""/>
                        </div>
                    </div>

                    <div className="row kredit-box2">
                        <div className="col-xs-12 col-sm-12 col-md-12 col-lg-12 text-center " >
                            <div>Jinma (Mahindra)</div>
                            <div>YTO</div>
                            <div>Xingtai</div>
                            <div>FengShou</div>
                            <div>Luzhong</div>
                            <div>Changlin Deutz-Fahr</div>
                            <div>ДТЗ</div>
                            <div>Forte</div>
                        </div>
                    </div>
                </div>
            );
        } else if (this.props.params.$this1 == 'запч2' || this.props.params.$this1 == 'запч_кред2') {
            let header = this.props.params.$ukr ? 
                (<h1><span className="mini-t">Оригінальні запчастини для мотоблоків</span></h1>) : 
                (<h1><span className="mini-t"> ОРИГИНАЛЬНЫЕ ЗАПЧАСТИ ДЛЯ МОТОБЛОКОВ</span></h1>)
            return (
                <div className="row kredit-box">
                    <div className="container">
                        <div className="row logotm-box1">
                            {header}
                            <div className="logotm-item1">
                                <img src="images/zapchasti_motoblok/logo/15-kentavr.png"alt=""/>
                            </div>
                            <div className="logotm-item1">
                                <img src="images/zapchasti_motoblok/logo/16-zubr.png"alt=""/>
                            </div>
                            <div className="logotm-item1">
                                <img src="images/zapchasti_motoblok/logo/17-forte.png"alt=""/>
                            </div>
                            <div className="logotm-item1">
                                <img src="images/zapchasti_motoblok/logo/18-gardenScout.png"alt=""/>
                            </div>
                            <div className="logotm-item1">
                                <img src="images/zapchasti_motoblok/logo/WEIMA.png"alt=""/>
                            </div>
                            <div className="logotm-item1">
                                <img src="images/zapchasti_motoblok/logo/neva.png"alt=""/>
                            </div>
                            <div className="logotm-item1">
                                <img src="images/zapchasti_motoblok/logo/sadko.png"alt=""/>
                            </div>
                            <div className="logotm-item1">
                                <img src="images/zapchasti_motoblok/logo/salut.png"alt=""/>
                            </div>
                            <div className="logotm-item1">
                                <img src="images/zapchasti_motoblok/logo/zirka.png"alt=""/>
                            </div>
                        </div>
                    </div>
                </div>
            );
        } else if (this.props.params.$this1 == 'запч3' || this.props.params.$this1 == 'запч_кред3') {
            let header = this.props.params.$ukr ? 
                (<h1><span className="mini-t">Оригінальні запчастини для мiнiтракторів</span></h1>) : 
                (<h1><span className="mini-t">ОРИГИНАЛЬНЫЕ ЗАПЧАСТИ К МИНИТРАКТОРАМ</span></h1>)
            return (
                <div className="row kredit-box">
                    <div className="container">
                        <div className="row logotm-box2">

                            {header}

                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/1-foton.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/10-chery.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/11-shifeng-group.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/12-belarus.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/13-iseki.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/14-kioti.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/2-dfam.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/3-jinma.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/4-YTO.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/5-dtz.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/6-bulat.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/7-xingtai.png"alt=""/>
                            </div>
                            <div className="logotm-item2 item-l">
                                <img src="images/zapchasti_minitraktor/logo/8-deutzFahr.png"alt=""/>
                            </div>
                            <div className="logotm-item2">
                                <img src="images/zapchasti_minitraktor/logo/9-dw.png"alt=""/>
                            </div>
                        </div>
                    </div>
                </div>
            );
        } else {
            return null;
        }
    }

    render() {

        return (
            <header id="intro" className="page-header">

            <div className="rd-navbar-wrap" style={ this.props.params.$disable_menu ? { display: 'none'} : {} }>
                <nav className="rd-navbar" data-rd-navbar-lg="rd-navbar-fixed">
                    <div className="rd-navbar-inner">

                        <div className="rd-navbar-panel">

                            <button className="rd-navbar-toggle" data-rd-navbar-toggle=".rd-navbar"><span></span></button>


                            <div className="rd-navbar-brand">

                                    <span className="icon icon-md icon-primary icon-primary-variant-1">
                                        <img src={ this.props.params.$logo }></img>
                                    </span>

                            </div>

                        </div>

                        <div className="rd-navbar-nav-wrap">

                            <ul className="rd-navbar-nav">
                                <li>
                                    <a href="#intro">
                                        <span>{ this.props.params.$menu[0] }</span>
                                    </a>
                                </li>
                                {this.navbarItem('mototraktor_kupit_v2', '#vidos', this.props.params.$menu[2])}
                                <li>
                                    <a href="#information">
                                        <span>{this.props.params.$menu[1]}</span>
                                    </a>
                                </li>

                                
                                {this.navbarItem('mototraktor_kupit_v2', '#models', this.props.params.$menu[3])}
                                {this.navbarItem('pricep', '#models', this.props.params.$menu[2])}
                                {this.navbarItem('pochvofrez', '#models', this.props.params.$menu[2])}
                                {this.navbarItemS3()}

                                <li>
                                    <a href="#tractors">
                                        <span>{this.props.params.$menu[4]}</span>
                                    </a>
                                </li>

                                <li>
                                    <a href="#contacts">
                                        <span>{this.props.params.$menu[5]}</span>
                                    </a>
                                </li>
                            </ul>

                        </div>
                    </div>
                </nav>
            </div>

            {this.videoMototractor()}
            

            <section className="well-xl1 bg-image bg-fixed position__relative" style={{ backgroundImage: `url(${this.props.params.$s1_background})`}} >

                <div className="container">

                    <div className="row row-md-justify text-lg-left">
                        <div className="col-md-2">
                            <address className="contact-info">
                                <div className="box">
                                    <div className="box__cnt">
                                        <span className="free-phone ringo-del">
                                            <a href="callto:#">
                                                <span className="ringo-phone">
                                                    <span className="oper">+38&nbsp</span>
                                                        <div className="code-wrap">
                                                            <span className="ks">
                                                                <img src="images/ks.png" alt="" width="20" />(068)
                                                            </span>
                                                            <span className="vd">
                                                                <img src="images/vd.png" alt="" width="20" />(050)
                                                            </span>
                                                            <span className="lc">
                                                                <img src="images/lc.png" alt="" width="20"/>(073)
                                                            </span>
                                                        </div>
                                                    <span className="reshta">{ this.props.params.$phone[0] }</span>
                                                </span>
                                            </a>
                                        </span>
                                    </div>
                                    <a href="#recall-dialog" title="Кнопка Мы перезвоним" className="we-call-back popup-with-zoom-anim">{this.props.params.$recall_dialog}</a>
                                </div>
                            </address>
                        </div>
                        <div className="col-md-preffix-1 col-md-3 col-lg-2">

                            <div className="rd-navbar-brand">

                                    <span className="icon icon-md icon-primary icon-primary-variant-2">
                                        <img src={this.props.params.$logo}></img>
                                    </span>

                            </div>

                        </div>
                    </div>

                    {/* /<?php if(isset($first_form)): ?> */}
                    <div className={ this.props.params.$first_form ? 'row' : '' }>
                    <div className={ this.props.params.$first_form ? "col-xs-12 col-sm-12 col-md-7 col-lg-7 text-left form-first-col" : '' } >
                    {/* <?php endif; ?> */}

                        <h1 style={ this.props.params.$s1_h1_style ? this.props.params.$s1_h1_style : {} }>
                            {this.props.params.$s1_h1}
                        </h1>

                        {this.this1Credit()}
                        
                        {this.butText()}

                        {this.this1()}

						<?if($this1=='кред' || $this1=='запч_кред' || $this1=='запч_кред2' || $this1=='запч_кред3'):?>
                           <?if(isset($but_text_kred)):?>
                                <div className="but-text"><?=$but_text_kred?></div>
                            <?endif;?>
							<div className="this">
                                <a href="#order-dialog" className="btn btn-md btn-primary bt-line bt1 popup-with-zoom-anim" style="" >
                                    <?=$s1_bt1?>
                                </a>
								<a className="btn btn-md btn-primary bt-line bt-credit" href="javascript:void(0)" type="button" onclick="if (typeof(kreditmarket_popup_win)!='undefined') kreditmarket_popup_win.close(); kreditmarket_popup_win=window.open('https://agents.kreditmarket.ua/partners/_general/v01/?uid=ho2q467358049410&product_id=<?=$product_id?>&product_name=<?=$product_name?>&product_price=<?=str_replace(" ","",$price)?>&product_url=<?=$_SERVER["HTTP_HOST"] . $_SERVER["REQUEST_URI"]?>', 'gener','width=780,height=360,top='+((screen.height-360)/2)+',left='+((screen.width-780)/2)+',toolbar=no,location=no,directories=no,status=no,menubar=no,scrollbars=no,resizable=no')">
                                    <span>
                                        РАССЧИТАТЬ <br>
                                        <span>самостоятельно</span>
                                    </span>
                                    <img src="images/calc.png"  alt="">
                                </a>
							</div>

						<?else:?>
                            <a href="#order-dialog" className="btn btn-md btn-primary bt1 popup-with-zoom-anim" style="<?if($this1=='кред') {echo 'font-weight: 300;padding: 12px 28px 10px;';}?>" >
    							<?=$s1_bt1?>
    						</a>
                        <?endif;?>


                    <?php if(isset($first_form)): ?></div><?php endif; ?>

                    <?php if(isset($first_form)): ?>
                        <div className="col-xs-12 col-sm-12 col-md-5 col-lg-5 text-left form-first-col" style="">
                            <div className="<?= $first_form['class']?>" style="background-image: url(<?= $first_form['background']?>);">
                                <?= $first_form['body']?>
                                <?= $first_form['form']?>
                            </div>
                        </div>
                        </div>
                    <?php endif; ?>

                </div>
                
                {/* <?php if($utm_content === 'minitraktor_zubr' ||
                         $utm_content === 'mototraktor_kupit_video' ||
                         $utm_content === 'mototraktor_kupit_vd-ua' ||
                         $utm_content === 'mototraktor_bulat-120' || 
                         $utm_content === 'mototraktor_kupit_v2' || 
                         $utm_content === 'mototraktor_kredit_v2' ||
                         $utm_content === 'mototraktor_dostavka_v2' ||
                         $utm_content === 'mototraktor_chernivci-ua' || 
                         $utm_content === 'mototraktor_chernovci' ||
                         $utm_content === 'mototraktor_garden-scout-t15' ||
                         $utm_content === 'mototraktor_garden-scout-t18' ||
                         $utm_content === 'mototraktor_khmelnitsky' ||
                         $utm_content === 'mototraktor_yarilo' || 
                         $utm_content === 'mototraktor_kyiv' ||
                         $utm_content === 'mototraktor_ukr' ||
                         $utm_content === 'mototraktor_lviv_v2'): ?>
                    <!--<div className="videoContainer">
                        <div className="overlay"></div>
                        <video playsinline autoplay muted loop width="100%" className="video-bg">
                            <source src="https://tdtz.in.ua/video/dmtz-160.mp4" type="video/mp4">
                        </video>
                    </div>-->
                <?php endif; ?> */}
                
                

            </section>

        </header>
        );
    
    }
}