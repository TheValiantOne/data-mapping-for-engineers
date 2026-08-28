namespace DataMapping.Core.Profiling;

/// <summary>
/// The per-field result of statistical profiling (Module 01).
/// A dossier is a collection of these plus cross-field findings.
/// </summary>
public sealed record FieldProfile
{
    public required string FileName { get; init; }
    public required string FieldName { get; init; }
    public InferredType InferredType { get; init; } = InferredType.Unknown;
    public long RowCount { get; init; }
    public long NullCount { get; init; }
    public long DistinctCount { get; init; }
    public string? Min { get; init; }
    public string? Max { get; init; }
    public int MaxLength { get; init; }
    /// <summary>Rows that violate the inferred type — the interesting ones (see Module 01, planted traps).</summary>
    public long TypeViolationCount { get; init; }
    public bool IsCandidateKey => DistinctCount == RowCount - NullCount && NullCount == 0 && RowCount > 0;
}

public enum InferredType { Unknown, Integer, Decimal, Date, DateTime, Boolean, Enumeration, Text }
