# ADR 0002: .NET 8 throughout; MCP over stdio

Status: accepted · 2026-08

## Context
Course labs need one coherent stack. The author's production experience is C#/.NET + SQL, and most enterprise migration code in the wild is JVM/.NET, not Python. MCP servers commonly ship stdio and/or HTTP transports.

## Decision
.NET 8 for all labs and the capstone. MCP over stdio first (simplest to run locally against Claude Code / MCP clients); HTTP transport is a stretch exercise.

## Consequences
- Lessons transfer to other stacks conceptually; exercises stay runnable with a single SDK install.
- stdio keeps the capstone free of hosting/auth concerns, which belong to a later, optional lesson.
