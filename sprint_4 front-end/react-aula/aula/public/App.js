// como importar um arquivo de fora 
// ex: uma img em svg
// o css 
// isso se faz desta maneira: './nomeDoArquivo.(alguma coisa)';
import React from 'react';
import './App.css';

// define uma função que retorna o subtítulo
// c a data formatada
function DataFormatada(props) {
  return <h2>Horário Atual: {props.date.toLocaleTimeString()}</h2>
}

// criação da classe (em js)
// essa classe será chamada na renderização do app
// dentro da function app
// essa classe esta sendo herdada d um componente react
class Clock extends React.Component {
      constructor(props){

      // serve para que possamos utilizar o this
      super(props)

      // as propriedades (estados), esão dentro do "this.state"
      this.states = {
      // aqui dentro terá as variáves(states)
      // define o estado date pegando a data
      // e hora atual
        date : new Date()
    };
  }

  // utilizar os ciclos de vida

  // ciclo de vida do nascimento
  // função será invocada automaticamento quando a classe clock
  // for renderizada, ou seja, quando chamarmos na function app
  componentDidMount(){
    
  }

  // outro ciclo de vida

  // quando a classe clock for removida da DOM, 
  // tudo que colocarmos dentro dessa função, irá acontecer
  // um exemplo é quando trocarmos de página
  componentWillUnmount(){
     
  }

  // função para simular um comportamento de rolagem
  // meio que uma mudança de tela
  thick(){
    // função atualizar os valores do state
    // indicando quem vamos atualizar
    this.setState({
      // aqui colocamos quem vamos atualizar
      // e o novo valor
       date : new Date()
    })
  }

  render(){
    return (
      <div> 
        <h1>Relógio</h1>
        <DataFormatada  date={this.state.date}/>
      </div>
    )
  }
}




// função para renderizar a tela, ou seja
// exibir os conteúdos solicitados
// função em js chamada App 
function App() {
  // ela retorna o codigo em html
  return (
    <div className="App">
      <header className="App-header">
        <Clock/>
        <Clock/>
      </header>
    </div>
  );
}

export default App;
