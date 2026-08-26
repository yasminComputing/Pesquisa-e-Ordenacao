# RESUMO PARA AVALIAÇÃO — PESQUISA E ORDENAÇÃO

# 1. CONCEITOS FUNDAMENTAIS

## O que é ordenar?

Ordenar é **organizar uma estrutura de dados**, como uma lista ou vetor, de acordo com uma ou mais chaves.

### Exemplo

```text
Antes:
8  3  5  1  9

Depois:
1  3  5  8  9
````

---

## O que é indexar?

Indexar é utilizar um **índice ou chave para identificar/localizar elementos** dentro de uma estrutura.

Exemplo:

```text
Índice:  0  1  2  3  4
Valor:   8  3  5  1  9
```

O índice `2` aponta para o valor `5`.

---

## Por que ordenar?

A principal finalidade da ordenação é **organizar os dados para facilitar e otimizar pesquisas/buscas**.

Uma estrutura organizada permite que determinadas pesquisas sejam realizadas de maneira mais eficiente.

---

# 2. O QUE É PESQUISA?

Pesquisar é **localizar ou buscar um dado dentro de uma estrutura utilizando uma chave**.

Exemplo:

```text
Lista:
10  20  30  40  50

Chave pesquisada:
30

Resultado:
Encontrado
```

Termos relacionados:

* Search → pesquisar
* Find → localizar/encontrar
* Retrieve → recuperar/localizar um dado de interesse

---

# 3. COMPLEXIDADE

## O que é complexidade?

Complexidade é o **esforço computacional de um algoritmo**, ou seja, a quantidade de recursos necessários para executar suas tarefas.

Quanto maior o esforço computacional, maior a complexidade.

A complexidade pode ser representada pela **notação Big-O**.

---

## Principais complexidades

Da menor para a maior:

```text
O(1)
O(log n)
O(n)
O(n log n)
O(n²)
O(2ⁿ)
O(n!)
```

### Importante

```text
O(n)       → melhor que O(n²)
O(n log n) → melhor que O(n²)
O(n²)      → pior que O(n log n)
```

Quanto mais rapidamente a função cresce conforme `n` aumenta, maior tende a ser a complexidade.

---

# 4. COMO MEDIR A COMPLEXIDADE NA ORDENAÇÃO?

Na disciplina, a complexidade dos algoritmos de ordenação é analisada principalmente através de:

### 1. Quantidade de comparações

Quantas vezes o algoritmo compara dois elementos.

### 2. Quantidade de trocas

Quantas vezes o algoritmo troca ou desloca elementos.

### 3. Tempo de execução

Também podemos realizar um benchmark para verificar quanto tempo o algoritmo demora para executar.

```text
ORDENAÇÃO
    ↓
Comparações
Trocas
Tempo
```

---

# 5. COMPLEXIDADE NA PESQUISA


```text
PESQUISA
    ↓
Quantidade de comparações
```

A quantidade de comparações ajuda a avaliar o esforço realizado para encontrar determinado elemento.

---

# 6. ESTABILIDADE

Um algoritmo de ordenação é **estável** quando mantém a ordem relativa entre elementos que possuem a mesma chave.

### Exemplo

Temos:

```text
Ana    20
João   20
Pedro  30
```

Se ordenarmos pela idade utilizando um algoritmo estável:

```text
Ana    20
João   20
Pedro  30
```

Ana continua antes de João.

### Resumindo

```text
ESTÁVEL
→ mantém a ordem relativa dos elementos com a mesma chave.

INSTÁVEL
→ não garante que essa ordem será mantida.
```

---

# 7. MEMÓRIA INTERNA E EXTERNA

## Memória interna

O algoritmo trabalha principalmente com os dados armazenados na **memória principal (RAM)**.

Nos algoritmos estudados:

* Bolha
* Seleção
* Inserção
* Agitação
* Pente

são algoritmos de memória interna.

## Memória externa

É utilizada quando a quantidade de dados é grande e não cabe toda na memória principal, utilizando armazenamento externo.

---

# 8. BUBBLE SORT — BOLHA

## Ideia principal

O Bubble Sort compara elementos **vizinhos**.

Se estiverem fora de ordem, realiza uma troca.

A cada passada, o maior elemento tende a ser levado para o **final da estrutura**.

### Exemplo

```text
5  3  8  1

