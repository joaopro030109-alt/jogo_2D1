# jogo_2D.
jogo para os alunos treinarem o versionamento de codigo 

25/08 - todos os dias tera um relatorio de todas as aulas e sobre todos os programas que usamos 

criamos umas conta no github e aprendemos a usar ele com a unity 
aprendemos a usar suas ferramentas para facilitar nosso desenvolvimento na criação de jogos algumas da ferramenta são
repositorio: a pasta do projeto sobre controle do git 
commit: um fato do projeto com uma mensagem sua indicando oque você fez 
branch: uma linha paralela que testa sem danificas o jogo ou o programa salvo 
push: enviar os comentarios para github
pull: tras oque os colegas criaram como oque mudaram no projeto para organização 
merge: junta o trabalho de duas pessoas em um so 

22/09
hoje melhoramos o codigo para limitação de pulojunto com a identificação de chão para a criação de umçi,ite para o player 
29/09
criamos o freaps que e uma ferramenta para nos organizar e facilitar nosso desenvolvimento dos materiais e desines craficos 
nos ajudando mo salvamento de nossos projetos para não termos que criar outros materiais e sendo um meio mais rapido para nossa criação 
06/10
finalizei definitivamente o jogo adicionamos uma nova função nele coloquie o dash uma forma nova de movimentação
para facilitar e ajudar o jogador com alguns desafios que existe dentro do proprio jogo 
08/10
O SceneManager é uma ferramenta da Unity usada para controlar as cenas do jogo. Uma cena pode ser uma fase, um menu, uma tela de carregamento ou qualquer outra parte do jogo.
Com o SceneManager, você pode **trocar de uma cena para outra**, **reiniciar uma fase** ou **voltar para o menu principal**. Por exemplo, quando o jogador termina a primeira fase, o SceneManager pode carregar automaticamente a segunda fase.
Um exemplo simples seria:
```csharp
using UnityEngine.SceneManagement;
SceneManager.LoadScene("Fase2");
``
Nesse exemplo, quando esse código for executado, a Unity fecha a cena atual e carrega a cena chamada **"Fase2"**.
Assim, o SceneManager é muito importante para organizar as diferentes partes do jogo e controlar quando o jogador deve passar de uma cena para outra.
Claro! O **SceneManager** pode ser usado de várias formas dentro de um jogo. Alguns exemplos são:
**1. Passar para a próxima fase**
Quando o jogador chega ao final da fase, o SceneManager pode carregar a próxima cena.
```csharp
SceneManager.LoadScene("Fase2");
```
**2. Voltar para o menu principal**
Quando o jogador aperta um botão de "Menu", você pode carregar a cena do menu.
```csharp
SceneManager.LoadScene("Menu");
```
**3. Reiniciar a fase**
Se o personagem morrer, o SceneManager pode carregar novamente a fase atual.
```csharp
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
```
**4. Criar uma tela de Game Over**
Quando o jogador perde, você pode trocar para uma cena chamada "GameOver".
```csharp
SceneManager.LoadScene("GameOver");
```
**5. Ir para uma tela de vitória**
Quando o jogador termina todas as fases, pode aparecer uma cena de vitória.
```csharp
SceneManager.LoadScene("Vitoria");
```
**Resumindo:** o SceneManager funciona como um **controlador das cenas do jogo**. Ele permite decidir quando o jogador deve sair de uma cena e entrar em outra.
