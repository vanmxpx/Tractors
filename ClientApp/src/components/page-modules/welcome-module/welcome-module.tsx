import React from 'react';
import './welcome-module.scss';
import { Parallax } from 'react-parallax';

const WelcomeModule: React.FC = () => {
    return (
        
        <div className="welcome-module-wrapper">
            <Parallax
                className="welcome-module-parallax"
                contentClassName="welcome-module-content"
                bgImage={require('./squirel.jpeg')}
                bgImageAlt="the dog"
                strength={300}
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
