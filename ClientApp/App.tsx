import React from 'react';
import './App.css';

import './index.css';
import {
    BrowserRouter as Router,
    //useParams
} from "react-router-dom";
import HeaderModule from './components/header-module/header';
import { ModuleInfo } from './landings/module-info';
import MainModule from './components/main-module/main-module';

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
    //let query = useParams().query;
    let $utm_content;// = query.get("utm_content");
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
                $utm_content={$utm_content}
            ></HeaderModule>
            <MainModule
                params={params}
                $utm_content={$utm_content}
            >

            </MainModule>
            {/* <div id="intro">
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
            </div> */}
        </div>
    );
}
export default App;