5 > 3
↓
3  5  8  1
```

Continuando as comparações, o maior elemento vai "borbulhando" para o final.

Por isso o nome **Bolha**.

---

## Características

* Memória interna
* Estável
* O(n²)
* Porção ordenada: final
* Trabalha com trocas

### Para lembrar

```text
BOLHA
→ maior vai para o FINAL
```

---

## Código — ideia principal

```text
enquanto houver troca:
    percorre a lista
    compara elementos vizinhos
    se estiverem fora de ordem:
        troca
```

A variável `houveTroca` indica se alguma troca ocorreu.

Se não ocorrer nenhuma troca, a estrutura já está ordenada.

---

# 9. SELECTION SORT — SELEÇÃO

## Ideia principal

O Selection Sort procura o **menor elemento** da parte ainda não ordenada e coloca esse elemento na posição correta.

Exemplo:

```text
5  3  8  1  2
```

Procura o menor:

```text
1
```

Coloca no início:

```text
1  3  8  5  2
```

Depois repete o processo para o restante.

---

## Características

* Memória interna
* Instável
* O(n²)
* Porção ordenada: início

### Para lembrar

```text
SELEÇÃO
→ seleciona o menor
→ coloca no INÍCIO
```

---

## Estrutura básica

```text
for externo:
    posMenor = posição atual

    for interno:
        procura o menor elemento

    troca o menor com a posição atual
```

A variável `posMenor` é utilizada para guardar a posição do menor elemento encontrado.

---

# 10. INSERTION SORT — INSERÇÃO

## Ideia principal

O Insertion Sort considera que uma parte da estrutura já está ordenada.

Depois pega um elemento da parte desordenada e **insere esse elemento na posição correta da parte ordenada**.

Exemplo:

```text
3  5  8 | 4
```

O `4` precisa ser inserido na posição correta:

```text
3  4  5  8
```

---

## Características

* Memória interna
* Estável
* O(n²)
* Porção ordenada: início

### Para lembrar

```text
INSERÇÃO
→ pega um elemento
→ insere na posição correta
```

---

## Estrutura

```text
[ PARTE ORDENADA ][ PARTE DESORDENADA ]
```

A cada iteração, um elemento da parte desordenada é colocado na posição correta da parte ordenada.

---

# 11. AGITAÇÃO — SHAKER / COCKTAIL SORT

O Shaker Sort é baseado no **Bubble Sort**.

A diferença principal é que ele percorre a estrutura em **duas direções**.

```text
→
←
```

### Primeira passagem

Leva elementos maiores para o final.

### Segunda passagem

Leva elementos menores para o início.

Assim, a estrutura fica:

```text
[ ORDENADO ][ DESORDENADO ][ ORDENADO ]
```

---

## Características

* Memória interna
* Estável
* O(n²)
* Ordena pelo início e pelo final

Utiliza variáveis como:

```text
ini
fim
```

Durante as passagens:

```text
fim--
ini++
```

### Para lembrar

```text
AGITAÇÃO
→ vai e volta
→ maior para o final
→ menor para o início
```

---

# 12. COMB SORT — PENTE

O Comb Sort é baseado no **Bubble Sort**, mas utiliza uma **distância entre os elementos comparados**.

Essa distância é chamada de `dist`.

Exemplo:

```text
n = 10

