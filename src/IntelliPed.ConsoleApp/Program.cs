using IntelliPed.Core.Agents;
using Microsoft.Extensions.Configuration;

IConfigurationBuilder configBuilder = new ConfigurationBuilder()
    .AddUserSecrets<Program>();

IConfigura