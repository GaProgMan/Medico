Original design document
------------------------

The following is based on the notes that were made during the initial discussions on the application and how it should work. The only edits made are to applied MarkDown formatting

Widget (win phone and android) for reminding users to take their meds (can be swapped out for anything else, though).

* User enters name of meds, how often to take them (hours and/or minutes?) and how many (total) to take in a day.
* N number of alarms/reminders are set (based on the number of doses) T time apart (based on time between doses).
* User can change when each set of meds are taken, and this will cascade through all alarms/reminders for that medication.

Editting of med details are done through an app, widget contains a start/stop button.

* Stop button useful for if user needs to go through N number of hours/days without alarms/reminders firing.
* All alarms/reminders are halted whilst status==stop.
* 1 day of alarms/notifications are stored in XML/database. Entries contain what the meds are; when they user should have taken them;which ones the user took;etc. (Pro mode?)

App contains a list of all current meds monitored. User can edit the details for each entry:
* Time period for each dose
* Number of doses in a 24 hour period
* Name of meds
* Cancel/delete/remove medication (needs confirmation page)
* Etc.

Alarm/reminder contains two buttons and a label (name of medication)
1. Dose taken
1. Dose not taken (or something like that)

Dose taken button dismisses the alarm/notification and adds entry to database with time taken, etc. Cascade all other a alarms/notifications for the given meds (based on the time when the user hit the button).

Dose not taken dismisses the alarm/notification and add 'not taken' entry to then database for given medication. Don't touch other alarms/notifications for this medication.