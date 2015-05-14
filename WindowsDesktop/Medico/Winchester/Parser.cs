using System;

namespace Winchester
{
    /// <summary>
    /// The Parser class.
    /// </summary>
    public class Parser
    {
        #region Medication Parser
        /// <summary>
        /// Deserialise the JSON file found at the specified file path to an instance of <see cref="Winchester.Medication"/> 
        /// </summary>
        /// <param name="filePath">The path of the JSON file.</param>
        /// <returns>The deserialised <see cref="Winchester.Medication"/> object, or a null'd object if anything goes wrong</returns>
        public Medication DeserialiseMedication(string filePath)
        {
            return MedicationParser.Deserialise(filePath);
        }

        /// <summary>
        /// Serialise the specified <see cref="Winchester.Medication"/> object to the specified directory location
        /// </summary>
        /// <param name="directoryLocation">Directory location</param>
        /// <param name="input">The <see cref="Winchester.Medication"/> object to serialise.</param>
        /// <returns>True if serialisation completed without any issues.</returns>
        public bool SerialiseMedication(string directoryLocation, Medication input)
        {
            return MedicationParser.Serialise(directoryLocation, input);
        }

        /// <summary>
        /// Used to serialise the specified <see cref="Winchester.Medication"/> object to a string 
        /// </summary>
        /// <param name="input">The <see cref="Winchester.Medication"/> object to serialise.</param>
        public string SerialiseMedication(Medication input)
        {
            return MedicationParser.Serialise(input);
        }
        #endregion

        #region User Details Parser

        /// <summary>
        /// Deserialise the JSON file found at the specified file path to an instance of <see cref="Winchester.UserDetails"/> 
        /// </summary>
        /// <param name="filePath">The path of the JSON file.</param>
        /// <returns>The deserialised <see cref="Winchester.UserDetails"/> object, or a null'd object if anything goes wrong</returns>
        public UserDetails DeserialiseUserDetails(string filePath)
        {
            return UserDetailsParser.Deserialise(filePath);
        }

        /// <summary>
        /// Serialise the specified <see cref="Winchester.UserDetails"/> object to the specified directory location
        /// </summary>
        /// <param name="directoryLocation">Directory location</param>
        /// <param name="input">The <see cref="Winchester.UserDetails"/> object to serialise.</param>
        /// <returns>True if serialisation completed without any issues.</returns>
        public bool SerialiseUserDetails(string directoryLocation, UserDetails input)
        {
            return UserDetailsParser.Serialise(directoryLocation, input);
        }

        /// <summary>
        /// Used to serialise the specified <see cref="Winchester.UserDetails"/> object to a string 
        /// </summary>
        /// <param name="input">The <see cref="Winchester.UserDetails"/> object to serialise.</param>
        public string SerialiseUserDetails(UserDetails input)
        {
            return UserDetailsParser.Serialise(input);
        }

        #endregion
    }
}

