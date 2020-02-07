import React from 'react';
import './App.css';
import WelcomeModule from './components/page-modules/welcome-module/welcome-module';
import {
    BrowserRouter as Router,
    useLocation
  } from "react-router-dom";
import HeaderModule from './components/header-module/header';
import { ModuleInfo } from './landings/module-info';

export interface ModuleProps extends React.Props<any> {
    params: ModuleInfo,
    $utm_content: string | null
};

const App: React.FC = () => {
    return (
        <Router>
            <LandingBody />
        </Router>
    );
}

const LandingBody: React.FC = () => {
    let query = new URLSearchParams(useLocation().search);
    let $utm_content = query.get("utm_content");
    let params;
    if ($utm_content) {
        params = require("./landings/" + $utm_content + ".tsx").params;
    } else { 
        params = require("./landings/mototraktor_kupit_v2.tsx").params;
        console.log(params);
    }
    return (
        <div className="page text-center">
            <HeaderModule
                params={params}
                $utm_content = {$utm_content}
            ></HeaderModule>

            <div id="intro">
                <WelcomeModule >

                </WelcomeModule>
            </div>
            <div id="vidos">
                <WelcomeModule >

                </WelcomeModule>
            </div>
            <div id="information">
                <WelcomeModule >

                </WelcomeModule>
            </div>
            <div id="models">
                <WelcomeModule >

                </WelcomeModule>
            </div>
        </div>
    );
}
export default App;
