# Conceito do jogo

## Experiência central

Sobreviver em um mundo pós-apocalíptico perigoso. O jogador explora, coleta materiais, encontra equipamentos e transforma um abrigo simples em uma base segura. O perigo deve incentivar planejamento, furtividade e decisões de risco.

## Mundo

- Regiões iniciais: floresta e zona urbana abandonada.
- Locais exploráveis: casas, lojas, depósitos e estruturas em ruínas.
- Ciclo de dia e noite, com mudanças de visibilidade e risco.
- Escopo inicial controlado: uma área pequena e densa, expansível depois de validada a performance.

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
