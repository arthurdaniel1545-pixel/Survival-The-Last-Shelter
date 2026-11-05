# Pipeline de compilação Android sem cartão

## Caminho preferido para testar

Usar **Unity Build Automation (UBA)**, serviço oficial da Unity, como primeira opção para gerar APK Android na nuvem. Isso evita depender de instalar o Unity Editor no Moto G24.

Documentação oficial consultada:
- Build Automation: https://docs.unity.com/en-us/build-automation
- Plataformas por sistema operacional: https://docs.unity.com/en-us/build-automation/reference/supported-platforms-on-each-builder-os
- Configuração de builds: https://docs.unity.com/en-us/build-automation/basic-build-configuration/overview
- Preços e limites gratuitos: https://unity.com/pt/products/pricing-updates

## Limites gratuitos publicados em 2026

A Unity informa uma franquia mensal de:
- 200 minutos de compilação Windows Micro.
- 100 minutos de compilação Mac Standard.
- 100 GB de transferência de saída gratuita.

A documentação de preços diz que, ao ultrapassar a franquia sem método de pagamento cadastrado, o acesso é bloqueado; para continuar usando o serviço além da franquia, seria necessário cadastrar cartão e passar para cobrança por consumo. **Este projeto não deve fazer isso.** Se a franquia acabar, parar e aguardar a renovação gratuita.

## Compatibilidade Android

A documentação atual lista Android como suportado no Windows 11 24H2 e macOS. A máquina Windows Micro é uma das opções de build. A configuração final precisa ser validada no painel do UBA antes de depender dela.

## Passos de configuração que exigem a conta do usuário

1. Criar/usar uma Unity ID e entrar no Unity Dashboard.
2. Abrir DevOps / Build Automation e iniciar o plano gratuito, sem escolher cobrança por consumo.
3. Conectar o repositório GitHub `arthurdaniel1545-pixel/Survival-The-Last-Shelter` como fonte.
4. Criar configuração Android apontando para a branch `main`.
5. Escolher uma máquina e versão Unity compatíveis com Android.
6. Executar primeiro um build mínimo de teste e conferir os minutos consumidos.
7. Baixar o APK somente depois de o build concluir.

Não compartilhar senha da Unity no chat. Não habilitar Pay as you go. Não adicionar cartão.

## Por que não começar pelo GameCI no GitHub Actions

GameCI é um projeto comunitário útil, mas o fluxo Personal documentado envolve uma licença Unity Personal exportada do Unity Hub e armazenada como secret. A documentação do GameCI alerta que a ativação manual de Personal deixou de ser suportada pela Unity, e a documentação oficial da Unity diz que Unity Hub é o único método de ativação para Personal. Isso torna o GameCI uma opção de risco para um fluxo feito apenas pelo celular, sem um computador com Unity Hub.

Fontes:
- https://game.ci/docs/github/activation/
- https://docs.unity.com/en-us/engine/6000.6/manual/get-started/install-and-upgrade/licenses-and-activation/license-activation-methods

## Estado

Este documento descreve o caminho a validar; ainda não foi criado um projeto Unity, configurado o UBA nem gerado um APK. A configuração no Unity Dashboard exige ação na conta do usuário. Não afirmar que o pipeline funciona até concluir um build real.
