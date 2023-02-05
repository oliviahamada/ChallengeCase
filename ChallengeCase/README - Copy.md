# ChallengeCase 

Esta � uma solu��o chamada ChallengeCase.  
Esta solu��o visa calcular o imposto a ser pago sobre lucros ou preju�zos de opera��es no mercado financeiro de a��es.


*******

## Introduction 
> **Warning**: Leia com aten��o 


 1. [Premissas](#premissas)
 2. [Par�metros](#parametros)
 3. [Dados de entrada](#entrada)
 4. [Dados de sa�da](#saida)
 5. [Sintaxe de Markdown](#syntax)

*******

<div id='premissas'/> 

## Premissas  
 * **Arquivos de entrada**:
	- O arquivo de entrada deve estar no formato `.json`.
	- O valor de entrada a ser inserida na solu��o **deve** ser o caminho raiz do arquivo. Ex.: Se o arquivo a ser consumido � o `C:\Documents\Json\entrada.json`, voc� dever� inserir apenas o caminho `C:\Documents\Json`, a solu��o ir� consumir todos os arquivos presentes neste diret�rio.
	- Assume-se que todos os arquivos seguir�o o formato de input correto (voc� pode encontrar um [exemplo](https://github.com/oliviahamada/ChallengeCase/blob/master/ChallengeCase/Helper/json/exemplo.json) dentro da pasta Helper/json).
 </br>
 * **Arquivos de sa�da**:
	- A solu��o ir� armazenar o arquivo de sa�da dentro da pasta configurada no par�mentro `NEW_FOLDER_NAME` (para mais detalhes, clique [aqui](#parametros)). N�o ser� necess�rio criar ou deletar a pasta, a solu��o � respons�vel por isso.

*Recomendo utilizar apenas 3 arquivos para consumo.*


<div id='parametros'/>

## Par�metros 

Para a solu��o, foram utilizados os seguintes par�metros:
 * **BUY** : Indica que a opera��o � de **compra**. Valor default `buy`.
 * **SELL** : Indica que a opera��o � de **venda**. Valor default `sell`.
 * **NEW_FOLDER_NAME** : Indica o nome da pasta onde ser�o salvos o resultado das opera��es. Valor default `Results`.
 * **MIN_VALUE** : Indica o valor m�nimo da opera��o para cobran�a de imposto, se o valor for maior ou igual ao valor parametrizado, um valor de imposto dever� ser pago. Valor default `20000`.
 * **IMPOSTO_PERCENT** : Indica o percentual do imposto a ser pago.
 </br>
 **Warning**: Alterar esses valores pode implicar na execu��o do c�lculo. 


<div id='entrada'/>

## Dados de entrada
Porque � :
 * **F�CIL** : A sintaxe � t�o f�cil que voc� pode aprender em um minuto ou dois, em seguida, escreva sem perceber nada estranho ou nerd.
 * **R�PIDO** : Ele economiza tempo em compara��o com outros tipos de arquivos / formatos de texto. Isso ajuda a aumentar a produtividade e os fluxos de trabalho do escritor.
 * **LIMPO** : Tanto a sintaxe como a sa�da s�o limpas, sem confus�o com nossos olhos e simples de gerenciar.
 * **FLEX�VEL** : Com apenas algumas configura��es, o seu texto ser� traduzido atravessando qualquer plataforma l� fora, edit�vel em qualquer software de edi��o de texto e convers�vel para uma ampla variedade de formatos.
<br></br>
**Em resumo**, os usu�rios comuns achar�o �til em todos os casos, especialmente quando voc� precisar de algo melhor que o texto simples, mas menos funcional do que o Microsoft Word.  
**Para desenvolvedores**, Se voc� � pregui�oso para escrever c�digo HTML, voc� vai adorar o markdown. **Al�m disso**, **Github** e muitos sites favorecem o markdown para o arquivo readme de projetos. Isso significa que voc� vai encontrar o markdown em sua vida de uma forma ou de outra.  
<div id='tools'/>  

<div id='saida'/>
## Dados de sa�da
Conforme mencionado acima, qualquer editor pode ser usado para editar o markdown. No entanto, existem algumas ferramentas que podem ser �teis para voc� quando se trata de editar markdown.
 * **[*Stackedit*](https://stackedit.io)** : Ok, voc� pode parar de ler agora. Clique no link e, em seguida, comece o seu turno de markdown de uma maneira mais r�pida. Basta digitar o texto normal e depois usar o mouse, clique no bot�o. Voc� n�o precisa saber a sintaxe. � bom, mas far� voc� dependende, e a maioria dos desenvolvedores prefere os teclados.
 * **[*Dillinger*](http://dillinger.io/)** : Ferramenta on-line, suporte em exibi��o ao vivo (tela dividida) e exporta��o para html. Nada muito especial, mas muito limpo e acess�vel.
 * **[*Typora*](https://www.typora.io/)** : Dispon�vel para Mac e Windows, m�nimo, livre de distra��o, vista ao vivo sem parecer, empacotada com muitas outras coisas como Imagens, Listas, Tabelas, Cercas de C�digo, Blocos de Matem�tica, YAML, Front Matters, Toc, ...
 * **[*Atom*](https://atom.io/)** : Editor de texto popular hacke�vel (voc� pode estar usando isso). Sim, isso � vers�til. Suporte Markdown? Apenas uma parte disso, mas � muito constru�do.
 * **[*Minimalist Markdown*](https://chrome.google.com/webstore/detail/minimalist-markdown-edito/pghodfjepegmciihfhdipmimghiakcjf?hl=en)** : Aplicativo do Google Chrome. Funciona em todos os lugares se voc� tiver o Chrome instalado (este � o meu favorito).
 * **[*Macdown*](http://macdown.uranusjr.com/)** : O Melhor para Mac.
 * **[*MarkdownPad*](http://markdownpad.com/)** : O Melhor para Windows.
 * **[*Remarkable*](https://remarkableapp.github.io/)** : O Melhor para Linux. 
 * **[*GITBOOK*](http://www.gitbook.com/)** : O GitBook � uma ferramenta de publica��o moderna. Facilitando a escrita e a colabora��o. Ambos suportam a Markdown e t�m uma estreita rela��o com o amado Github.
 


## Build e Testes
TODO: Describe and show how to build your code and run the tests. 

## Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)


###### Author: *Vo Tran Thanh Luong*. Also, I would like to thank all the contributors/translators for your work making this greater.
 
###### Autor: *Vo Tran Thanh Luong*.
###### Tradu��o: *H�ricles Emanuel*.
###### Corre��es: [*Alexander Santos*](https://github.com/Ronkiro).