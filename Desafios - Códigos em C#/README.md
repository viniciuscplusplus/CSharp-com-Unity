DESAFIOS DE PROGRAMAÇÃO EM UNITY - C#
========================================

Este repositório contém uma série de desafios para aprender e praticar conceitos fundamentais de programação em C# dentro do ambiente Unity.


ÍNDICE
-------
1. Desafio 1 - Soma de Variáveis
2. Desafio 2 - Maior entre 3 Números
3. Desafio 3 - Vogal ou Consoante
4. Desafio 4 - Classificação de Triângulos
5. Desafio 5 - Jogo Par ou Ímpar
6. Desafio 6 - Função MaiorQueMil()


================================================================================
DESAFIO 1 - SOMA DE VARIÁVEIS
================================================================================

OBJETIVO:
Criar um script que exiba no console a mensagem:

"A soma de x + y é igual a x+y"

REQUISITOS:
- Criar duas variáveis públicas do tipo int chamadas x e y
- As variáveis devem ser editáveis pelo inspetor do Unity
- Valores iniciais: x = 5, y = 7
- A mensagem deve mostrar os valores atuais das variáveis e o resultado da soma

EXEMPLO DE SAÍDA ESPERADA:
Com x = 5 e y = 7:
A soma de 5 + 7 é igual a 12

TESTE:
Altere os valores no inspetor e verifique se a mensagem se atualiza corretamente no console.


================================================================================
DESAFIO 2 - MAIOR ENTRE 3 NÚMEROS
================================================================================

OBJETIVO:
Criar um script que identifique e exiba no console o maior número entre 3 valores fornecidos.

REQUISITOS:
- Criar 3 variáveis públicas do tipo int para os números
- Criar 1 variável interna para armazenar o maior número
- Utilizar a estrutura condicional if/else para comparar os valores
- Exibir no console a mensagem com o maior número encontrado

ESTRUTURA DAS VARIÁVEIS:
- numero_1 (pública, valor padrão 0)
- numero_2 (pública, valor padrão 0)
- numero_3 (pública, valor padrão 0)
- numero_maior (interna, valor padrão 0)

EXEMPLO DE SAÍDA ESPERADA:
Entrada: numero_1 = 5, numero_2 = 12, numero_3 = 7
Saída: O maior número é: 12

REGRAS DE NEGÓCIO:
- Os valores devem ser editáveis pelo inspetor do Unity
- O código deve funcionar para qualquer combinação de números
- A mensagem deve ser exibida corretamente no console ao iniciar o jogo
- Utilizar obrigatoriamente a estrutura if/else

COMO TESTAR:
1. Atribua diferentes valores às 3 variáveis pelo inspetor
2. Execute o jogo
3. Verifique se o console mostra o maior número corretamente
4. Teste com diferentes combinações:
   - Todos os números iguais
   - Números negativos
   - Números em ordens diferentes
   - Números com valores extremos


================================================================================
DESAFIO 3 - VOGAL OU CONSOANTE
================================================================================

OBJETIVO:
Criar um script que identifique se uma letra fornecida é vogal ou consoante.

REQUISITOS:
- Criar uma variável pública do tipo string para armazenar a letra
- Utilizar a estrutura condicional if/else com operadores lógicos || (OU)
- Verificar se a letra é uma vogal (a, e, i, o, u)
- Classificar como consoante qualquer outra letra
- Exibir a classificação no console

ESTRUTURA DAS VARIÁVEIS:
- letra (pública, tipo string) - para armazenar a letra a ser verificada

EXEMPLOS DE SAÍDA ESPERADA:
Entrada: letra = "a"
Saída: a é uma vogal.

Entrada: letra = "b"
Saída: b é uma consoante.

REGRAS DE NEGÓCIO:
- A letra deve ser editável pelo inspetor do Unity
- Considerar apenas letras minúsculas (a, e, i, o, u)
- Utilizar obrigatoriamente a estrutura if/else com || (OU)
- A mensagem deve ser exibida no formato: "X é uma vogal." ou "X é uma consoante."

