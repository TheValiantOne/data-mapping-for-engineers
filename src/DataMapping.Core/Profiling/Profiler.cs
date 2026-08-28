namespace DataMapping.Core.Profiling;

/// <summary>
/// Statistical profiler for delimited flat files (Module 01 lab).
/// Skeleton: single-pass field statistics with type inference.
/// </summary>
public sealed class Profiler
{
    /// <summary>Profile every field in a delimited file. Lab 01 extends the TODOs.</summary>
    public IReadOnlyList<FieldProfile> ProfileFile(string path, char delimiter = ',')
    {
        // TODO(Lab 01): read header, stream rows, accumulate per-field stats in one pass
        // TODO(Lab 01): type inference — attempt parse per candidate type, track violation counts
        // TODO(Lab 01): distinct counting — exact for small cardinality, HyperLogLog beyond a threshold
        // TODO(Lab 01): encoding + delimiter-in-quotes traps (the generator plants both)
        throw new NotImplementedException("Lab 01: implement single-pass profiling.");
    }

    /// <summary>Score value-overlap between two fields as foreign-key candidate evidence (lesson §4).</summary>
    public double ValueOverlap(IEnumerable<string> left, IEnumerable<string> right)
    {
        // TODO(Lab 01, exercise): Jaccard on sampled distinct sets
        throw new NotImplementedException();
    }
}
