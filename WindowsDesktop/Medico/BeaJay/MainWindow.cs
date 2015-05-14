using System;
using Gtk;
using Winchester;

namespace BeaJay {

    public partial class MainWindow: Gtk.Window
    {
        public MainWindow() : base(Gtk.WindowType.Toplevel)
        {
            Build();

            // Test that the medication json serialiser works
            var testJson = testSomeStuff().Replace(",\"", ",\"" + Environment.NewLine);
            this.debugSerialise.Buffer.Text = testJson;
        }

        public string testSomeStuff()
        {
            var testMedication = new Medication
            {
                    FullMedicalName = "Ibuprofen",
                    ShortName = "Pain meds",
                    PerscribedDosage = "Two pills, every 4 hours",
                    MaximumDosagePerDay = "8 pills in 24 hours",
                    Description = "small, pink, round pills in blister packet",
                    TimePeriodBetweenDoses = 240,
                    InitialDosageTime = DateTime.Now,
                    GUID = new Guid(),
                    IsNull = false
            };
            return MedicationParser.Serialise(testMedication);
        }

        /// <summary>
        /// Quit this instance.
        /// </summary>
        private void Quit()
        {
            Application.Quit();
        }

        /// <summary>
        /// Raises the delete event event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="a">The alpha component.</param>
        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        #region Menu strip Event Handlers
        protected void OnOpen(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Raises the about event - called from the menu strip.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        protected void OnAbout(object sender, EventArgs e)
        {
            var aboutWindow = new About();
            aboutWindow.Show();
        }

        /// <summary>
        /// Raises the exit event - called from the menu strip.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        protected void OnExit(object sender, EventArgs e)
        {
            this.Quit();
        }
        #endregion
    }
}