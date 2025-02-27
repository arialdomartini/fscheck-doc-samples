# FsCheck documentation samples
This F# project provides code examples from the official [FsCheck
official documentation](https://fscheck.github.io/FsCheck/), updated
to work with FsCheck v3.  
Given that the existing documentation targets v2, this project can
assist in pinpointing the breaking changes that need to be addressed
in the documentation.


## Possible enhancements

* The `Get via NuGet` menu targets directly the NuGet page. It would
  be nicer to have a doc page with some instructions.

### Properties
* `RevRevIsOriginal` needn't be public.
* Missing `:` before code snippets.
* Better use `;` instead of "," in "signature, we currently".
* About "It's very simple to fix any types anyway simply by adding
  some type annotations." maybe an example would help.
* `Prop` module should use verbatim font.
* Some code example contain`'Check.Quick insertKeepsOrder`, some
  don't.
* I think an initial setup allowing people to run the code samples
  would be useful.
