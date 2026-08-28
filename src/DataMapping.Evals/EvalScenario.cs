namespace DataMapping.Evals;

/// <summary>One scored scenario: a tool-call sequence with an expected outcome (Module 05 §5).</summary>
public sealed record EvalScenario
{
    public required string Name { get; init; }
    public required EvalKind Kind { get; init; }
    /// <summary>Tool calls to drive against the server (name + JSON args).</summary>
    public required IReadOnlyList<(string Tool, string ArgsJson)> Calls { get; init; }
    /// <summary>Expected substring/shape in the final result, or expected clean refusal.</summary>
    public required string Expectation { get; init; }
    public TimeSpan LatencyBudget { get; init; } = TimeSpan.FromSeconds(2);
}

public enum EvalKind
{
    /// <summary>Answerable query — must return the correct value.</summary>
    Correctness,
    /// <summary>Out-of-scope request — must refuse cleanly, not error or leak.</summary>
    Refusal,
    /// <summary>Within latency budget at p95 across repetitions.</summary>
    Latency
}
