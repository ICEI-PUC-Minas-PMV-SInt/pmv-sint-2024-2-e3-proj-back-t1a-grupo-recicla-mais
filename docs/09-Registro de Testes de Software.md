# Registro de Testes de Software

**INTRODUÇÃO**

Este documento apresenta o registro de testes de software realizados no sistema, com base no plano de testes previamente elaborado. Ele detalha os resultados e evidências com base nos resultados dos testes. O objetivo é validar a conformidade do sistema em relação aos requisitos especificados.
________________________________________
**TESTES REALIZADOS**

**CT-01**: Identificar o funcionamento de links da Homepage

•	**Status**: Aprovado

•	**Evidências**: 

o	Capturas de tela de todos os links testados mostrando a página esperada carregada corretamente.

•	**Resultados**: 

o	Todos os links e botões funcionaram corretamente e redirecionaram para os destinos esperados.

o	Não foram detectados problemas de navegação.
________________________________________
**CT-02**: Conferir se o sistema permite que todos os diferentes tipos de usuários realizem o cadastro

•	**Status**: Aprovado

•	**Evidências**: 

o	Capturas de tela dos formulários de cadastro preenchidos para cada tipo de usuário e mensagem de sucesso exibida.

o	Logs confirmando a inserção de dados no banco de dados.

•	**Resultados**: 

o	O sistema permitiu o cadastro de todos os tipos de usuários definidos.

o	Mensagens de erro adequadas foram exibidas para campos obrigatórios deixados em branco.
________________________________________
**CT-03**: Verificar se o sistema possibilita que usuários cadastrados acessem sua conta utilizando suas credenciais de acesso

•	**Status**: Aprovado 

•	**Evidências**: 

o	Capturas de tela do login bem-sucedido e das mensagens de erro para credenciais inválidas.

•	**Resultados**: 

o	O sistema autenticou corretamente usuários registrados com credenciais válidas.

o	Mensagem de erro adequada exibida para credenciais inválidas.

o	Problema detectado: atraso de 5 segundos no login em conexões de baixa velocidade.
________________________________________
**CT-04**: Verificar se o sistema possibilita que os usuários agendem a coleta de lixo eletrônico

•	**Status**: Aprovado

•	**Evidências**: 

o	Capturas de tela do processo de agendamento, incluindo as opções de data e hora.

o	Logs de banco de dados confirmando os registros de agendamento.

•	**Resultados**: 

o	Agendamentos foram realizados com sucesso para todas as combinações de datas e itens disponíveis.
________________________________________
**CT-05**: Verificar se o sistema disponibiliza um portal de notícias para informar os usuários

•	**Status**: Aprovado

•	**Evidências**: 

o	Capturas de tela da exibição das notícias e conteúdo detalhado.

•	**Resultados**: 

o	Notícias foram exibidas corretamente com título, descrição e imagem.

o	Conteúdo detalhado foi carregado sem falhas.
________________________________________
**CT-06**: Verificar se o sistema permite ao administrador cadastrar produtos

•	**Status**: Aprovado

•	**Evidências**: 

o	Capturas de tela da página de cadastro e da lista de produtos atualizada.

o	Logs do banco de dados confirmando o registro dos produtos.

•	**Resultados**: 

o	Administradores conseguiram cadastrar produtos com todos os campos obrigatórios preenchidos.

o	Mensagens de erro foram exibidas corretamente para entradas inválidas.
________________________________________
**CT-07**: Validar se o administrador consegue cadastrar benefícios

•	**Status**: Aprovado

•	**Evidências**: 

o	Capturas de tela da página de cadastro e da lista de benefícios atualizada.

o	Logs confirmando os registros dos benefícios.

•	**Resultados**: 

o	Cadastro de benefícios foi realizado com sucesso para todos os casos de teste.
________________________________________
**Avaliação Geral**

**Pontos Fortes**

•	A interface mostrou-se intuitiva e funcional para a maioria dos casos de uso.

•	Os testes demonstraram que os requisitos funcionais principais foram atendidos.

•	As mensagens de erro foram exibidas corretamente, indicando boa implementação das validações.

**Pontos Fracos**

•	O desempenho do sistema em conexões de baixa velocidade mostrou-se insatisfatório, especialmente no login.

