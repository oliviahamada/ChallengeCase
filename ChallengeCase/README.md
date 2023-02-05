# ChallengeCase 

Esta é uma solução chamada ChallengeCase.  
Esta solução visa calcular o imposto a ser pago sobre lucros ou prejuízos de operações no mercado financeiro de ações.


*******

## Introduction 
> **Warning**: Leia com atenção 


 1. [Parâmetros](#parametros)
 2. [Dados de Entrada](#entrada)
 3. [Dados de Saída](#saida)
 4. [Build e Testes](#build_test)
 5. [Sobre Mim](#about_me)

*******

<div id='parametros'/>

## Parâmetros 

Para a solução, foram utilizados os seguintes parâmetros:
</br>
 * **BUY** : Indica que a operação é de **compra**. Valor default `buy`.
 * **SELL** : Indica que a operação é de **venda**. Valor default `sell`.
 * **NEW_FOLDER_NAME** : Indica o nome da pasta onde serão salvos o resultado das operações. Valor default `Results`.
 * **MIN_VALUE** : Indica o valor mínimo da operação para cobrança de imposto, se o valor for maior ou igual ao valor parametrizado, um valor de imposto deverá ser pago. Valor default `20000`.
 * **IMPOSTO_PERCENT** : Indica o percentual do imposto a ser pago. Valor default `20`.

> **Warning**: *Alterar esses valores pode implicar na execução do cálculo.*
</br>

<div id='entrada'/>

## Dados de Entrada
 * O arquivo de entrada deve estar no formato `.json`.
 * O valor de entrada a ser inserida na solução **deve** ser o caminho raiz do arquivo. Ex.: Se o arquivo a ser consumido é o `C:\Documents\Json\entrada.json`, você deverá inserir apenas o caminho `C:\Documents\Json`, a solução irá consumir todos os arquivos presentes neste diretório.
 * Assume-se que todos os arquivos seguirão o formato de input correto (você pode encontrar um [exemplo](https://github.com/oliviahamada/ChallengeCase/blob/master/ChallengeCase/Helper/json/exemple.json) dentro da pasta `/Helper/json`).

> **Warning**: *Recomendo utilizar apenas 3 arquivos para consumo.*
</br>

<div id='saida'/>

## Dados de Saída
 * A solução irá armazenar o arquivo de saída dentro da pasta configurada no parâmentro `NEW_FOLDER_NAME` (para mais detalhes, clique [aqui](#parametros)). Não será necessário criar ou deletar a pasta, a solução é responsável por isso.
</br>

<div id='build_test'/>

## Build e Testes

A solução foi desenvolvida em .net6.0 usando C#. Deve-se executar o projeto ChallengeCase. Para os testes, executar o projeto ChallengeCaseTests.
</br>

<div id='about_me'/>

## Sobre Mim


###### Nome: *