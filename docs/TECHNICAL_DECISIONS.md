# Decisões técnicas iniciais

## Engine recomendada: Godot 4 (GDScript)

A recomendação inicial é Godot 4 usando GDScript e renderer **Compatibility**, sujeita a um teste de desempenho no aparelho antes de assumir que o jogo completo rodará bem.

Motivos:
- O editor oficial Android permite criar, editar e exportar projetos 2D e 3D diretamente em Android compatível.
- O fluxo Android do editor pode exportar sem instalar manualmente JDK e Android SDK quando se usa a exportação suportada pelo próprio editor.
- O renderer Compatibility usa OpenGL ES 3.0 e é a opção mais conservadora para compatibilidade com aparelhos modestos.
- GDScript evita depender de C#/Mono, que não é suportado no editor Android.

Limitações importantes:
- O editor Android ainda é descrito como early access/experimental e sua interface não é otimizada para celulares pequenos.
- A documentação alerta que o renderer Forward+ não é recomendado no editor Android por problemas de desempenho.
- A capacidade real do Moto G24 precisa ser medida com uma cena de teste; especificações nominais não garantem FPS estável.
- O editor no telefone e a execução do jogo no telefone competem pelos mesmos recursos. Sempre que possível, builds e verificações automatizadas devem ser feitos no GitHub Actions, sem presumir que isso já esteja configurado.

## Regras de desempenho para o protótipo

- Começar com uma região pequena de teste, não com o mapa inteiro.
- Usar geometria low-poly, materiais simples, iluminação econômica e texturas pequenas.
- Limitar inimigos ativos e objetos físicos simultâneos.
- Carregar e descarregar setores do mapa conforme a distância do jogador.
- Medir FPS, memória, temperatura e estabilidade no Moto G24 antes de aumentar a escala.
- Não prometer multiplayer antes de existir uma solução de servidor e sincronização testada.

## Mundo sandbox: regra de geração

O gerador do mundo deve sempre criar:
1. Três cidades principais, sem exceção.
2. Duas grandes florestas, sem exceção.
3. Conteúdo adicional em quantidade variável, escolhido aleatoriamente: pontos de interesse, acampamentos, postos, fazendas, depósitos, ruínas e estruturas isoladas.

A geração deve validar distâncias, acessibilidade e ausência de sobreposição entre regiões. O resultado precisa ser determinístico por semente e salvo junto com a partida, para que o mapa não mude ao recarregar o jogo.

## Referências oficiais consultadas

- Editor Android: https://docs.godotengine.org/en/latest/tutorials/editor/using_the_android_editor.html
- Exportação Android: https://docs.godotengine.org/en/latest/tutorials/export/exporting_for_android.html
- Requisitos de sistema: https://docs.godotengine.org/en/latest/about/system_requirements.html

Esta decisão é uma recomendação inicial, não uma garantia de desempenho nem uma afirmação de que já existe um protótipo executável.