dist = 10
dist = 10 / 1.3
dist = 7
dist = 7 / 1.3
dist = 5
...
dist = 1
```

A ideia é começar comparando elementos distantes e reduzir essa distância até chegar a `1`.

Quando:

```text
dist = 1
```

o algoritmo se aproxima do comportamento do Bubble Sort.

---

## Características

* Memória interna
* Instável
* O(n²) no pior caso
* Faz comparações à distância

### Para lembrar

```text
PENTE
→ Bubble + distância
```

---

# 13. COMPARAÇÃO DOS ALGORITMOS PRINCIPAIS

| Algoritmo    | Estabilidade | Complexidade    | Ideia                     |
| ------------ | ------------ | --------------- | ------------------------- |
| **Bolha**    | Estável      | O(n²)           | Maior vai para o final    |
| **Seleção**  | Instável     | O(n²)           | Menor vai para o início   |
| **Inserção** | Estável      | O(n²)           | Insere na posição correta |
| **Agitação** | Estável      | O(n²)           | Vai e volta               |
| **Pente**    | Instável     | O(n²) pior caso | Usa distância             |

---

# 14. O QUE OS MÉTODOS BOLHA, SELEÇÃO E INSERÇÃO TÊM EM COMUM?

Os três:

* são algoritmos de ordenação;
* trabalham em memória interna;
* possuem complexidade O(n²) no pior caso;
* utilizam comparações;
* podem realizar trocas/deslocamentos;
* são algoritmos relativamente simples de implementar.

Porém, possuem diferenças importantes:

```text
BOLHA
→ maior para o final

SELEÇÃO
→ menor para o início

INSERÇÃO
→ insere na posição correta
```

---

# 15. QUAL É O MELHOR MÉTODO?

Não existe um único "melhor algoritmo".

A escolha depende de fatores como:

* tamanho da estrutura;
* quantidade de dados;
* quanto a estrutura já está ordenada;
* necessidade de estabilidade;
* memória disponível;
* tempo de execução.

### Exemplo

Para uma lista pequena e quase ordenada, o **Insertion Sort** pode apresentar excelente desempenho.

O importante é analisar o **cenário**.

---

# 16. DESEMPENHO DOS ALGORITMOS ESTUDADOS

Uma questão importante da avaliação é:

> Dos algoritmos estudados — bolha, seleção, inserção e pente — há um que apresenta desempenho muito bom. Qual é?

A resposta deve considerar o **estado da estrutura**.

Entre esses algoritmos, o **Insertion Sort** pode apresentar excelente desempenho quando a lista já está ordenada ou quase ordenada, pois realiza poucas movimentações e comparações.

O Bubble Sort também pode ter excelente desempenho em uma estrutura ordenada ou quase ordenada quando implementado com a verificação de `houveTroca`.

### Atenção

A pergunta pode estar relacionada ao **recurso computacional** utilizado pelo algoritmo.

Por isso, observe no enunciado se ele está perguntando especificamente sobre:

* comparações;
* trocas;
* deslocamentos;
* distância entre elementos.

---

# 17. PIOR CASO

## Bubble Sort

Uma situação ruim é:

```text
5 4 3 2 1
```

para ordenar de forma crescente.

---

## Selection Sort

Mesmo uma lista ordenada:

```text
1 2 3 4 5
```

ainda exige várias comparações para procurar o menor elemento.

---

## Insertion Sort

Uma situação ruim é:

```text
5 4 3 2 1
```

para ordenar de forma crescente.

Os elementos precisam ser deslocados várias posições.

---

## Comb Sort

No pior caso, sua complexidade é:

```text
O(n²)
```

---

# 18. EXERCÍCIO DE COMPARAÇÕES E TROCAS

Considere:

```text
Índice:
0  1  2  3  4  5  6

