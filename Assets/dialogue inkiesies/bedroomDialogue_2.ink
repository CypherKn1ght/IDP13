#bedroom dialogue
VAR viewtimes = 0
->bedroom
== bedroom ==
{ viewtimes < 1:
That glass case must be where the blueprints are.
~ viewtimes = viewtimes + 1
->bedroom
- else:
->END
}