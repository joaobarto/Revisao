**#Atividade 1**
# Gerador de Senhas em C#

Este projeto implementa um **Gerador de Senhas** em C# que permite criar senhas aleatórias com base nas preferências definidas pelo usuário. O programa também salva a senha gerada em um arquivo de backup chamado `bkp.txt`.

## Funcionalidades

1. **Quantidade de dígitos**: O usuário define quantos dígitos deseja para a senha.
2. **Caracteres personalizados**:
   - Números (`0-9`)
   - Símbolos especiais (`!@#$%^&*()_+-=[]{}|;:,.<>?`)
   - Letras maiúsculas (`A-Z`)
   - Letras minúsculas (`a-z`)
3. **Validação de entrada**: O programa verifica as entradas do usuário, garantindo que escolhas inválidas sejam tratadas corretamente.
4. **Senha salva**: A senha gerada é automaticamente armazenada no arquivo `bkp.txt`.

## Como usar o programa

1. Compile e execute o programa.
2. Responda às perguntas para configurar sua senha:
   - **Quantidade de dígitos**: Insira um número inteiro maior que 0.
   - Escolha incluir ou não os seguintes tipos de caracteres:
     - **Números** (S/N)
     - **Símbolos** (S/N)
     - **Letras maiúsculas** (S/N)
     - **Letras minúsculas** (S/N)
3. A senha gerada será exibida no console e salva no arquivo `bkp.txt` na pasta do programa.

## Exemplo de Execução

```
--------------------------------------------------------------------------------
                              GERADOR DE SENHA
--------------------------------------------------------------------------------

             Qual a quantidade de dígitos que você deseja?
8

                   Incluir números S/N?
S

                   Incluir símbolos S/N?
N

                  Incluir letras maiúsculas S/N?
S

                  Incluir letras minúsculas S/N?
S

                  Senha gerada: AbcD12Ef
```

## Estrutura do Código

### Classe `Program`

A classe principal possui:

1. **Método `Main`**:
   - Gerencia a interação com o usuário.
   - Valida as entradas.
   - Chama o método `GerarSenha` para criar a senha.

2. **Método `GerarSenha`**:
   - Recebe as preferências do usuário.
   - Constrói uma senha aleatória com base nos tipos de caracteres escolhidos.
   - Salva a senha em um arquivo de backup (`bkp.txt`).

### Validações
- O programa valida as entradas para garantir que o usuário forneça escolhas adequadas, como `S` (sim) ou `N` (não).
- Caso nenhuma categoria de caractere seja escolhida, uma mensagem de erro é retornada.

## Requisitos

- **.NET Framework** ou **.NET Core** (para compilar e executar o programa).
- Um editor de texto ou IDE, como Visual Studio ou Visual Studio Code.

## Arquivo de Backup

- O arquivo `bkp.txt` é gerado automaticamente na mesma pasta onde o programa está sendo executado.
- Ele conterá a última senha gerada.

---

Desenvolvido para práticas de geração de senhas seguras em C#. Caso tenha dúvidas ou sugestões, fique à vontade para contribuir!