Valores:
7  3  5  1  8  2  5
```


### a) Quantas comparações e trocas ocorrerão utilizando Bubble Sort?

### b) Quantas comparações e trocas ocorrerão utilizando Comb Sort?

## Como resolver

Não basta olhar somente para o tamanho da lista.

É necessário **simular o algoritmo passo a passo**, contando:

```text
comparação → +1
troca → +1
```

### Bubble

O algoritmo compara:

```text
lista[i]
com
lista[i + 1]
```

Ou seja, elementos vizinhos.

### Comb

O algoritmo compara:

```text
lista[i]
com
lista[i + dist]
```

Ou seja, elementos separados pela distância `dist`.

---

# 19. ORDENAÇÃO DE OBJETOS

Quando trabalhamos com objetos, podemos ordenar utilizando uma ou mais **chaves**.

Exemplo:

```text
Pessoa
├── nome
├── email
├── telefone
└── curso
```

Se a chave de ordenação for:

```text
1ª chave → nome
2ª chave → curso
```

primeiro comparamos o nome.

Se os nomes forem iguais, comparamos o curso.

---

# 20. `equals()`

O método `equals()` verifica se dois objetos são considerados iguais.

Exemplo:

```java
pessoa1.equals(pessoa2)
```

Retorna:

```text
true
```

ou:

```text
false
```

Na classe, normalmente devemos sobrescrever `equals()` para definir quais atributos determinam a igualdade dos objetos.

---

# 21. `compareTo()`

Para ordenar objetos em Java utilizando a ordenação natural, a classe pode implementar:

```java
Comparable<Pessoa>
```

Exemplo:

```java
public class Pessoa implements Comparable<Pessoa> {
```

Depois implementamos:

```java
@Override
public int compareTo(Pessoa outra) {
    ...
}
```

---

# 22. COMO FUNCIONA O `compareTo()`?

O resultado possui três possibilidades:

```text
compareTo() < 0
→ objeto atual vem antes

compareTo() == 0
→ objetos são equivalentes para a ordenação

compareTo() > 0
→ objeto atual vem depois
```

### Exemplo

```java
String f1 = "Alexandre";
String f2 = "Pietro";
```

```java
f1.compareTo(f1)
```

Resultado:

```text
0
```

Porque estamos comparando a mesma string.

Já:

```java
f1.compareTo(f2)
```

retorna um valor negativo porque `"Alexandre"` vem antes de `"Pietro"`.

Invertendo:

```java
f2.compareTo(f1)
```

retorna um valor positivo.

### IMPORTANTE

Não é necessário decorar o número exato retornado.

Decore:

```text
NEGATIVO → antes
ZERO     → equivalente
POSITIVO → depois
```

---

# 23. `compareTo()` COM DUAS CHAVES

Se a ordenação for:

```text
1ª chave → nome
2ª chave → curso
```

podemos fazer:

```java
@Override
public int compareTo(Pessoa outra) {

    int resultadoNome =
        this.nome.compareTo(outra.getNome());

    if (resultadoNome != 0) {
        return resultadoNome;
    }

    return this.curso.compareTo(outra.getCurso());
}
```

O funcionamento é:

```text
Compara nome
    ↓
Nome é diferente?
    ↓
SIM → retorna resultado do nome
    ↓
NÃO
    ↓
Compara curso
```

---

# 24. `sort()` EM JAVA

Depois de implementar `Comparable`, podemos utilizar:

```java
Collections.sort(lista);
```

ou:

```java
lista.sort(...)
```

Quando utilizamos:

```java
Collections.sort(lista);
```

a ordenação utiliza a regra definida pelo:

```java
compareTo()
```

---

# 25. ORDENAÇÃO POR MÚLTIPLAS CHAVES

Exemplo:

```text
Pessoa
nome
curso
```

Ordenação:

```text
1ª chave → nome
2ª chave → curso
```

Outro exemplo:

```text
Processo
id
data
```

Ordenação:

```text
1ª chave → id
2ª chave → data
```

Exemplo:

```text
ID   Data
1    10/08
1    05/08
2    01/08
```

Ordenando por ID e depois data:

```text
ID   Data
1    05/08
1    10/08
2    01/08
```

---

# 26. MVC

A disciplina utiliza o padrão arquitetural:

```text
MVC
```

Onde:

```text
M → Model
V → View
C → Controller
```

## Model

Representa os dados.

Exemplo:

```text
Pessoa
Processo
Lista
```

## View

Responsável pela apresentação.

Exemplo:

```text
exibirLista()
exibirTempo()
```

## Controller

Responsável por controlar as operações.

Exemplo:

```text
listaBolha()
listaSelecao()
listaInsercao()
listaAgitacao()
listaPente()
```

### Regra da disciplina

> Ao começar um projeto, começar pelo **Model**.

---

# 27. BENCHMARK

Benchmark é utilizado para **medir e comparar o desempenho dos algoritmos**.

Podemos medir:

```text
Complexidade
├── Comparações
└── Trocas

Tempo
└── Tempo de execução
```

---

# 28. MEDIR TEMPO EM JAVA

```java
long tempoInicio, tempoFim;

tempoInicio = System.nanoTime();

// algoritmo

tempoFim = System.nanoTime();

System.out.println(
    "Tempo (ms): " +
    (tempoFim - tempoInicio) / 1000000
);
```

A ideia é:

```text
tempoInicio
     ↓
executa algoritmo
     ↓
tempoFim
     ↓
calcula diferença
```

---

### O que é ordenação e qual seu papel nos sistemas de informação?

**Resposta para estudar:**

Ordenação é o processo de organizar os elementos de uma estrutura de dados de acordo com uma ou mais chaves. Seu papel é facilitar a organização, recuperação e pesquisa dos dados, podendo melhorar o desempenho de determinadas operações.

---


### Como se calcula ou mede a complexidade em ordenação?

**Resposta para estudar:**

A complexidade representa o esforço computacional necessário para executar um algoritmo. Em algoritmos de ordenação, podemos analisá-la principalmente pela quantidade de comparações e trocas realizadas, além do tempo de execução. A complexidade pode ser representada pela notação Big-O.

---

### O que significa um algoritmo ser estável ou instável?

**Resposta para estudar:**

Um algoritmo estável mantém a ordem relativa entre elementos que possuem a mesma chave. Um algoritmo instável não garante que essa ordem será preservada.

---

### Qual dos algoritmos apresenta desempenho muito bom?

Entre os algoritmos estudados, o **Insertion Sort** pode apresentar excelente desempenho quando a estrutura já está ordenada ou quase ordenada, pois realiza poucas movimentações.

O **Bubble Sort**, quando implementado com a verificação de `houveTroca`, também pode detectar rapidamente que uma lista já está ordenada e encerrar.


---

### Quais são estáveis e quais são instáveis?

```text
BOLHA       → ESTÁVEL
SELEÇÃO     → INSTÁVEL
INSERÇÃO    → ESTÁVEL
PENTE       → INSTÁVEL
```

### Para decorar:

```text
Bolha     → SIM
Seleção   → NÃO
Inserção  → SIM
Pente     → NÃO
```

---


### Ordenação de objetos Pessoa

Classe:

```text
Pessoa
├── nome
├── email
├── telefone
└── curso
```

Chaves:

```text
1ª → nome
2ª → curso
```

Para utilizar a ordenação natural com `sort()`, a classe deve implementar `Comparable<Pessoa>` e sobrescrever o método `compareTo()`.

Exemplo:

```java
public class Pessoa implements Comparable<Pessoa> {

