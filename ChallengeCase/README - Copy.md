# Introduction 
TODO: Give a short introduction of your project. Let this section explain the objectives or the motivation behind this project. 

# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Build and Test
TODO: Describe and show how to build your code and run the tests. 

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)

































# ChallengeCase 

Esta é uma solução chamada ChallengeCase.  
Esta solução visa calcular o imposto a ser pago sobre lucros ou prejuízos de operações no mercado financeiro de ações.


*******
>
> **Note**:
> 
> **Warning**: Tabelas de conteúdo 
 1. [O que é Markdown?](#whatismarkdown)
 2. [Porque usar Markdown?](#why)
 3. [Ferramentas para Markdown](#tools)
 4. [Sintaxe de Markdown](#syntax)

*******

<div id='whatismarkdown'/>  

## O que é Markdown ?  
De acordo com a Wikipedia :  

  >*Markdown é uma linguagem de marcação leve com sintaxe de formatação de texto simples projetada para que ela possa ser convertida em HTML e muitos outros formatos usando uma ferramenta com o mesmo nome. Markdown é usado frequentemente para formatar arquivos readme, para escrever mensagens em fóruns de discussão on-line e para criar texto rico usando um editor de texto simples.*   

`SIMPLESMENTE: É APENAS OUTRO TIPO DE ARQUIVO DE TEXTO, COMO .txt .doc .... (agora é .md :risos:) E COM UMA SINTAXE ESPECIAL.`  
<div id='why'/>  

*Não existe um padrão de Markdown claramente definido. Isso levou à fragmentação, pois fornecedores diferentes escrevem suas próprias variantes do idioma para corrigir falhas ou adicionar recursos faltantes. Uma lista de versões de Markdown está disponível [aqui](https://github.com/jgm/CommonMark/wiki/Markdown-Flavors).*

A partir de agora, este guia se concentrará principalmente na versão Markdown para Github .

## Porque usar Markdown?
Porque é :
 * **FÁCIL** : A sintaxe é tão fácil que você pode aprender em um minuto ou dois, em seguida, escreva sem perceber nada estranho ou nerd.
 * **RÁPIDO** : Ele economiza tempo em comparação com outros tipos de arquivos / formatos de texto. Isso ajuda a aumentar a produtividade e os fluxos de trabalho do escritor.
 * **LIMPO** : Tanto a sintaxe como a saída são limpas, sem confusão com nossos olhos e simples de gerenciar.
 * **FLEXÍVEL** : Com apenas algumas configurações, o seu texto será traduzido atravessando qualquer plataforma lá fora, editável em qualquer software de edição de texto e conversível para uma ampla variedade de formatos.
<br></br>
**Em resumo**, os usuários comuns acharão útil em todos os casos, especialmente quando você precisar de algo melhor que o texto simples, mas menos funcional do que o Microsoft Word.  
**Para desenvolvedores**, Se você é preguiçoso para escrever código HTML, você vai adorar o markdown. **Além disso**, **Github** e muitos sites favorecem o markdown para o arquivo readme de projetos. Isso significa que você vai encontrar o markdown em sua vida de uma forma ou de outra.  
<div id='tools'/>  

## Ferramentas para markdown
Conforme mencionado acima, qualquer editor pode ser usado para editar o markdown. No entanto, existem algumas ferramentas que podem ser úteis para você quando se trata de editar markdown.
 * **[*Stackedit*](https://stackedit.io)** : Ok, você pode parar de ler agora. Clique no link e, em seguida, comece o seu turno de markdown de uma maneira mais rápida. Basta digitar o texto normal e depois usar o mouse, clique no botão. Você não precisa saber a sintaxe. É bom, mas fará você dependende, e a maioria dos desenvolvedores prefere os teclados.
 * **[*Dillinger*](http://dillinger.io/)** : Ferramenta on-line, suporte em exibição ao vivo (tela dividida) e exportação para html. Nada muito especial, mas muito limpo e acessível.
 * **[*Typora*](https://www.typora.io/)** : Disponível para Mac e Windows, mínimo, livre de distração, vista ao vivo sem parecer, empacotada com muitas outras coisas como Imagens, Listas, Tabelas, Cercas de Código, Blocos de Matemática, YAML, Front Matters, Toc, ...
 * **[*Atom*](https://atom.io/)** : Editor de texto popular hackeável (você pode estar usando isso). Sim, isso é versátil. Suporte Markdown? Apenas uma parte disso, mas é muito construído.
 * **[*Minimalist Markdown*](https://chrome.google.com/webstore/detail/minimalist-markdown-edito/pghodfjepegmciihfhdipmimghiakcjf?hl=en)** : Aplicativo do Google Chrome. Funciona em todos os lugares se você tiver o Chrome instalado (este é o meu favorito).
 * **[*Macdown*](http://macdown.uranusjr.com/)** : O Melhor para Mac.
 * **[*MarkdownPad*](http://markdownpad.com/)** : O Melhor para Windows.
 * **[*Remarkable*](https://remarkableapp.github.io/)** : O Melhor para Linux. 
 * **[*GITBOOK*](http://www.gitbook.com/)** : O GitBook é uma ferramenta de publicação moderna. Facilitando a escrita e a colaboração. Ambos suportam a Markdown e têm uma estreita relação com o amado Github.
<div id='syntax'/>  


## Sintaxe do Markdown  
Toda a sintaxe pode ser encontrada [aqui](https://daringfireball.net/projects/markdown/syntax) . Seria necessário muito esforço para descrever a sintaxe no texto (eles serão formatados), então, considere esta tabela abaixo para toda a sintaxe básica.  

| Formato        | Sintaxe      | Exemplo |
| ------|-----|-----|
| Itálico  	| \*Text\* 	| *Isto está em itálico* 	|
| Negrito  	| \*\*Bold\*\* 	| **Isto está em negrito** 	|
| Links Inline 	| \[texto\](url aqui) 	| Um [link](http://www.github.com) 	|
| Imagens 	| \![Legenda\](url da img) 	| Uma imagem ![image](http://i.imgur.com/hRLuez2.png) 	|
| Link + Imagens 	| \[\![Legenda\](url da img)\](url para a pagina)\] 	| Me clique [![me](http://i.imgur.com/hRLuez2.png)](https://www.youtube.com) 	|
| Quebras de Linha 	| Double space + enter 	|  	|
| Listas Não Ordenadas 	| \* Item1     \*Item 2 	| <ul><li>item1</li><li>item2</li> 	|
| Listas Ordenadas  	| 1. Item a    2. Item b 	| <ol><li>itema</li><li>itemb</li>  	|
| Listas Mistas 	| 1. Item 1      * item 1a 	|  <ol><li>item1</li></ol><ul><li> item1a</li></ul>	|
| Citação 	| \> Texto citado 	|  <blockquote>Stay Hungry Stay Foolish</blockquote> 	|
| Preformatted 	| Comece cada linha com, dois espaços ou mais, faça o look do texto, e x a t a m e n t e, como, você, tipo i, s, t, o. 	|   Comece cada linha com, dois espaços ou mais, faça o look do texto, e x a t a m e n t e, como, você, tipo i, s, t, o. 	|
| Código 	| \`Insira o código\` 	| `cout<<"Hello world";` 	|
| Bloco de Código/ Destaque de Sintaxe 	| \`\`\`Insira o código\`\`\` 	|  <a href="#section1">Ei, leia a nota abaixo desta tabela. 	|
| Títulos 	| \#, \##, \###, \####, \#####, \###### (from h1 to h6) 	|  <h3>Isso é um título h3</h3>	|
| Riscado 	| \~~Insira o texto aqui\~~ 	| ~~Eu estou morto~~ 	|
| Tabelas 	| \| Tables   \|      Are      \|  Cool \| \|\----------\|\:\-------------\:\|------\:\| \| col 1 is\|  left-aligned \| $1600 \| | ![](http://i.imgur.com/EItt7mh.png) |
|Notas de Rodapé| Notas de rodapé[\^1\] <br> [\^1\]: Refêrencia | Aqui está uma simples nota de rodapé[^1]. Com um texto adicional. | 
[^1]: Minha Referencia favorita.
 
<br></br>
 <br></br>
 <p id="section1">Nota: **Nota de rodapé** atualmente não renderiza direito na tabela, mas se parece com isso: </p>  
 
 ![](http://i.imgur.com/pmeBr28.png)  
   <br></br>
   O mesmo vale para **Bloco de código/destaque de sintaxe**. Sua aparência é igual a da imagem abaixo:
  
![](http://i.imgur.com/z8KrxAz.png).    

Estas características dependem de cada versão de markdown.

###### Author: *Vo Tran Thanh Luong*. Also, I would like to thank all the contributors/translators for your work making this greater.
 
###### Autor: *Vo Tran Thanh Luong*.
###### Tradução: *Héricles Emanuel*.
###### Correções: [*Alexander Santos*](https://github.com/Ronkiro).