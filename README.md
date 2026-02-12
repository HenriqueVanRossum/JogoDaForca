# 🎯 Jogo da Forca (C# Console)

Jogo da Forca desenvolvido em **C#** para rodar no console.
O jogador deve descobrir a palavra secreta antes de atingir o limite de erros.

A palavra é escolhida aleatoriamente a partir de uma lista interna.

---

## 🚀 Como clonar o projeto

No terminal:

```bash
git clone https://github.com/HenriqueVanRossum/JogoDaForca.git
```

Entre na pasta do projeto:

```bash
cd JogoDaForca
```

---

## ▶️ Como rodar o projeto

### 1️⃣ Verifique se o .NET está instalado

```bash
dotnet --version
```

Se não estiver instalado:
[https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

---

### 2️⃣ Execute o projeto

Dentro da pasta:

```bash
dotnet run
```

---

## 🎮 Como jogar

* O jogo escolhe uma palavra secreta aleatoriamente.
* A palavra aparece como `_ _ _ _`.
* Digite uma letra por vez.
* Se acertar, a letra aparece na posição correta.
* Se errar, a forca é desenhada e o erro é contabilizado.
* O jogo termina quando você descobre a palavra.

Ao final, será exibida a mensagem:

```
Voce ganhou!
```

---

## 🛠 Tecnologias utilizadas

* C#
* .NET
* Console Application

---

## 📌 Estrutura do projeto

* `Program.cs` → Contém a lógica principal do jogo
* `DesenharForca` → Classe responsável por desenhar a forca conforme o número de erros

---

## 📚 Conceitos praticados

* Listas (`List<char>`)
* Manipulação de strings
* Estruturas de repetição
* Condicionais
* Randomização
* Lógica de validação de entrada

---
