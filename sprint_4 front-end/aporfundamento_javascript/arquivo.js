// criar uma funçãp
function novaFuncao(){

}

// criar um objeto
var meuCarro = new Object();
meuCarro.fabricacao = "Ford";
meuCarro.modelo = "Mustang";
meuCarro.ano = 1969;

// class wm ja

class Nomes{
    // necessário um método construtor 
    // e dentro dele passar os parâmetros
    constructor(nome, sobrenome){
        this.nome = nome;
        this.sobrenome = sobrenome;
    }
}

// subclasse
class Animal{
    constructor(nome){
        this.nome = nome;
    }

    // método

    falar() {
        console.log(this.nome + 'emite um barulho.');

    }
}

// override/ sobreescrever/ herdar da classe animal
class Cachorro extends Animal {
    falar(){
        console.log(this.nome + ' latidos. ');
    }
}

let cachorro = new Cachorro('Mat');
cachorro.falar();

// DOM


