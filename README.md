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

**Unity 6 Personal** será a engine do projeto. O plano Personal é gratuito e não exige cartão de crédito para uso dentro dos critérios de elegibilidade da Unity.

O projeto não dependerá de recursos pagos, créditos de IA ou compilação em nuvem paga. Antes de iniciar o protótipo, será validado um caminho gratuito de geração do APK Android usando o repositório e automação disponível.

## Estado atual

Este repositório começa limpo. O protótipo anterior `zombie-survival-godot.` foi descartado e não será usado como base.

A escolha da engine está feita, mas ainda não existe protótipo jogável nem APK validado. A próxima etapa é validar o pipeline de build Android pelo Unity Build Automation, que tem franquia gratuita e bloqueia o serviço ao atingir os limites sem cartão cadastrado.

## Documentação

- [Conceito e sistemas](docs/CONCEPT.md)
- [Plano de desenvolvimento](docs/ROADMAP.md)
- [Pipeline gratuito de build Android](docs/BUILD-PIPELINE.md)

## Princípios técnicos

- Priorizar ferramentas e assets gratuitos com licenças verificáveis.
- Não depender de serviços pagos ou conexão permanente para o modo solo.
- Construir e testar em etapas pequenas; não chamar documentação de jogo jogável.
- Manter a arquitetura preparada para multiplayer, sem prometer recursos online antes de existir infraestrutura.
- Não ativar cobrança por uso nem cadastrar cartão para contornar limites gratuitos.
