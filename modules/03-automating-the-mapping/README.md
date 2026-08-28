# Module 03 — Automating the Mapping

*Lesson status: outline — full lesson in progress.*

## Lesson outline
1. **The artisanal trap** — hand-writing the same mapping SQL per source is craft the first time and waste the fifth. When to productize (rule of three).
2. **Generating the obvious** — name similarity, type compatibility, value-overlap scoring; generating candidate mappings with confidence scores.
3. **The exception queue is the product** — auto-map the confident 90%+, route the rest to humans with context attached. Designing for the reviewer, not the algorithm.
4. **Trust calibration** — thresholds, false-accept vs. false-review costs, and why 99% auto-mapped with honest exceptions beats 100% auto-mapped with silent errors.
5. **Feedback loops** — every human exception decision becomes training signal for the next run's candidates.

## Lab
Build a mapping generator over the Module 01 dossier output: score candidate field mappings, auto-accept above threshold, emit an exception queue for the rest.

**You're done when:** the generator auto-maps the majority of fields correctly, every planted trap lands in the exception queue (none silently auto-mapped), and the queue entry gives a reviewer enough context to decide in under a minute.
