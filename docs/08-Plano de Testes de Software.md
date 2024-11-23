# Plano de Testes de Software

Os testes funcionais a serem realizados na aplicação são descritos a seguir:

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-01: Identificar o funcionamento de links da Homepage</td>
  <td>
   <ul>
    <li>RF-01: O sistema deve permitir que o usuário faça um Cadastro.</li>
   </ul>
  </td>
  <td>Verificar se os menus de navegação e butões estão funcionais e com o direcionamento correto.</td>
  <td>
   <ol>
    <li>Acessar o navegador</li>
    <li>Informar o endereço do site</li>
    <li>Visualizar a página principal.</li>
    <li>Clicar nos links e butões da página.</li>
   </ol>
   </td>
  <td>Todos os links da página principal devem encaminhar os usuários para as respectivas páginas.</td>
 </tr>
</table>


<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-02: Validar se o sistema permite que todos os usuários realizem o cadastro com os dados necessários.</td>
  <td>
   <ul>
    <li>RF-04: O sistema deve mostrar a quantidade de cada tipo sanguíneo disponível.</li>
   </ul>
  </td>
  <td>Validar se o sistema permite que todos os usuários realizem o cadastro com os dados necessários.</td>
  <td>
   <ol>
    <li>Acessar o navegador</li>
    <li>Informar o endereço do site</li>
    <li>Navegar até a página de cadastro de usuário.</li>
    <li>Preencher os campos obrigatórios do formulário de cadastro (ex.: nome, e-mail, senha, etc.)</li>
    <li>Confirmar o cadastro clicando no botão correspondente.</li>
    <li>Verificar se a mensagem de sucesso é exibida e se o usuário é adicionado ao sistema.</li>
   </ol>
   </td>
  <td>O sistema deve permitir o preenchimento e envio do formulário de cadastro. O cadastro deve ser concluído com sucesso, exibindo uma mensagem de confirmação.
   O usuário deve ser registrado e constar na base de dados do sistema.</td>
 </tr>
</table>

 
<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-03:  Validar se o sistema permite que usuários registrados realizem login com credenciais válidas.
 </td>
  <td>
   <ul>
    <li>RF-02: O sistema deve possuir um formulário de triagem para avaliar a elegibilidade do doador antes de doar .</li>
   </ul>
  </td>
  <td> Validar se o sistema permite que usuários registrados realizem login com credenciais válidas.</td>
  <td> 
   <ol>
<li>Acessar o navegador</li>
<li>Informar o endereço do sistema</li>
<li>Navegar até a página de login</li>
<li>Inserir um e-mail válido previamente registrado</li>
<li>Inserir a senha correspondente ao e-mail</li>
<li>Clicar no botão de login</li>
<li>Verificar se o sistema autentica o usuário e redireciona para a página principal ou dashboard</li>
   </ol>
   </td>
  <td>O sistema deve autenticar o usuário caso as credenciais sejam válidas. O usuário deve ser redirecionado para a página principal ou área reservada (dashboard).Caso as credenciais sejam inválidas, o sistema deve exibir uma mensagem de erro apropriada (ex.: "Usuário ou senha incorretos").
</td>
 </tr>
</table>


<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-04:  Validar se o sistema possibilita que os usuários agendem uma data e hora para a coleta de itens de lixo eletrônico listados.</td>
  <td>
   <ul>
    <li>RF-03: O sistema deve fornecer informações sobre a importância e os benefícios da doação de sangue.</li>
   </ul>
  </td>
  <td> Validar se o sistema possibilita que os usuários agendem uma data e hora para a coleta de itens de lixo eletrônico listados.
</td>
  <td> 
   <ol>
<li>Acessar o navegador</li>
<li>Informar o endereço do sistema</li>
<li>Realizar login no sistema (caso necessário)</li>
<li>Navegar até a página "Agendamento"</li>
<li>Listar os itens de lixo eletrônico para coleta (ex.: televisão, celular, baterias, etc.)</li>
<li>Selecionar uma data e hora disponíveis para a coleta</li>
<li>Confirmar o agendamento clicando no botão correspondente</li>
<li>Verificar se o sistema exibe uma mensagem de confirmação do agendamento</li>
   </ol>
   </td>
  <td>O sistema deve permitir que o usuário liste os itens de lixo eletrônico para coleta.
