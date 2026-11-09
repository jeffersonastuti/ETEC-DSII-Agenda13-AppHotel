# App Hotel | Agenda 13 - Desenvolvimento de Sistemas II

Aplicativo acadêmico de **simulação de hospedagem**, desenvolvido para o Fichário da **Agenda 13 de Desenvolvimento de Sistemas II**, do curso Técnico em Desenvolvimento de Sistemas da ETEC / Centro Paula Souza.

O projeto parte dos conceitos apresentados no material *Imagens e Componentes Diversos de Interface Gráfica* e apresenta um layout personalizado, uma tela de resumo da estadia e uma tela **Sobre**, com a identificação do desenvolvedor.

> **Importante:** este é um simulador para fins didáticos. As acomodações e tarifas são fictícias. O aplicativo não realiza reservas reais nem processa pagamentos.

## Funcionalidades

- **Seleção de hóspedes:** ajuste de adultos e crianças com `Stepper` e exibição dos valores na interface.
- **Escolha de acomodação:** lista de quartos com `Picker`, descrição, preço da diária e capacidade máxima.
- **Período da estadia:** seleção de check-in e check-out com `DatePicker` e formato brasileiro (`dd/MM/yyyy`).
- **Validações:** verificação da quantidade de hóspedes e das datas informadas.
- **Resumo da hospedagem:** apresentação do quarto, hóspedes, período, número de noites e valor total estimado.
- **Tela Sobre:** identificação do desenvolvedor, ano, curso, disciplina e conceitos empregados.
- **Navegação entre telas:** acesso ao resumo, à página Sobre e retorno ao formulário.

## Tecnologias e conceitos estudados

| Tecnologia ou conceito | Aplicação no projeto |
| --- | --- |
| **C#** | Regras de validação, navegação e cálculo do valor da hospedagem |
| **XAML** | Criação e organização das interfaces |
| **.NET MAUI 10** | Estrutura da aplicação e execução no Windows |
| **Grid, Border e StackLayout** | Composição do layout personalizado |
| **Stepper, Picker e DatePicker** | Seleção de hóspedes, acomodação e datas |
| **BindingContext / Data Binding** | Vinculação de informações e passagem do objeto `Hospedagem` entre telas |

## Telas do aplicativo

**1. Contratação de hospedagem:** seleção de hóspedes, quarto e datas, com botão para visualizar o resumo.

**2. Resumo da estadia:** apresentação dos dados escolhidos e cálculo da estimativa com base na diária e na quantidade de noites.

**3. Sobre o aplicativo:** identificação do autor e descrição do objetivo pedagógico da atividade.

## Como executar no Windows

### Pré-requisitos

- Windows 11 ou ambiente Windows compatível com o destino do projeto.
- Visual Studio 2026 com a carga de trabalho **Desenvolvimento de .NET Multi-Platform App UI (.NET MAUI)**.
- SDK **.NET 10** e dependências do Windows App SDK restauradas pelo NuGet.

### Passo a passo

1. Baixe o repositório pelo botão **Code > Download ZIP** ou clone-o com Git.
2. Extraia os arquivos, se necessário, e abra `MauiAppHotel.sln` no Visual Studio.
3. Aguarde a restauração dos pacotes NuGet. Caso necessário, use o terminal na pasta da solução:

   ```powershell
   dotnet restore
   ```

4. Na barra superior do Visual Studio, selecione **Debug** e **Windows Machine**.
5. Em **Compilação > Gerenciador de Configurações**, confira se **Compilar** e **Implantar** estão habilitados para o projeto `MauiAppHotel`.
6. Use **Compilação > Recompilar Solução** e depois pressione **F5** para executar.
7. Teste os campos do formulário, abra a tela **Sobre** e visualize o **Resumo da estadia**.

**Observação:** esta versão do projeto está configurada para `net10.0-windows10.0.19041.0`, destinada à execução no Windows. O conteúdo didático original da Agenda 13 foi adaptado para o ambiente disponível no Visual Studio 2026.

## Estrutura principal

```text
ETEC-DSII-Agenda13-AppHotel/
├── MauiAppHotel.sln
├── .gitignore
└── MauiAppHotel/
    ├── MauiAppHotel.csproj
    ├── App.xaml
    ├── App.xaml.cs
    ├── MauiProgram.cs
    ├── Models/
    │   ├── Hospedagem.cs
    │   └── Quarto.cs
    ├── Views/
    │   ├── ContratacaoHospedagem.xaml
    │   ├── ContratacaoHospedagem.xaml.cs
    │   ├── HospedagemContratada.xaml
    │   ├── HospedagemContratada.xaml.cs
    │   ├── SobrePage.xaml
    │   └── SobrePage.xaml.cs
    ├── Properties/
    │   └── launchSettings.json
    ├── Resources/
    └── Platforms/
        └── Windows/
            └── Package.appxmanifest
```

O projeto também inclui recursos de interface e arquivos auxiliares das plataformas suportadas pela estrutura do .NET MAUI. Nesta entrega, o destino de compilação utilizado é o Windows.

## Evidências da atividade

O aplicativo foi compilado e executado no Visual Studio 2026, e foram produzidas capturas reais das telas principal, **Sobre** e resumo da estadia. O arquivo ZIP com as capturas é destinado ao envio separado no Fichário da ETEC, conforme o enunciado da atividade.

## Identificação acadêmica

- **Desenvolvedor:** Jefferson Astuti Magalhães de Barros
- **Curso:** Técnico em Desenvolvimento de Sistemas
- **Disciplina:** Desenvolvimento de Sistemas II
- **Atividade:** Agenda 13 - Fichário
- **Instituição:** ETEC / Centro Paula Souza
- **Ano:** 2026

## Referências didáticas

- **Centro Paula Souza / GEEaD.** *Agenda 13: Imagens e Componentes Diversos de Interface Gráfica*. Programação Mobile I. São Paulo, 2024. Autores: Tiago Antonio da Silva e Kelly Cristiane de Oliveira Dal Pozzo.
- [Projeto App Hotel indicado na apostila](https://github.com/tiagotas/MauiAppHotel/tree/f4651e5172dedfceec4630538ffe4bf340bce128).
- [Videoaula indicada no material](https://www.youtube.com/watch?v=DvFpB63U8TI).

---

**Repositório da atividade:** [jeffersonastuti/ETEC-DSII-Agenda13-AppHotel](https://github.com/jeffersonastuti/ETEC-DSII-Agenda13-AppHotel)
