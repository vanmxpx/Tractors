import React from 'react'
import './main-module.scss';
import { ModuleProps } from '../../App';

export default class MainModule extends React.Component<ModuleProps> {
    isAdvantages() {
        if(this.props.params.$advantages_block) {
            return this.props.params.$advantages_block;
        } else {
            return null;
        }
    }

    render() {

        return (
            <main className="page-content" style={ this.props.params.$disable_main ? { display: 'none' } :  {} }>
                {/* {this.isAdvantages()} */}
            </main>
        );
    
    }
}