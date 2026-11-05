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

O repositório contém agora a estrutura inicial de um projeto Unity, com versão do Editor registrada, manifesto mínimo de pacotes, regras de Git e scripts iniciais para:

- Representar cidades, florestas e pontos de interesse.
- Gerar um layout determinístico com exatamente 3 cidades e 2 florestas obrigatórias, além de pontos extras variáveis.
- Salvar e carregar o layout localmente em JSON, preservando o mapa gerado.

**Ainda não existe cena jogável, personagem, sistemas completos de sobrevivência, APK ou teste no Moto G24.** Os scripts foram adicionados ao repositório, mas ainda precisam ser importados e compilados pelo Unity Editor.

O protótipo anterior `zombie-survival-godot.` foi descartado e não será usado como base.

## Documentação

- [Conceito e sistemas](docs/CONCEPT.md)
- [Plano de desenvolvimento](docs/ROADMAP.md)
- [Pipeline gratuito de build Android](docs/BUILD-PIPELINE.md)
- [Pipeline de assets e servidores MCP](docs/ASSET-PIPELINE.md)
- [Instruções para agentes de IA](AGENTS.md)
- [Skill de busca e integração de assets](skills/survival-game-assets/SKILL.md)

## Princípios técnicos

- Priorizar ferramentas e assets gratuitos com licenças verificáveis.
- Não depender de serviços pagos ou conexão permanente para o modo solo.
- Construir e testar em etapas pequenas; não chamar documentação de jogo jogável.
- Manter a arquitetura preparada para multiplayer, sem prometer recursos online antes de existir infraestrutura.
- Não ativar cobrança por uso nem cadastrar cartão para contornar limites gratuitos.
