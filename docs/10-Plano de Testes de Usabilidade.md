# Plano de Testes de Usabilidade

## Teste de Responsividade da Aplicação

### Requisito Associado
**RNF-002**: O sistema deve ser responsivo e permitir o acesso via celulares e tablets.

---

### Objetivo do Teste
Garantir que o sistema ofereça uma experiência consistente e satisfatória, independentemente do dispositivo utilizado. Este teste visa avaliar se a interface da aplicação se ajusta adequadamente à diferentes tamanhos de tela.

---

### Passos
1. Acessar a aplicação em diferentes tamanhos de telas:
   - **Dispositivos**: Browser, Samsung Galaxy S20 Ultra e iPad Pro.
   - **Resoluções**: 
     - Desktop: 1920x1080.
     - Tablets: 768x1024.
     - Celulares: 375x812.
2. Navegar pelas seguintes telas da aplicação em diferentes dispositivos e verificar o layout e suas funcionalidades:
   - Tela inicial.
   - Cadastro de usuário.
   - Login.
   - Agendamento de coleta.

---

### Critérios de Êxito
- Todos os elementos da interface se ajustam corretamente aos diferentes tamanhos de telas.
- Todos os botões permanecem legíveis e acessíveis.
- Elementos importantes, como cabeçalhos, botões e menus, permanecem fixos e acessíveis.

---

## Teste de Avaliação do Feedback ao Usuário

### Requisito Associado:
**RF-005**: O sistema deve emitir um aviso informando que o agendamento foi realizado com sucesso.

### Objetivo do Teste:
Garantir que o sistema informe claramente o usuário sobre o sucesso de suas ações.

### Passos:
1. Realizar um agendamento de coleta.
2. Verificar se uma mensagem de sucesso é exibida.

### Critérios de Êxito:
- Mensagem clara e visível aparece ao final da operação.
- O usuário consegue entender o feedback sem dificuldades.

