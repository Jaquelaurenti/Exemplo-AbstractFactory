## Abstract Factory

O padrão Abstract Factory é o primeiro Pattern descrito no livro Design Patterns do GoF. 
Ela faz parte da categoria de Patterns Criacionais, cujo objetivo é a instanciação de objetos. 
Essa categoria é importante pois ela sustenta o princípio mais importante do livro: “programe para interfaces e não para implementações”.
Atualmente, os Patterns Criacionais estão em desuso, sendo substituídos pelos frameworks de Injeção de Dependência, que fazem exatamente isso: instanciam para você as classes das quais você é dependente. De toda forma, conhecer os patterns, a sua motivação e entender as suas consequências é um bom exercício de design de software.

## Consequências: 
Temos a vantagem de utilizamos apenas classes abstratas ou interfaces, o que diminui muito o acoplamento entre as classes do sistema, assim como podemos adicionar, modificar ou remover produtos da família de forma rápida. Mas temos como ponto negativo que a adição ou remoção de famílias exige a modificação da AbstractFactory, o que causa um grande overhead, pois deve-se modificar todas as implementações da Factory e o cliente que usa a AbstractFactory;


## Conclusão
Facilita bastante quando trabalhamos com aplicações que devem funcionar com ambientes diferentes, como interfaces gráficas, sistemas de banco de dados diferentes, mas onde temos bases comuns, apenas com comportamentos específicos definidos para cada “ambiente”.

Referências: https://www.dofactory.com/net/abstract-factory-design-pattern

https://medium.com/@gbbigardi/arquitetura-e-desenvolvimento-de-software-parte-2-abstract-factory-f603ccc6a1ea
