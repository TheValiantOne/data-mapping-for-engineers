# Module 04 — Migration Mechanics at Scale

*Lesson status: outline — full lesson in progress.*

## Lesson outline
1. **The downtime budget** — migrations are judged by the window they need, not the rows they move. Designing backwards from an acceptable outage.
2. **From row-by-row to batches** — why single-threaded row processing dies at scale; hash-partitioned batching; choosing batch sizes empirically.
3. **Parallelism without corruption** — partitioning strategies that keep parallel workers off each other's data; ordering constraints; idempotent batches and safe retry.
4. **Reconciliation** — control totals per batch and per run: row counts, sums, hashes. "It probably worked" vs. "here is the arithmetic that proves it worked."
5. **The rehearsal discipline** — timed dry runs, cutover checklists, and the go/no-go call.

## Lab
The lab ships a deliberately slow single-threaded migration. Make it fast: partition into hashed batches, run them in parallel, and produce a reconciliation report proving zero loss.

**You're done when:** wall-clock time drops by an order of magnitude on the lab dataset and your reconciliation report balances to zero across all control totals.

## Exercise
One batch fails halfway on purpose (the lab arranges it). Recover without re-running the whole migration and without double-loading a single row.
