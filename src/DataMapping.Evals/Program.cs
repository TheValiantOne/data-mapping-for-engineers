// DataMapping.Evals — scored eval harness for the capstone MCP server (Module 05 §5).
//
// Drives tool-call sequences against DataMapping.Mcp (spawned over stdio),
// grades correctness / refusal behavior / latency, and prints a scorecard.
// "If you didn't measure it, you shipped a demo, not a capability."

// TODO(Lab 05): spawn the Mcp server process, speak MCP over stdio
// TODO(Lab 05): load scenarios (start with the seed set below), run with N repetitions
// TODO(Lab 05): scorecard output — per-scenario pass/fail, p50/p95 latency, exit code != 0 on red

Console.Error.WriteLine("DataMapping.Evals skeleton — implement Module 05 lab.");
Console.Error.WriteLine("Seed scenarios to implement first:");
Console.Error.WriteLine("  1. Correctness: schema_describe lists all migrated entities");
Console.Error.WriteLine("  2. Correctness: record_lookup returns the known seeded record");
Console.Error.WriteLine("  3. Correctness: aggregate reconciles with Module 04 control totals");
Console.Error.WriteLine("  4. Refusal:     raw SQL / out-of-scope field is refused cleanly");
Console.Error.WriteLine("  5. Latency:     p95 lookup under budget across 20 runs");
