VAR hint_count = 0
* [Need a hint?]
Maybe that scanner has something to do with why I can't get in.
~ hint_count = hint_count + 1
** [Need another hint?]
There are so many dusty fingerprints left by the owner of this house.
~ hint_count = hint_count + 1
*** [Need a final hint?]
If the tape stuck to my fingerprints, I wonder what it could do to the dusty ones.
~ hint_count = hint_count + 1
**** [Ready for the answer?]
{hint_count == 3: Use the tape on the dusty fingerprints on the desk, then use the tape on the scanner near the trapdoor.}

/*
VAR hint_count = 0
* Need a hint?
-> hints
=== hints ===
+ {hint1 < 1} [Get a hint.]
->hint1
++ {hint1} {hint2 < 1} [Get another hint.]
->hint2

=== hint1 ===
Maybe that scanner has something to do with why I can't get in.
->hints

=== hint2 ===
There are so many dusty fingerprints left by the owner of this house.
->hints
*/