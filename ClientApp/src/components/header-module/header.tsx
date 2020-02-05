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
    render() {

        return (
            <div></div>
        );
    }
}