COMO TESTAR:
1. Digite uma letra no campo letra pelo inspetor
2. Execute o jogo
3. Verifique se o console mostra a classificação correta
4. Teste com diferentes letras:
   - Todas as vogais (a, e, i, o, u)
   - Consoantes (b, c, d, f, g, etc.)
   - Letras maiúsculas (A, B, C, etc.)
   - Caracteres especiais ou números


================================================================================
DESAFIO 4 - CLASSIFICAÇÃO DE TRIÂNGULOS
================================================================================

OBJETIVO:
Criar um script que classifique um triângulo com base nos tamanhos de seus lados, identificando se é equilátero, isósceles ou escaleno.

REQUISITOS:
- Criar 3 variáveis públicas do tipo int para os lados do triângulo
- Classificar o triângulo de acordo com as regras estabelecidas
- Exibir a classificação no console

CLASSIFICAÇÕES:
- Equilátero: Todos os 3 lados possuem o mesmo tamanho
- Isósceles: Possui 2 lados de tamanhos iguais e 1 diferente
- Escaleno: Todos os lados possuem tamanhos diferentes

ESTRUTURA DAS VARIÁVEIS:
- lado1 (pública, tipo int)
- lado2 (pública, tipo int)
- lado3 (pública, tipo int)

EXEMPLOS DE SAÍDA ESPERADA:
Entrada: lado1 = 5, lado2 = 5, lado3 = 5
Saída: Seu triângulo é equilátero

Entrada: lado1 = 5, lado2 = 5, lado3 = 3
Saída: Seu triângulo é isósceles

Entrada: lado1 = 4, lado2 = 5, lado3 = 6
Saída: Seu triângulo é escaleno

REGRAS DE NEGÓCIO:
- Os valores devem ser editáveis pelo inspetor do Unity
- Utilizar estrutura condicional if/else ou else if para verificar as condições
- A mensagem deve ser exibida no formato: "Seu triângulo é [classificação]"
- Considerar todas as possibilidades de combinações de lados

COMO TESTAR:
1. Atribua valores para os 3 lados no inspetor
2. Execute o jogo
3. Verifique se o console mostra a classificação correta
4. Teste com diferentes combinações:
   - Todos os lados iguais (equilátero)
   - Apenas dois lados iguais (isósceles)
   - Todos os lados diferentes (escaleno)
   - Valores com zeros
   - Números negativos


================================================================================
DESAFIO 5 - JOGO PAR OU ÍMPAR
================================================================================

OBJETIVO:
Criar um jogo onde dois jogadores escolhem seus nomes, seus números e se jogam pelo par ou ímpar, determinando o vencedor com base na soma dos números.

REQUISITOS:
- Criar variáveis para os nomes dos jogadores
- Criar variáveis para os números escolhidos por cada jogador
- Criar um sistema para definir se cada jogador joga pelo par ou ímpar
- Calcular a soma dos dois números
- Determinar o vencedor com base na escolha (par ou ímpar)
- Exibir a mensagem com o resultado no console

ESTRUTURA DAS VARIÁVEIS:
- jogador_1 (pública, tipo string) - Nome do primeiro jogador
- jogador_2 (pública, tipo string) - Nome do segundo jogador
- mao_jogador_1 (pública, tipo int) - Número escolhido pelo jogador 1
- mao_jogador_2 (pública, tipo int) - Número escolhido pelo jogador 2
- Decisão do par/ímpar (você escolhe a melhor forma de implementar)

EXEMPLOS DE SAÍDA ESPERADA:

Exemplo 1:
Jogador 1: João - Número: 4 - Joga pelo Par
Jogador 2: Maria - Número: 3 - Joga pelo Ímpar
Soma: 7 (ímpar) → Maria vence
Saída: 7 é um número ímpar, portanto Maria venceu!

Exemplo 2:
Jogador 1: Carlos - Número: 2 - Joga pelo Par
Jogador 2: Ana - Número: 6 - Joga pelo Ímpar
Soma: 8 (par) → Carlos vence
Saída: 8 é um número par, portanto Carlos venceu!

