================================================================================
DESAFIO 7 - SISTEMA DE CLIQUE E UPGRADES
================================================================================

OBJETIVO:
Criar um sistema de jogo onde o jogador pode clicar em um botão para ganhar recursos e comprar upgrades que aumentam a quantidade de recursos ganhos por clique.

REQUISITOS GERAIS:
- Criar um Canvas com 3 botões (1 básico + 2 upgrades)
- Implementar sistema de recursos e upgrades usando variáveis públicas
- Utilizar funções com e sem parâmetros
- Exibir feedback no console (Debug.Log)

================================================================================
ESTRUTURA DAS VARIÁVEIS
================================================================================

VARIÁVEIS GLOBAIS:
- recursos (int) - Quantidade atual de recursos (inicia em 0)
- recursoPorClique (int) - Quanto cada clique gera (inicia em 1)

VARIÁVEIS PARA OS UPGRADES:
- Cada botão de upgrade terá seu próprio valor de custo (definido no inspetor)
- Upgrade 1: Custo exemplo 30 → adiciona +3 ao recursoPorClique
- Upgrade 2: Custo exemplo 50 → adiciona +5 ao recursoPorClique

================================================================================
BOTÃO BÁSICO DE CLIQUE
================================================================================

FUNÇÃO: public void ClickBasico()

O QUE FAZ:
1. Adiciona ao recurso o valor atual de recursoPorClique
2. Exibe no console a quantidade total de recursos após o clique

EXEMPLO DE FUNCIONAMENTO:
Estado inicial: recursos = 0, recursoPorClique = 1
Após 1 clique: recursos = 1
Saída no console: "Recursos: 1"

Após 2 cliques: recursos = 2
Saída no console: "Recursos: 2"

================================================================================
BOTÕES DE UPGRADE
================================================================================

FUNÇÃO: public void ComprarUpgrade(int custo)

O QUE FAZ:
1. Verifica se o jogador tem recursos suficientes
2. Se NÃO tiver:
   - Calcula quanto falta: recursos - custo (valor negativo)
   - Exibe mensagem: "Faltam X recursos para comprar este upgrade!"
   
3. Se tiver recursos suficientes:
   - Subtrai o custo do total de recursos
   - Aumenta o recursoPorClique em custo/10
   - Exibe mensagem de confirmação

EXEMPLO DE FUNCIONAMENTO:

Cenário 1 - Recursos Insuficientes:
recursos = 10, custo = 30, recursoPorClique = 1
Mensagem: "Faltam 20 recursos para comprar este upgrade!"
recursos permanece = 10
recursoPorClique permanece = 1

Cenário 2 - Compra Bem-Sucedida:
recursos = 50, custo = 30, recursoPorClique = 1
recursos = 20 (50 - 30)
recursoPorClique = 4 (1 + 3)
Mensagem: "Upgrade comprado! +3 por clique!"

================================================================================
CONFIGURAÇÃO NO UNITY
================================================================================

PASSOS PARA CONFIGURAR:

1. CRIAR O CANVAS:
   - Clique com botão direito na Hierarchy
   - UI → Canvas
   - O Canvas será criado automaticamente com um EventSystem

2. CRIAR OS BOTÕES:
   - Clique com botão direito no Canvas
   - UI → Button (crie 3 botões)
   - Renomeie para: "BotaoClique", "Upgrade1", "Upgrade2"
   - Ajuste a posição e tamanho de cada botão

3. CRIAR O SCRIPT:
   - Crie um novo script chamado "SistemaClique"
   - Cole o código do desafio
   - Anexe o script ao Canvas

4. CONFIGURAR O BOTÃO DE CLIQUE:
   - Selecione o botão "BotaoClique"
   - No inspetor, vá em "OnClick()"
   - Clique em "+" para adicionar um evento
   - Arraste o Canvas (com o script) para o campo Object
   - Selecione a função: SistemaClique → ClickBasico()

5. CONFIGURAR OS UPGRADES:
   - Selecione o botão "Upgrade1"
   - No inspetor, vá em "OnClick()"
   - Clique em "+" para adicionar um evento
   - Arraste o Canvas (com o script) para o campo Object
   - Selecione a função: SistemaClique → ComprarUpgrade(int)
   - No campo "int", digite o valor do custo (ex: 30)
   
   - Repita o processo para "Upgrade2" com custo diferente (ex: 50)

================================================================================
EXEMPLOS DE SAÍDA ESPERADA
================================================================================

CENÁRIO DE TESTE 1 - JOGANDO NORMALMENTE:

Estado inicial: recursos = 0, recursoPorClique = 1

1. Clique no botão básico (5 vezes):
   Saída: "Recursos: 1", "Recursos: 2", "Recursos: 3", "Recursos: 4", "Recursos: 5"

2. Tenta comprar Upgrade1 (custo 30):
   recursos = 5, custo = 30
   Saída: "Faltam 25 recursos para comprar este upgrade!"

3. Clique mais 25 vezes:
   recursos agora = 30

4. Compra Upgrade1:
   recursos = 30, custo = 30
   Saída: "Upgrade comprado! +3 por clique!"
   recursos = 0
   recursoPorClique = 4

5. Clique no botão básico (1 vez):
   Saída: "Recursos: 4" (agora ganha 4 por clique)

================================================================================
CENÁRIO DE TESTE 2 - DIFERENTES VALORES DE UPGRADE:

Configuração:
- Upgrade1: custo = 30 → +3 por clique
- Upgrade2: custo = 50 → +5 por clique

Após comprar Upgrade1 (recursosPorClique = 4):
recursos = 50

Compra Upgrade2 (custo = 50):
Saída: "Upgrade comprado! +5 por clique!"
recursos = 0
recursoPorClique = 9 (4 + 5)

Próximo clique:
Saída: "Recursos: 9" (ganha 9 por clique agora!)

================================================================================
REGRAS DE NEGÓCIO
================================================================================

1. SISTEMA DE RECURSOS:
   - Recursos começam em 0
   - Cada clique adiciona o valor de recursoPorClique
   - Não pode ficar negativo

2. SISTEMA DE UPGRADE:
   - Custo definido no inspetor para cada botão
   - Cada upgrade aumenta recursoPorClique em custo/10
   - Exemplo: custo 30 → +3, custo 50 → +5
   - Só pode comprar se tiver recursos suficientes

3. FEEDBACK:
   - Sempre mostrar quantos recursos tem após cada clique
   - Mostrar mensagem de erro quando não tem recursos
   - Mostrar mensagem de sucesso ao comprar upgrade

================================================================================
PONTOS DE ATENÇÃO
================================================================================

- A mesma função ComprarUpgrade() é usada para ambos os botões
- O parâmetro "custo" é definido diretamente no inspetor
- O cálculo do aumento é sempre custo/10 (divisão inteira)
- Lembre-se de usar Debug.Log() para todas as mensagens
- As variáveis devem ser públicas para aparecer no inspetor

================================================================================
COMO TESTAR
================================================================================

1. Configure os botões conforme descrito acima
2. Execute o jogo no Unity
3. Clique no botão básico e observe o console
4. Acumule recursos suficientes
5. Clique nos botões de upgrade
6. Verifique se o valor por clique aumentou
7. Continue testando com diferentes combinações

================================================================================
CONCEITOS ABORDADOS
================================================================================

- Funções com e sem parâmetros
- Variáveis públicas e privadas
- Interface gráfica (UI/Canvas)
- Eventos de botão (OnClick)
- Lógica condicional (if/else)
- Operações matemáticas básicas
- Console de saída (Debug.Log)
- Reutilização de código
