VAR hint_count = 0
* [Need a hint?]
Looks like that corkboard has some clues, I should look for something that might help!.
~ hint_count = hint_count + 1
** [Need another hint?]
Look at the corners opposite of the letter pair in the code!
~ hint_count = hint_count + 1
*** [Need a final hint?]
Make a rectangle around the letters and look at the shape’s opposite corners in order.
~ hint_count = hint_count + 1
**** [Ready for the answer?]
{hint_count == 3: THIRTEEN.}