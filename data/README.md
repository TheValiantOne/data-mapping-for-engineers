# Synthetic Course Dataset

All data in this course is generated — no real-world data anywhere in this repository.

The generator (TODO: `Generate/` console project, Module 01 prerequisite) produces a small multi-file "customer + orders + payments" flat-file export with a fixed seed, and deliberately plants the traps the lessons hunt:

- a numeric-looking field with rare alphanumeric legacy values (~0.1% of rows)
- a "unique" column with planted duplicates
- a composite address field that is really four fields
- delimiter-inside-quotes and mixed-encoding rows
- an allocation column that only reconciles with correct remainder distribution (Module 02 §5)

Regenerating with the same seed must produce byte-identical output so lab answers stay stable.
