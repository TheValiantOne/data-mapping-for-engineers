# ADR 0001: A course repository with an MCP capstone, not a library

Status: accepted · 2026-08

## Context
This repository could have been (a) a reusable data-mapping library, (b) a standalone MCP reference server, or (c) a course. The audience is engineers learning the craft of mapping/migration, and increasingly, how mapped data is consumed by AI agents.

## Decision
Build a course whose modules are lessons with runnable labs, sharing code in `src/`, culminating in an MCP server + eval harness capstone. Teaching artifact first; code in service of lessons.

## Consequences
- Lesson quality is the bar; code stays small and readable rather than general.
- The capstone demonstrates the MCP-over-existing-data pattern end to end, including evaluation.
- A future extraction of `DataMapping.Core` into a standalone library remains possible but is a non-goal.
