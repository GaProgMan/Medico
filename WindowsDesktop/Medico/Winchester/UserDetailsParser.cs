using System;
using System.IO;
using Newtonsoft.Json;

namespace Winchester
{
    /// <summary>
    /// The User Details Parser class.
    /// </summary>
    public static class UserDetailsParser
    {
        /// <summary>
        /// Used to serialise the specified <see cref="Winchester.UserDetails"/> object to a string 
        /// </summary>
        /// <param name="input">The <see cref="Winchester.UserDetails"/> object to serialise.</param>
        public static string Serialise(UserDetails input)
        {
            return JsonConvert.SerializeObject(input);
        }

        /// <summary>
        /// Serialise the specified <see cref="Winchester.UserDetails"/> object to the specified directory location
        /// </summary>
        /// <param name="directoryLocation">Directory location</param>
        /// <param name="input">The <see cref="Winchester.UserDetails"/> object to serialise.</param>
        /// <returns>True if serialisation completed without any issues.</returns>
        public static bool Serialise(string directoryLocation, UserDetails input)
        {
            try
            {
                JsonSerializer serialiser = new JsonSerializer();
                serialiser.NullValueHandling = NullValueHandling.Ignore;
                if (Uri.IsWellFormedUriString(directoryLocation, UriKind.Absolute))
                {
                    var fullFileName = Path.Combine(directoryLocation, input.UserId);
                    fullFileName = string.Concat(fullFileName, ".json");
                    using (StreamWriter sw = new StreamWriter(fullFileName))
                    {
                        using (JsonWriter writer = new JsonTextWriter(sw))
                        {
                            serialiser.Serialize(writer, input);
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            // everything went fine, return true.
            return true;
        }

        /// <summary>
        /// Deserialise the JSON file found at the specified file path to an instance of <see cref="Winchester.UserDetails"/> 
        /// </summary>
        /// <param name="filePath">The path of the JSON file.</param>
        /// <returns>The deserialised <see cref="Winchester.UserDetails"/> object, or a null'd object if anything goes wrong</returns>
        public static UserDetails Deserialise(string filePath)
        {
            // Null'd Medication object
            var returnValue = new UserDetails();

            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                var fileContents = string.Empty;
                try
                {
                    using (var reader = new StreamReader(filePath))
                    {
                        fileContents = reader.ReadToEnd();
                    }
                }
                catch (Exception)
                {
                    // return a null'd version of the object
                    return returnValue;
                }

                if (!string.IsNullOrEmpty(fileContents))
                {
                    returnValue = JsonConvert.DeserializeObject<UserDetails>(fileContents);
                }
            }
            return returnValue;
        }
    }
}

