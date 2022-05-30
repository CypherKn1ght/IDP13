VAR hint_count = 0
* [Need a hint?]
Can you recite the alphabet backwards?
~ hint_count = hint_count + 1
** [Need a final hint?]
Match each letter with its opposite!
~ hint_count = hint_count + 1
**** [Ready for the answer?]
{hint_count == 2: Parts in lab.}
