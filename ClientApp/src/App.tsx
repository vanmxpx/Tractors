import React from 'react';
import './App.css';
import Menu from './components/menu';
import WelcomeModule from './components/page-modules/welcome-module/welcome-module';

const App: React.FC = () => {
    return (
        
        <div className="App">
            <Menu
                onClick={ () => {} }
                value={ '' }
            >

            </Menu>

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
