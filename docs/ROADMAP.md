# Plano de desenvolvimento

## Fase 0 — Fundação e decisões

- [x] Criar repositório novo e independente.
- [x] Registrar visão, pilares e restrições.
- [x] Escolher Unity 6 Personal como engine do projeto.
- [ ] Validar o Unity Build Automation no plano gratuito para gerar APK Android, sem cadastrar cartão nem habilitar cobrança por consumo.
- [x] Documentar os limites gratuitos e os passos de configuração do pipeline Android.
- [ ] Comparar opções de renderização e definir configurações leves para o Moto G24.
- [ ] Definir pipeline gratuito para modelos, animações, áudio e testes.
- [ ] Fixar convenções de pastas, versões e licenças.

**Critério de saída:** decisão técnica baseada em teste mínimo real. O Unity Build Automation precisa gerar um APK Android dentro da franquia gratuita; se atingir o limite, parar e aguardar a renovação, sem habilitar cobrança. Ver [pipeline de build](BUILD-PIPELINE.md).

**Risco técnico:** GameCI no GitHub Actions não será o caminho principal, pois depende de ativação da licença Personal via Unity Hub e a ativação manual não é suportada oficialmente. O caminho preferido é Unity Build Automation, cuja compatibilidade e franquia gratuita precisam ser confirmadas no primeiro build.

## Fase 1 — Protótipo de sobrevivência offline

- [ ] Projeto Unity 6 com configuração Android validada.
- [ ] Cena jogável pequena com terreno e câmera.
- [ ] Controles de toque e movimentação.
- [ ] Vida, fome, sede e energia.
- [ ] Coleta de madeira, pedra e metal.
- [ ] Inventário mínimo.
- [ ] Um zumbi comum com detecção e perseguição.
- [ ] Salvamento local.

**Critério de saída:** instalar/abrir no Android e jogar um ciclo básico sem internet.

## Fase 2 — Ameaças e exploração

- [ ] Mutante resistente.
- [ ] Criatura cega com percepção por som.
- [ ] Gerar e validar obrigatoriamente 3 cidades e 2 florestas.
- [ ] Adicionar quantidade variável de pontos de interesse e estruturas secundárias.
- [ ] Dia/noite.
- [ ] Itens e armas encontrados no mundo.

## Fase 3 — Construção e progressão

- [ ] Construção modular de abrigo, muros e torre.
- [ ] Equipamentos e roupas com atributos.
- [ ] Bunker subterrâneo.
- [ ] Balanceamento de recursos e ameaças.

## Fase 4 — Multiplayer online

- [ ] Definir modelo de servidor e custos operacionais.
- [ ] Sincronizar jogadores, inimigos, inventário e construções.
- [ ] Testes de reconexão, latência e segurança.
- [ ] Manter o modo solo offline independente.

## Critérios permanentes

- Testar em aparelho modesto a cada etapa.
- Não adicionar dependência paga sem aprovação explícita.
- Não cadastrar cartão nem habilitar cobrança por uso para ultrapassar limites gratuitos.
- Não afirmar que algo está pronto sem executar e verificar.
- Manter documentação das licenças de assets externos.
