# Survival: The Last Shelter

Projeto de sandbox de sobrevivência em mundo aberto pós-apocalíptico, com visual 3D low-poly moderno e foco inicial em Android de entrada.

## Mundo obrigatório

- Exatamente 3 cidades principais.
- Exatamente 2 grandes florestas.
- Quantidade variável/aleatória de outros pontos de interesse, estruturas secundárias, ruínas, acampamentos e locais de saque.
- A geração aleatória nunca pode remover as cinco regiões obrigatórias.
- O mundo gerado deve ser persistido no salvamento para manter o mesmo mapa ao retornar.

## Pilares

- Sobrevivência: vida, fome, sede e energia.
- Exploração livre em sandbox.
- Coleta e construção: madeira, pedra, metal, casas, muros, torres e bunkers.
- Equipamentos: mochilas, capacetes, coletes, roupas de proteção e armas encontradas no mundo.
- Inimigos distintos: zumbi comum, mutante resistente e criatura cega que caça pelo som.
- Modos: campanha solo offline como primeira entrega; multiplayer online planejado para uma fase posterior.

## Engine escolhida

**Unity 6 Personal (Unity 6.3 LTS)** será a engine do projeto. O plano Personal é gratuito para usuários que atendem aos critérios de elegibilidade da Unity.

O projeto não dependerá de recursos pagos, créditos de IA ou cobrança por uso. A compilação Android ainda precisa ser validada por um build real e gratuito.

## Estado atual

O repositório contém a estrutura inicial de um projeto Unity, com versão do Editor registrada, manifesto de pacotes, scripts de mundo, dados de personagem/equipamento e assets GLB reais commitados.

- Layout determinístico com exatamente 3 cidades e 2 florestas obrigatórias, além de pontos extras variáveis.
- Salvamento local do layout do mundo em JSON.
- Dados-base de aparência do personagem masculino/feminino.
- Definições de peças vestíveis e loadout por slots, incluindo roupa básica inicial.
- Salvamento local do perfil, aparência e equipamentos do jogador.
- Modelos de personagens e equipamentos em `Assets/Art/`; a integração e reprodução no Unity ainda não foram verificadas.

**Ainda não existe cena jogável, criador visual conectado aos modelos, sistemas completos de sobrevivência, APK ou teste no Moto G24.** Os scripts e assets precisam ser importados, configurados e testados pelo Unity Editor.

O protótipo anterior `zombie-survival-godot.` foi descartado e não será usado como base.

## Documentação

- [Conceito e sistemas](docs/CONCEPT.md)
- [Plano de desenvolvimento](docs/ROADMAP.md)
- [Direção visual aprovada para o terreno](docs/TERRAIN-ART-DIRECTION.md)
- [Pipeline gratuito de build Android](docs/BUILD-PIPELINE.md)
- [Pipeline de assets e servidores MCP](docs/ASSET-PIPELINE.md)
- [Personagens e equipamentos planejados](docs/CHARACTERS-EQUIPMENT.md)
- [Instruções para agentes de IA](AGENTS.md)
- [Skill de busca e integração de assets](skills/survival-game-assets/SKILL.md)
- [Skill de desenvolvimento de sistemas Unity para sobrevivência](skills/unity-survival-systems/SKILL.md)
- [Skills upstream de game dev](https://github.com/gamedev-skills/awesome-gamedev-agent-skills)
- [Exemplos oficiais Unity Character Controller](https://github.com/Unity-Technologies/CharacterControllerSamples)

## Princípios técnicos

- Priorizar ferramentas e assets gratuitos com licenças verificáveis.
- Não depender de serviços pagos ou conexão permanente para o modo solo.
- Construir e testar em etapas pequenas; não chamar documentação de jogo jogável.
- Manter a arquitetura preparada para multiplayer, sem prometer recursos online antes de existir infraestrutura.
- Não ativar cobrança por uso nem cadastrar cartão para contornar limites gratuitos.
