# Conceito do jogo

## Experiência central

Sandbox de sobrevivência em um mundo aberto pós-apocalíptico. O jogador tem liberdade para explorar, coletar materiais, encontrar equipamentos, fabricar itens e construir sua própria base. O mundo deve permitir diferentes estilos de jogo, sem obrigar o jogador a seguir uma campanha linear.

## Engine e custo

- Engine escolhida: **Unity 6 Personal**.
- O plano Personal é gratuito para quem atende aos critérios de elegibilidade da Unity e não exige cartão de crédito.
- Não usar serviços pagos, créditos de IA pagos ou automações que exijam cadastrar cartão.
- O pipeline de compilação Android precisa ser validado dentro dos limites gratuitos antes de depender dele.
- Unity Build Automation/serviços de nuvem são opcionais; se os limites gratuitos acabarem, o projeto deve parar e aguardar a renovação, sem ativar cobrança automática.
- O uso de Unity 6 não significa que o editor possa ser executado diretamente no Moto G24. O fluxo de criação e build deve ser resolvido por ferramentas compatíveis com o celular e pelo GitHub.

## Mundo aberto e geração

O mapa deve ser sandbox e conter obrigatoriamente:
- **Exatamente 3 cidades** principais, abandonadas e exploráveis.
- **Exatamente 2 grandes florestas** como regiões naturais principais.

Além dessas cinco regiões obrigatórias, o mundo terá conteúdo variável:
- Quantidade aleatória de pontos de interesse, como postos, fazendas, acampamentos, depósitos, estações e construções isoladas.
- Quantidade aleatória de estruturas secundárias, ruínas, estradas, abrigos e locais de saque.
- Distribuição e composição de recursos com variação por partida ou por mundo salvo.

A aleatoriedade nunca pode remover ou reduzir as 3 cidades e as 2 florestas obrigatórias. O gerador deve evitar posicionamentos impossíveis, sobreposição de regiões e locais inacessíveis. O mundo gerado deve ser salvo para manter o mesmo mapa quando o jogador retornar à partida.

As cidades e florestas devem ser distintas entre si, com identidade visual, recursos, perigos e oportunidades próprias. Casas, lojas, depósitos e outras estruturas das cidades devem poder ser exploradas quando fizer sentido para o escopo e desempenho.

O tamanho do mapa e a densidade de objetos devem ser definidos após testes reais de desempenho em Android de entrada. Usar carregamento por regiões/streaming quando viável, sem tentar manter todo o cenário detalhado carregado ao mesmo tempo.

## Necessidades do jogador

- Vida: reduzida por ataques, quedas e perigos ambientais.
- Fome e sede: exigem encontrar comida e água.
- Energia: limita ações intensas e recuperação.
- Inventário: recursos, consumíveis, armas e equipamentos.

## Recursos e construção

Recursos planejados: madeira, pedra e metal.

Construções planejadas:
- Abrigo/casa simples.
- Muros e portões.
- Torre de observação.
- Bunker subterrâneo (fase posterior, por exigir sistemas e geometria adicionais).

Construção deve usar peças modulares e posicionamento simples, adequado a controles por toque.

## Ameaças

1. **Zumbi comum** — ameaça básica, detecta e persegue o jogador.
2. **Mutante resistente** — mais resistente e perigoso em combate direto.
3. **Criatura cega** — caça por som. Correr, disparar, quebrar objetos e construir podem revelar a posição do jogador. Movimento cuidadoso e distrações sonoras devem permitir estratégias alternativas.

A criatura cega precisa de regras legíveis: sons têm alcance e intensidade, e o jogador deve conseguir entender por que foi detectado.

## Equipamentos

Mochilas, capacetes, coletes e roupas de proteção alteram capacidade de carga ou resistência. Armas são encontradas durante a exploração; balanceamento e disponibilidade serão definidos no protótipo.

## Direção visual

3D low-poly moderno, formas limpas, materiais simples e boa leitura em tela pequena. Evitar estética PS1, pixel art e excesso de efeitos. Priorizar iluminação econômica e geometria otimizada.

## Plataformas e modos

- Primeira meta: modo solo offline funcional.
- Meta futura: multiplayer online, depois que o loop solo, sincronização de estado e infraestrutura de servidor forem avaliados.
- O modo offline não pode depender de login, servidor ou conexão constante.

## Restrições reais

O desenvolvimento é feito a partir de um Moto G24, com recursos limitados. Evitar mundos enormes, shaders pesados, grandes quantidades de inimigos simultâneos e assets de alta resolução. Usar apenas assets com licença compatível e registrar suas fontes.
