# testeSingletonCsharp

Testes sobre Singleton com C#

O singleton evita instanciar uma classe mais de uma vez, tornando-a statica durante a execução do software.

Neste teste criei duas classes que são responsáveis por retornar a soma de dois número.

Em uma das classes (soma) utilizei o singleton e na classe soma2 não utilizei.

Dentro do construtor de cada classe indiquei para logar o status quando a classe for instanciada.

No arquivo principal da aplicação instanciei cada classe duas vezes, sempre com nomes diferente para não gerar conflito e loguei o resultado de algumas somas.

O resultado do teste é que quando utilizado singleton foi sempre utilizada a primeira instancia criada.

Quando não utilizada cada vez que é que a classe é instanciada é criada uma nova instancia.
