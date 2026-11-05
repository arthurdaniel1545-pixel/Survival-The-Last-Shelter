# Plano de desenvolvimento

## Fase 0 — Fundação e decisões

- [x] Criar repositório novo e independente.
- [x] Registrar visão, pilares e restrições.
- [x] Escolher Unity 6 Personal como engine do projeto.
- [ ] Validar um pipeline gratuito de build Android que funcione pelo fluxo GitHub/celular, sem exigir cartão.
- [ ] Comparar opções de renderização e definir configurações leves para o Moto G24.
- [ ] Definir pipeline gratuito para modelos, animações, áudio e testes.
- [ ] Fixar convenções de pastas, versões e licenças.

**Critério de saída:** decisão técnica baseada em teste mínimo real. O pipeline precisa gerar um APK Android sem depender de serviço pago ou de cartão.

**Risco técnico a resolver antes do protótipo:** a documentação atual do GameCI informa que a ativação manual de licenças Unity Personal deixou de ser suportada, embora descreva um procedimento alternativo. Não presumir que o build remoto funcionará: testar a ativação e a compilação com a licença gratuita primeiro. Não pedir senha da conta Unity nem configurar cobrança para contornar esse bloqueio.

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
