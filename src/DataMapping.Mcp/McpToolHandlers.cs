namespace DataMapping.Mcp;

/// <summary>
/// Tool implementations for the capstone server. Each tool is deliberately
/// narrow: parameterized, read-only, and shaped for model consumption
/// (small results, explicit units, stable field names). See Module 05 §2 and §4.
/// </summary>
public sealed class McpToolHandlers
{
    /// <summary>Describe available tables/fields so the agent can orient itself.</summary>
    public object SchemaDescribe()
        => throw new NotImplementedException("Lab 05: return table + field metadata from the migrated dataset.");

    /// <summary>Look up a single record by its stable key (Module 02: keys survive migration).</summary>
    public object RecordLookup(string entity, string key)
        => throw new NotImplementedException("Lab 05: parameterized single-record lookup; no wildcard scans.");

    /// <summary>Bounded aggregate (count/sum/avg) over an allowed field list — never raw SQL.</summary>
    public object AggregateQuery(string entity, string metric, string field, string? groupBy)
        => throw new NotImplementedException("Lab 05: whitelist fields; reject out-of-scope requests cleanly.");
}
