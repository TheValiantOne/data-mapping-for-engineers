# Data Mapping for Engineers

*A hands-on course in data mapping and migration — taught in SQL and C#, ending with an MCP server that makes your mapped data accessible to AI agents.*

Every enterprise migration starts the same way: someone hands you a pile of unfamiliar data and expects it to arrive, intact and reconciled, in a system that models the world differently. Most engineers learn this craft by making expensive mistakes on live customer data. This course teaches the patterns directly — the same ones used in production migrations across utilities, retail, real estate, and financial systems — using synthetic data you can break safely.

## What you'll build

By the end of the course you will have built a working pipeline that:

1. **Profiles** an unfamiliar flat-file dataset statistically (types, ranges, cardinality, candidate keys)
2. **Maps** it to a target schema using explicit, reviewable transform rules
3. **Automates** the mapping — generating the obvious 90%+ and flagging exceptions for human judgment
4. **Migrates** at scale with batching, parallelism, and reconciliation totals that prove nothing was lost
5. **Exposes** the result to AI agents through an MCP (Model Context Protocol) server — with an evaluation harness that scores whether agents can actually use it

That last step matters: mapped data used to be consumed by reports and applications. Increasingly, it is consumed by agents. Designing tool surfaces over clean data — and proving they work with evals — is the modern last mile of every migration.

## Course structure

| Module | Topic | Lab |
|---|---|---|
| [01](modules/01-reading-unfamiliar-data/) | Reading unfamiliar data — statistical profiling before you write a single mapping | Profile a messy flat file and produce a data dossier |
| [02](modules/02-mapping-fundamentals/) | Mapping fundamentals — keys, transforms, lossy vs. lossless, the mapping spec | Write and review a complete source→target mapping |
| [03](modules/03-automating-the-mapping/) | Automating the mapping — generate the obvious, flag the exceptional | Build a mapping generator with an exception queue |
| [04](modules/04-migration-mechanics-at-scale/) | Migration mechanics — batching, parallelism, reconciliation | Parallelize a slow migration; make totals reconcile to the penny |
| [05](modules/05-capstone-agent-accessible-data/) | **Capstone**: agent-accessible data — an MCP server over your migrated data, with evals | Ship the MCP server; score it with the eval harness |

Each module is a written lesson (`README.md`) plus a runnable lab with exercises. Labs build on each other; the dataset introduced in Module 01 flows through the entire course.

## Prerequisites

- Comfortable SQL (joins, aggregates, window functions help)
- Basic C# / .NET (labs target .NET 8; the ideas transfer to any stack)
- No AI/ML background required — Module 05 teaches what you need

## Repository layout

```
modules/    lessons + labs (start here: modules/01)
src/        shared code — Core (profiling/mapping), Mcp (capstone server), Evals (scoring harness)
data/       synthetic datasets + generator (no real-world data anywhere in this repo)
docs/       architecture decision records
```

## Status

Under active development. Module order is stable; lessons are landing incrementally — Module 01 and the capstone skeleton first.

## License

MIT — see [LICENSE](LICENSE). All datasets are synthetic. Patterns are generalized from a decade of production migration work; no client or employer data or specifics appear anywhere in this repository.
