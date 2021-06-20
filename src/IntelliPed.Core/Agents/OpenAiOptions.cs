using System.ComponentModel.DataAnnotations;

namespace IntelliPed.Core.Agents;

public record OpenAiOptions
{
    [Required]
    public string ApiKey