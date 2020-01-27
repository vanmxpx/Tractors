import React from 'react'
import './board.css';

interface BoardState { 
    squares: string[]
    xIsNext: boolean,
    winner: string | null
}
interface SquareProps extends React.Props<any> {
    value: string,
    onClick: () => void
};
export default class Board extends React.Component<any, BoardState> {
    state: BoardState = { 
        squares: Array(9).fill(null),
        xIsNext: true,
        winner: null
    }

    handleClick(i: number) { 
        if (this.state.winner) {
            return;
        }
        const squares = this.state.squares.slice();
        squares[i] = this.nextPlayerSymbol();
        const winner = this.calculateWinner(squares);
        this.setState({ 
            squares: squares, 
            xIsNext: !this.state.xIsNext, 
            winner: winner 
        });
    }

    nextPlayerSymbol(): string {
        return this.state.xIsNext ? 'X' : 'O';
    }

    calculateWinner(squares: string[]): string | null {
        const lines = [
          [0, 1, 2],
          [3, 4, 5],
          [6, 7, 8],
          [0, 3, 6],
          [1, 4, 7],
          [2, 5, 8],
          [0, 4, 8],
          [2, 4, 6],
        ];
        for (let i = 0; i < lines.length; i++) {
          const [a, b, c] = lines[i];
          if (squares[a] && squares[a] === squares[b] && squares[a] === squares[c]) {
            return squares[a];
          }
        }
        return null;
    }
    
    render() {
        
        let status;
        if (this.state.winner) {
            status = 'Winner: ' + this.state.winner;
        } else {
            status = `Next Player: ${this.nextPlayerSymbol()}`;
        }

        return (
            <div>
                <div className="status">{status}</div>
                <div className="board-row">
                    {this.renderSquare(0)}
                    {this.renderSquare(1)}
                    {this.renderSquare(2)}
                </div>
                <div className="board-row">
                    {this.renderSquare(3)}
                    {this.renderSquare(4)}
                    {this.renderSquare(5)}
                </div>
                <div className="board-row">
                    {this.renderSquare(6)}
                    {this.renderSquare(7)}
                    {this.renderSquare(8)}
                </div>
            </div>
        );
    }

    renderSquare(index: number) {
        return (
            <Square 
                onClick={() => this.handleClick(index) } 
                value={this.state.squares[index]}
            ></Square>
        );
    }
}

export const Square: React.FC<SquareProps> = (props) => {
    return (
        <button
            className="square"
            onClick={props.onClick}
        >
            {props.value}
        </button>
    );
}