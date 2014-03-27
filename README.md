Medico
======

Short Description
-----------------

A small piece of Annoy-Ware that is designed to annoy the user until they have taken their medication.

Project Goal
------------

Fulfil the final wish of a close friend of mine who passed away, at the age of 32, shortly before Christmas 2013. He'd lamented on the fact that there weren't any apps that could help him to take all of his prescribes medications on time.

We'd discussed the idea in great detail during (what would become) his final summer. He medication regimen was quite strict during the final year of his life, and he would follow this procedure everyday:

* Take his first medication shortly after waking
* Create a series of alarms on his mobile devices, one for each the doses of his medication
* Nap until it was time to take his medication (the alarm would wake him)

All of his medication was time based, so he would have to set each of the alarms at the beginning of the day - MANUALLY. What he wanted was an app that would set all of the alarms for him when he took his first dose in the morning. Should his miss or delay a dose, the later alarms would be put on hold until he took his allotted dose, then all alarms based after that one would cascade AUTOMATICALLY.

I will consider this repository 100% successful if only one person is helped by it. Also, should this code base help convince developers to create a similar application, then this will be taken as 100% success for this repository.

Technology
----------

Initially, the application will be written using C# for the Windows platform. This will be the proof of concept phase. Once passed the proof of concept stage, then the application will be ported to Android (using Java). If the application proves useful, then the application will be ported Windows Mobile and iOS.

Use of this Repository
----------------------

Initially the contents of this repository will be released with a LGPL V2 license (please see the license.md file in the root of the main branch for more details). Once the project is passed the planning and proof of concept stage the application will be ported to other platforms, once this happens the code base may be released with a different license. It is hard to say at this juncture as to what will happen.

Each of the different versions of the main application will, likely, have different licenses applied. The applicable license can be found in the license.md file found in the directory containing the code base for that platform (i.e WindowsDesktop for the Windows Desktop version of the application).

Medication Class
----------------

The backbone of this application is the Medication class. The XML representation of this class can be found in the file ''MedicationClass.xml``, the original notes that lead to it's creation can be found in the ''OriginalNotes.md`` file (both are in the root of the repository).

The application will create one or more instance of these objects with the user supplying the medical name, short name (a name that is easier for the user to recognise as some medications have long names), suggested dosage, time between doses (in minutes), maximum doses in a 24 hour period, the time of the initial dosage (optional), and a short description of the medication. This information will be used by the application to create a series of alarms for each dose of the medication.

Example
-------

John is prescribed:

* Ibruprofen (2 pills per dosage, 4 hours apart, no more than 4 dosages in a day, red capsules with a single blue stripe)
* MadeUpIButamol (1 patch per dosage, 4 hours apart, no more than 6 dosages in a day, buff coloured patches)

John enters these details into the Medico application, which creates two instances of the class as follows:

medicationClassOne.NameOfMedication			= "Ibruprofen";
medicationClassOne.ShortName				= "Pain meds";
medicationClassOne.TimePeriodBetweenDoses	= "240";
medicationClassOne.PrescribedDosage			= "2";
medicationClassOne.MaxNumberOfDosesPerDay	= "4";
medicationClassOne.InitialDoseTime			= "09:00";
medicationClassOne.Description				= "red capsules with a single blue stripe";

medicationClassTwo.NameOfMedication			= "MadeUpIButamol";
medicationClassTwo.ShortName				= "Patches";
medicationClassTwo.TimePeriodBetweenDoses	= "240";
medicationClassTwo.PrescribedDosage			= "1";
medicationClassTwo.MaxNumberOfDosesPerDay	= "6";
medicationClassTwo.InitialDoseTime			= "09:00";
medicationClassTwo.Description				= "buff coloured patches";

The application sets the following alarms on John's device:

1. 09:00 "Pain Meds - Ibruprofen (red capsules with a single blue stripe) * 2"
1. 09:00 "Patches - MadeUpIButamol (buff coloured patches) * 1"
1. 11:00 "Pain Meds - Ibruprofen (red capsules with a single blue stripe) * 2"
1. 11:00 "Patches - MadeUpIButamol (buff coloured patches) * 1"
1. 13:00 "Pain Meds - Ibruprofen (red capsules with a single blue stripe) * 2"
1. 13:00 "Patches - MadeUpIButamol (buff coloured patches) * 1"
1. 15:00 "Last dosage: Pain Meds - Ibruprofen (red capsules with a single blue stripe) * 2"
1. 15:00 "Patches - MadeUpIButamol (buff coloured patches) * 1"
1. 17:00 "Patches - MadeUpIButamol (buff coloured patches) * 1"
1. 19:00 "Last dosagePatches - MadeUpIButamol (buff coloured patches) * 1"

At each of the time periods outlined, the application receives a message from the operating system that an alarm has fired. This causes the application to display a message and play and audible alert. The contents of the alert will be the name (string literal) of the alarm, which contains the details of the medication to take, a "Taken dosage" button and a "snooze dosage" button.

Pressing the "Snooze dosage" button will, effectively, snooze the dosage for 1 minute. Pressing the "Taken dosage" button will cause the alert and the specific alarm to be removed, and all later alarms for that medication to be staggered based on the time that the button was pressed. That way all medication doses will be taken as close to time between doses as is possible.