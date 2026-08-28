# Module 01 — Reading Unfamiliar Data

*Lesson status: outline — full lesson in progress.*

You've been handed `customers_export_final_v2.csv`. Nobody who made it still works there. Before you write a single mapping rule, you profile.

## Lesson outline
1. **Why profiling comes first** — every mapping error traces back to an assumption about data you didn't verify. War-story framing: the migration that failed because a "numeric ID" column contained one alphanumeric legacy value.
2. **The data dossier** — what to produce before mapping begins: per-field type inference, null rates, min/max/length ranges, cardinality, candidate keys, cross-field dependencies, delimiter/encoding traps.
3. **Statistical field analysis** — inferring what a column *is* from what it *contains*: type detection heuristics, distinguishing enums from free text, spotting composite fields (the "address line that's really four fields" problem).
4. **Reading between the files** — inferring relationships across files without documentation: value-overlap analysis for foreign-key candidates.
5. **What you still can't know** — the questions profiling cannot answer and humans must (semantic meaning, business rules, which duplicates are real). Producing the *question list* is a deliverable, not a failure.

## Lab
Profile the synthetic dataset in `data/` and produce a data dossier.

**You're done when:** your dossier identifies every field's inferred type, flags all planted traps (there are several — the generator seeds them deliberately), proposes candidate keys for each file, and lists at least five questions only a human could answer.

## Exercises
- The generator planted a field whose type is wrong in exactly 0.1% of rows. Find it with SQL alone.
- One "unique" column isn't. Prove it and propose what to do.
