using System;
using System.IO;
using System.Reflection;

namespace BeaJay
{
    public partial class About : Gtk.Dialog
    {
        public About()
        {
            this.Build();
            this.aboutTextView.Buffer.Text = LoadAboutText();
        }

        /// <summary>
        /// Used to load the about widget copy.
        /// </summary>
        /// <returns>The about copy.</returns>
        private string LoadAboutText()
        {
            var copyText = string.Empty;
            try
            {
                // Attempt to load the about copy text
                var assembly = Assembly.GetExecutingAssembly();
                const string aboutFile = "BeaJay.AboutCopy.txt";
                using (var stream = assembly.GetManifestResourceStream(aboutFile))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        copyText = reader.ReadToEnd();
                    }
                }
            }
            catch (FileLoadException)
            {
                // Used to catch all FileLoadExceptions
                // Ensure that the copy text is zero'd if it could
                //  not be loaded.
                copyText = string.Empty;
            }
            return copyText;
        }

        /// <summary>
        /// Raises the button click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        protected void OnButtonClick(object sender, EventArgs e)
        {
            // Close this window
            this.OnClose();
        }
    }
}

