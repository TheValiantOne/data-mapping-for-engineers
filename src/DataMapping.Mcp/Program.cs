// DataMapping.Mcp — capstone MCP server (Module 05)
// Exposes the migrated course dataset to AI agents over stdio.
//
// Design intent (see modules/05 lesson + ADR 0002):
//   - stdio transport, read-only tool surface
//   - 3–5 tools: schema_describe, record_lookup, aggregate_query (+ stretch tools)
//   - guardrails: no raw SQL passthrough; scoped, parameterized tools only

// TODO(Module 05): wire MCP server bootstrap (official C# SDK), register handlers from McpToolHandlers
Console.Error.WriteLine("DataMapping.Mcp skeleton — implement Module 05 lab.");