O sistema deve oferecer opções válidas de data e hora para o agendamento.
O agendamento deve ser concluído com sucesso e uma mensagem de confirmação deve ser exibida.
O agendamento deve ser registrado no sistema, permitindo consulta futura.
</td>
 </tr>
</table>


<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-05:  Verificar se o sistema disponibiliza um portal de notícias para informar os usuários
 </td>
  <td>
   <ul>
    <li>RF-01: O sistema deve permitir que o usuário faça um cadastro.</li>
   </ul>
  </td>
  <td>Verificar se o sistema disponibiliza um portal de notícias para informar os usuários</td>
  <td> 
   <ol>
<li>Acessar o navegador</li>
<li>Informar o endereço do sistema</li>
<li>Navegar até a aba de "Notícias"</li>
<li>Verificar se as notícias são exibidas corretamente na página</li>
<li>Clicar em uma notícia para visualizar o conteúdo detalhado</li>
<li>Verificar se o conteúdo da notícia é carregado corretamente e está legível</li>
   </ol>
   </td>
  <td>A aba "Notícias" deve estar visível e acessível no sistema.
As notícias devem ser exibidas corretamente, com títulos, descrições e imagens (se aplicável).
O conteúdo detalhado de uma notícia deve ser carregado corretamente ao ser clicado.
Não devem ocorrer erros ou falhas no carregamento das informações.
</td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-06:  Verificar se o sistema permite ao administrador cadastrar produtos
  </td>
  <td>
   <ul>
    <li>RF-01: O sistema deve permitir que o usuário faça um cadastro.</li>
   </ul>
  </td>
  <td> Validar se o administrador consegue cadastrar produtos no sistema informando nome, descrição e pontuação.
  </td>
  <td> 
   <ol>
<li>Acessar o navegador</li>
<li>Informar o endereço do sistema</li>
<li>Realizar login como usuário administrador</li>
<li>Navegar até a área de gerenciamento de produtos</li>
<li>Clicar na opção de "Cadastrar Produto"</li>
<li>Preencher os campos obrigatórios:</li>
<ul>
  <li>Nome do produto</li>
  <li>Descrição do produto</li>
  <li>Pontuação do produto</li>
</ul>
<li>Confirmar o cadastro clicando no botão correspondente</li>
<li>Verificar se o sistema exibe uma mensagem de sucesso</li>
<li>Consultar a lista de produtos para garantir que o novo produto foi adicionado</li>
   </ol>
   </td>
  <td>O administrador deve conseguir acessar a área de gerenciamento de produtos.
O sistema deve permitir o preenchimento de todos os campos obrigatórios (nome, descrição, pontuação).
O produto deve ser cadastrado com sucesso e exibido na lista de produtos.
O sistema deve validar os campos e exibir mensagens de erro em caso de preenchimento incorreto ou incompleto.
</td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-07:  Validar se o administrador consegue cadastrar benefícios
  </td>
  <td>
   <ul>
    <li>RF-01: O sistema deve permitir que o usuário faça um cadastro.</li>
   </ul>
  </td>
  <td> Validar se o administrador consegue cadastrar benefícios no sistema informando título, descrição e pontuação de troca.
  </td>
  <td> 
   <ol>
<li>Acessar o navegador</li>
<li>Informar o endereço do sistema</li>
<li>Realizar login como usuário administrador</li>
<li>Navegar até a área de gerenciamento de produtos</li>
<li>Clicar na opção de "Cadastrar Produto"</li>
<li>Preencher os campos obrigatórios:</li>
<ul>
  <li>Nome do produto</li>
  <li>Descrição do produto</li>
  <li>Pontuação do produto</li>
</ul>
<li>Confirmar o cadastro clicando no botão correspondente</li>
<li>Verificar se o sistema exibe uma mensagem de sucesso</li>
<li>Consultar a lista de produtos para garantir que o novo produto foi adicionado</li>

   </ol>
   </td>
  <td>O administrador deve conseguir acessar a área de gerenciamento de benefícios.
O sistema deve permitir o preenchimento de todos os campos obrigatórios (título, descrição, pontuação de troca).
O benefício deve ser cadastrado com sucesso e exibido na lista de benefícios.
O sistema deve validar os campos e exibir mensagens de erro em caso de preenchimento incorreto ou incompleto.
</td>
 </tr>
</table>
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
