# Module 05 — Capstone: Agent-Accessible Data

*Lesson status: outline — skeleton code in `src/DataMapping.Mcp` and `src/DataMapping.Evals`.*

Your data survived profiling, mapping, and migration. Now something new wants to consume it: an AI agent. This module builds an MCP (Model Context Protocol) server over the migrated dataset — and, more importantly, *proves* an agent can use it.

## Lesson outline
1. **Why MCP, and why over existing data** — the pattern: don't rebuild systems for agents; expose the system you have through tools. Tool surfaces as the new integration contract.
2. **Designing tool surfaces** — 3–5 tools, not 30: search/lookup, aggregate, schema-describe. Naming, parameter design, and result shaping so a model can actually use them; what to withhold (raw SQL passthrough is not a tool).
3. **The stdio server in C#** — wiring the MCP protocol over stdin/stdout in .NET 8; connecting it to an MCP client (Claude Code) locally.
4. **Guardrails for regulated-shaped data** — read-only surfaces, scoping what an agent may touch, why "the agent can see everything the connection can" is the mistake everyone makes once.
5. **Evals: the proof** — a scored harness that drives tool-call sequences against the server and grades correctness, refusal behavior, and latency. If you didn't measure it, you shipped a demo, not a capability.

## Lab
Implement the three TODO tools in `src/DataMapping.Mcp`, connect from an MCP client, then run `DataMapping.Evals` and get the scorecard green.

**You're done when:** all eval scenarios pass — correct answers on answerable queries, clean refusals on out-of-scope requests, and p95 latency under the stated budget.