    @Override
    public int compareTo(Pessoa outra) {

        int resultadoNome =
            this.nome.compareTo(outra.getNome());

        if (resultadoNome != 0) {
            return resultadoNome;
        }

        return this.curso.compareTo(outra.getCurso());
    }
}
```

Também é importante possuir os métodos necessários da classe, como:

```text
getters
setters
equals()
hashCode()
toString()
compareTo()
```

---


## 1) O que é ordenar?

Organizar uma estrutura de dados de acordo com uma ou mais chaves.

---

## 2) O que é indexar?

Utilizar índices/chaves para identificar e acessar elementos de uma estrutura.

---

## 3) Por que ordenar?

Para organizar os dados e facilitar/otimizar operações de pesquisa e recuperação.

---

## 4) O que é complexidade?

É o esforço computacional necessário para executar um algoritmo.

---

## 5) O que é estabilidade?

É a capacidade de manter a ordem relativa dos elementos que possuem a mesma chave.

---

## 6) Quais são os melhores métodos de ordenação?

Não existe um único melhor método. A escolha depende do tamanho da estrutura, do quanto ela já está ordenada, da necessidade de estabilidade, da memória disponível e do tempo desejado.

---

## 7) O que Bolha, Seleção e Inserção têm em comum?

Todos são algoritmos de ordenação de memória interna, são relativamente simples e possuem complexidade O(n²) no pior caso. Eles utilizam comparações e podem realizar trocas ou deslocamentos.

---

```
