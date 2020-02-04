import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';

ReactDOM.render(<App />, document.getElementById('root'));

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();

// let $: any;

// (function ($) {
//     //var o = $('.rd-navbar');
//     //if (o.length > 0) {
//         $(document).ready(function () {
//             o.RDNavbar({
//                 stuckWidth: 768,
//                 stuckMorph: true,
//                 stuckLayout: "rd-navbar-static",
//                 responsive: {
//                     0: {
//                         layout: 'rd-navbar-fixed',
//                         focusOnHover: false
//                     },
//                     768: {
//                         layout: 'rd-navbar-fullwidth'
//                     },
//                     1200: {
//                         layout: o.attr("data-rd-navbar-lg").split(" ")[0],
//                     }
//                 },
//                 onepage: {
//                     enable: false,
//                     offset: 0,
//                     speed: 400
//                 }
//             });
//         });
//     }
//     })($);