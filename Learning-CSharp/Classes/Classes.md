## Classes em Programação Orientada a Objetos (POO) em C#
### Introdução
> As classes são elementos fundamentais na programação orientada a objetos (POO) em C#. Elas servem como modelos ou estruturas para criar objetos, que são instâncias dessas classes. As classes permitem organizar e abstrair os dados e comportamentos relacionados a um conceito específico dentro de um programa.

### Definindo uma Classe
Para definir uma classe em C#, utilizamos a palavra-chave class seguida pelo nome da classe. Uma classe pode conter variáveis, métodos e propriedades que definem suas características e comportamentos.

```csharp
public class MinhaClasse
{
    // Variáveis de instância (ou atributos)
    public int Numero;
    public string Texto;

    // Método de instância (ou comportamento)
    public void ExibirMensagem()
    {
        Console.WriteLine("Essa é uma mensagem de exemplo.");
    }
}
```
### Criando Objetos
Uma vez que uma classe foi definida, podemos criar objetos a partir dela utilizando o operador new. Isso aloca memória para o objeto na memória e chama o construtor padrão da classe, se existir.

```csharp
MinhaClasse objeto1 = new MinhaClasse();
MinhaClasse objeto2 = new MinhaClasse();
```
### Acesso aos Atributos e Métodos
Para acessar os atributos e métodos de um objeto, utilizamos o operador ponto .. Isso nos permite modificar ou recuperar os valores dos atributos e invocar os métodos definidos na classe.

```csharp
objeto1.Numero = 42;
objeto1.Texto = "Exemplo";
objeto1.ExibirMensagem();
```
### Construtores
Os construtores são métodos especiais que são executados quando um objeto é criado a partir de uma classe. Eles permitem inicializar os atributos da classe com valores específicos. Se não definirmos um construtor explicitamente, a classe terá um construtor padrão sem parâmetros.

```csharp
public class MinhaClasse
{
    public int Numero;
    public string Texto;

    // Construtor personalizado
    public MinhaClasse(int numero, string texto)
    {
        Numero = numero;
        Texto = texto;
    }

    // Construtor padrão
    public MinhaClasse()
    {
        // Sem parâmetros
    }
}
```
### Modificadores de Acesso
Em C#, podemos usar modificadores de acesso para controlar a visibilidade dos membros da classe. Os modificadores de acesso são: public, private, protected, internal e outros.

- public: Permite que o membro seja acessado de qualquer lugar no código.
- private: Limita o acesso ao membro apenas dentro da própria classe.
- protected: Permite o acesso ao membro dentro da própria classe e em classes derivadas (herança).
- internal: Torna o membro visível apenas dentro do mesmo assembly.
# Conclusão
> As classes são a base da programação orientada a objetos em C#. Elas permitem criar estruturas personalizadas para representar entidades do mundo real ou abstrato dentro do programa. Utilizando classes, é possível organizar o código de forma mais eficiente, melhorar a legibilidade e facilitar a manutenção.