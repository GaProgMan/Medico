using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Rizzo
{
    /// <summary>
    /// The Searcher class
    /// </summary>
    public static class Searcher
    {
        /// <summary>
        /// Searchs for all relevant JSON files.
        /// </summary>
        /// <returns>A list of relevant JSON files that were found in the working directory.</returns>
        /// <param name="workingDirectory">The directory to search through.</param>
        public static List<string> SearchForFiles(string workingDirectory)
        {
            if (!string.IsNullOrEmpty(workingDirectory) && Uri.IsWellFormedUriString(workingDirectory, UriKind.Absolute))
            {
                return SearchForUserDetails(workingDirectory);
            }
            return new List<string>();
        }

        /// <summary>
        /// Searches for all UserDetail JSON files. If non are found, then calls SearchForMeds.
        /// </summary>
        /// <returns>all files found.</returns>
        /// <param name="workingDirectory">The working directory.</param>
        private static List<string> SearchForUserDetails(string workingDirectory)
        {
            // Assumes that workingDirectory is checked in the calling method.
            var filesInDirectory = Directory.GetFiles(workingDirectory, "*.json").Where(x => x.Contains("UserDetails")).ToList();
            return filesInDirectory.Any() ? filesInDirectory : SearchForMedFiles(workingDirectory);
        }

        private static List<string> SearchForMedFiles(string workingDirectory)
        {
            var filesInDirectory = Directory.GetFiles(workingDirectory, "*.json").Where(x => !x.Contains("UserDetails")).ToList();
            return filesInDirectory.Any() ? filesInDirectory : new List<string>();
        }
    }
}