REGRAS DE NEGÓCIO:
- Os valores devem ser editáveis pelo inspetor do Unity
- O jogador que escolhe par, vence se a soma for par
- O jogador que escolhe ímpar, vence se a soma for ímpar
- Apenas um jogador pode vencer (não há empate possível neste sistema)
- A mensagem deve seguir o formato: "X é um número [par/ímpar], portanto [nome] venceu!"

DESAFIOS EXTRAS (Escolha sua Implementação):
Você pode implementar o sistema de par/ímpar de diferentes formas:

1. Usando duas variáveis string:
   - escolha_jogador_1 e escolha_jogador_2
   - Valores possíveis: "par" ou "impar"

2. Usando uma única variável bool:
   - Indicar se o jogador 1 joga pelo par (true) ou ímpar (false)
   - O jogador 2 joga automaticamente pelo oposto

3. Usando números enum:
   - Criar um enum com as opções Par e Ímpar

COMO TESTAR:
1. Preencha todos os campos no inspetor
2. Execute o jogo
3. Verifique se o console mostra o vencedor correto
4. Teste com diferentes combinações:
   - Par + Ímpar (ambas as configurações)
   - Números pares e ímpares variados
   - Nomes diferentes
   - Valores extremos (números negativos, zero)


================================================================================
DESAFIO 6 - FUNÇÃO MAIORQUEMIL()
================================================================================

OBJETIVO:
Criar uma função que receba três números inteiros como parâmetros, realize um cálculo específico e retorne um valor booleano indicando se o resultado é maior que 1000.

REQUISITOS:
- Criar uma função chamada MaiorQueMil()
- A função deve ter retorno do tipo bool
- Receber 3 parâmetros do tipo int: x, y, z
- Realizar o cálculo: total = (x + y) * z
- Retornar true se o total for maior que 1000
- Retornar false se o total for menor ou igual a 1000
- Chamar a função a partir do método Start()
- Exibir o resultado no console usando Debug.Log()

ESTRUTURA DA FUNÇÃO:
bool MaiorQueMil(int x, int y, int z)
{
    // Cálculo: (x + y) * z
    // Retornar true se > 1000, false caso contrário
}

EXEMPLOS DE SAÍDA ESPERADA:

Exemplo 1: x = 50, y = 50, z = 10
Cálculo: (50 + 50) * 10 = 1000
Resultado: 1000 não é maior que 1000
Saída: False

Exemplo 2: x = 100, y = 50, z = 10
Cálculo: (100 + 50) * 10 = 1500
Resultado: 1500 é maior que 1000
Saída: True

REGRAS DE NEGÓCIO:
- A função deve ser chamada a partir de Start()
- O resultado deve ser exibido no console como True ou False
- A função deve ser reutilizável com diferentes valores
- Utilizar a estrutura correta de função com retorno bool

COMO TESTAR:
1. Modifique os valores de x, y e z diretamente no código
2. Execute o jogo
3. Verifique se o console mostra o resultado correto
4. Teste com diferentes combinações:
   - Valores que resultam em exatamente 1000
   - Valores que resultam em números menores que 1000
   - Valores que resultam em números maiores que 1000
   - Valores negativos
   - Valores com zero


================================================================================
COMO UTILIZAR ESTE REPOSITÓRIO
================================================================================

1. Cada desafio deve ser implementado em um script separado no Unity
2. Todos os scripts devem ser anexados a GameObjects na cena
3. As variáveis públicas devem ser configuradas pelo inspetor
4. Execute o jogo e verifique os resultados no console


================================================================================
CONCEITOS ABORDADOS
================================================================================

- Variáveis e tipos de dados (int, string, bool)
- Variáveis públicas e privadas
- Entrada de dados pelo inspetor
- Estruturas condicionais (if, else, else if)
- Operadores lógicos (&&, ||)
- Operadores matemáticos (+, *, %)
- Funções com retorno
- Concatenação de strings
- Debug.Log() para saída no console
