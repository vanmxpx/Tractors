import React from 'react';
import './welcome-module.scss';
import { Parallax } from 'react-parallax';

const WelcomeModule: React.FC = () => {
    return (
        
        <div className="welcome-module-wrapper">
            <Parallax
                className="welcome-module-parallax"
                bgClassName="welcome-welcome-module-content-bg"
                contentClassName="welcome-module-content"
                bgImage={require('./back1.jpg')}
                bgImageAlt="the dog"
                strength={1600}
            >
                
                <div
                    className="welcome-module-content-2"
                > 
                    <div>test</div> 
                </div>
            </Parallax>
        </div>
    );
}

export default WelcomeModule;
