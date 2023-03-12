
# GTA5-AIPeds-Enhancer 🤖

---

🛠️ **Very WIP**

This project is still under development and isn't ready for use yet. Expect substantial updates.

---

GTA5-AIPeds-Enhancer is an exciting open-source endeavor that aims to produce smart autonomous agents for pedestrians in GTA V using advanced language algorithms like GPT-4, built on .NET. Ideas for this project came from projects like [langchain](https://github.com/hwchase17/langchain), [AutoGPT](https://github.com/Significant-Gravitas/Auto-GPT), and the [ReAct framework](https://arxiv.org/abs/2210.03629). The intention is to create pedestrians in the game that can reason, act, and interact convincingly and in engaging ways.

The primary goal of the project is to improve the gaming experience in GTA V with AI-driven pedestrians that exhibit more intricate decision-making and behavioural patterns than the game's original NPCs. Integration with GTA V will be implemented through a FiveM server via gRPC.

Work has started to switch over to [Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/overview).

**High-level process:**

<img src="https://github.com/oneoneshot/GTA5-AIPeds-Enhancer/assets/21023513/d4c2b963-7e40-42ad-a06b-681136aa212c" width="300" alt="Overall process">

**Signal processing:**

<img src="https://github.com/oneoneshot/GTA5-AIPeds-Enhancer/assets/21023513/392e6fd8-c5dd-4fb2-ad36-12ba3ab3f90a" width="300" alt="Signal processing">

**Deep learning process:**

<img src="https://github.com/oneoneshot/GTA5-AIPeds-Enhancer/assets/21023513/72842d1b-495a-4d2f-84fb-eb41fc29c773" width="300" alt="Deep reasoning">

# Getting started

⚠️**Token usage isn't currently limited or measured**, proceed with caution!

1. Clone this repository to your local machine:

```bash
git clone https://github.com/oneoneshot/GTA5-AIPeds-Enhancer.git
```

2. Go to the `IntelliPed.ConsoleApp` project folder:

```bash
cd src/IntelliPed.ConsoleApp
```

3. Run the following command to set your OpenAI API keys to your dotnet user secrets:

```bash
dotnet user-secrets set "OpenAi:ApiKey" "{your api key}"
dotnet user-secrets set "OpenAi:OrgId" "{your org id}"
```

4. Build the solution using this command:

```bash
dotnet build
```

5. Run GTA5-AIPeds-Enhancer by executing this command:

```bash
dotnet run
```

# Contribute

We welcome contributions that can help improve GTA5-AIPeds-Enhancer. To contribute:

1. Fork the repository.
2. Start a new branch for your bugfix or feature.
3. Commit the changes to your branch.
4. Submit a pull request, explaining the changes you made and why you made them.

# License

GTA5-AIPeds-Enhancer is released under the [GNU GPLv3 License](LICENCE.md).