# ChallengeCase 

Esta � uma solu��o chamada ChallengeCase.  
Esta solu��o visa calcular o imposto a ser pago sobre lucros ou preju�zos de opera��es no mercado financeiro de a��es.


*******

## Introduction 
> **Warning**: Leia com aten��o 


 1. [Par�metros](#parametros)
 2. [Dados de Entrada](#entrada)
 3. [Dados de Sa�da](#saida)
 4. [Build e Testes](#build_test)
 5. [Sobre Mim](#about_me)

*******

<div id='parametros'/>

## Par�metros 

Para a solu��o, foram utilizados os seguintes par�metros:
</br>
 * **BUY** : Indica que a opera��o � de **compra**. Valor default `buy`.
 * **SELL** : Indica que a opera��o � de **venda**. Valor default `sell`.
 * **NEW_FOLDER_NAME** : Indica o nome da pasta onde ser�o salvos o resultado das opera��es. Valor default `Results`.
 * **MIN_VALUE** : Indica o valor m�nimo da opera��o para cobran�a de imposto, se o valor for maior ou igual ao valor parametrizado, um valor de imposto dever� ser pago. Valor default `20000`.
 * **IMPOSTO_PERCENT** : Indica o percentual do imposto a ser pago. Valor default `20`.

> **Warning**: *Alterar esses valores pode implicar na execu��o do c�lculo.*
</br>

<div id='entrada'/>

## Dados de Entrada
 * O arquivo de entrada deve estar no formato `.json`.
 * O valor de entrada a ser inserida na solu��o **deve** ser o caminho raiz do arquivo. Ex.: Se o arquivo a ser consumido � o `C:\Documents\Json\entrada.json`, voc� dever� inserir apenas o caminho `C:\Documents\Json`, a solu��o ir� consumir todos os arquivos presentes neste diret�rio.
 * Assume-se que todos os arquivos seguir�o o formato de input correto (voc� pode encontrar um [exemplo](https://github.com/oliviahamada/ChallengeCase/blob/master/ChallengeCase/Helper/json/exemple.json) dentro da pasta `/Helper/json`).

> **Warning**: *Recomendo utilizar apenas 3 arquivos para consumo.*
</br>

<div id='saida'/>

## Dados de Sa�da
 * A solu��o ir� armazenar o arquivo de sa�da dentro da pasta configurada no par�mentro `NEW_FOLDER_NAME` (para mais detalhes, clique [aqui](#parametros)). N�o ser� necess�rio criar ou deletar a pasta, a solu��o � respons�vel por isso.
</br>

<div id='build_test'/>

## Build e Testes

A solu��o foi desenvolvida em .net6.0 usando C#. Deve-se executar o projeto ChallengeCase. Para os testes, executar o projeto ChallengeCaseTests.
</br>

<div id='about_me'/>

## Sobre Mim


###### Nome: *