import React from 'react';
import logo from './logo.svg';
import './App.css';
import { Parallax } from 'react-parallax';
import Board from './components/board';

const App: React.FC = () => {
    return (
        
        <div className="App">
            <MyComponent></MyComponent>
            <div className="game">
                <div className="game-board">
                    <Board />
                </div>
                <div className="game-info">
                    <div>{/* status */}</div>
                    <ol>{/* TODO */}</ol>
                </div>
            </div>
            <header className="App-header">
                <img src={logo} className="App-logo" alt="logo" />
                <p>
                    Edit <code>src/App.tsx</code> and save to reload.
                </p>
                <a
                    className="App-link"
                    href="https://reactjs.org"
                    target="_blank"
                    rel="noopener noreferrer"
                >
                    Learn React
                </a>
            </header>
        </div>
    );
}

const MyComponent: React.FC = () => {
    return (
        <div>
            <Parallax
            
                blur={{ min: -15, max: 15 }}
                bgImage={require('./assets/squirel.jpeg')}
                bgImageAlt="the dog"
                strength={-200}
            >
            <div style={{ height: '200px', display:'flex', justifyContent: 'center', alignItems: 'center' }}> 
            <div>test</div> 
            </div>
            </Parallax>
{/* 
            <Parallax
                bgImage={'./assets/squirel.jpeg'}
                strength={400}
                renderLayer={percentage => (
                    <div
                        style={{
                            position: 'absolute',
                            background: `rgba(255, 125, 0, ${percentage * 1})`,
                            left: '50%',
                            top: '50%',
                            width: percentage * 500,
                            height: percentage * 500,
                        }}
                    />
                )}
            >
                <p>... Content</p>
            </Parallax> */}
        </div>
    )
};

export default App;
