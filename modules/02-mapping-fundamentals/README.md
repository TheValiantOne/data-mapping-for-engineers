# Module 02 — Mapping Fundamentals

*Lesson status: outline — full lesson in progress.*

## Lesson outline
1. **The mapping spec is a contract** — source, target, transform, and *why*; reviewable by a human who isn't you. The spec formats that survive audits.
2. **Keys** — natural vs. surrogate, key collisions on consolidation (what actually happens when two systems both own "customer 1001"), stable-key strategies across runs.
3. **Transforms taxonomy** — direct copy, format, lookup/translate, split/merge, derive, default, and the honest category: "requires business decision."
4. **Lossy vs. lossless** — when a mapping destroys information, say so in the spec; round-trip tests as proof of losslessness.
5. **Rounding and allocation** — distributing totals across rows so the parts reconcile to the whole (the partial-penny problem); why naive rounding fails audits and how remainder-distribution algorithms fix it.

## Lab
Write the complete mapping spec from the Module 01 dataset to the provided target schema, including one allocation that must reconcile exactly.

**You're done when:** a second person could implement your spec without asking you anything, and your allocation column sums exactly to its control total.
