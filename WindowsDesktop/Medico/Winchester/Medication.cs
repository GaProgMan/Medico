using System;

namespace Winchester
{
    /// <summary>
    /// The Medication class
    /// </summary>
    public class Medication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Winchester.Medication"/> class.
        /// </summary>
        public Medication()
        {
            FullMedicalName = string.Empty;
            ShortName = string.Empty;
            PerscribedDosage = string.Empty;
            MaximumDosagePerDay = string.Empty;
            Description = string.Empty;
            TimePeriodBetweenDoses = -1;
            InitialDosageTime = DateTime.Now;
            GUID = new Guid();
            IsNull = true;
        }


        /// <summary>
        /// Gets or sets a value indicating the full medical name of the medication
        /// </summary>
        /// <value>The full name of the medication.</value>
        public string FullMedicalName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating the short (non-medical) name of the medication
        /// </summary>
        /// <value>The short name of the medication</value>
        public string ShortName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating the perscribed dosage of the medication
        /// </summary>
        /// <value>The perscribed dosage</value>
        public string PerscribedDosage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating the maximum dosage per day of the medication
        /// </summary>
        /// <value>The maximum dosage per day</value>
        public string MaximumDosagePerDay
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating the time period (in minutes) between doses of the medication
        /// </summary>
        /// <value>The time period between doses</value>
        public int TimePeriodBetweenDoses
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating the initial dosage time of the medication
        /// </summary>
        /// <value>The initial dosage time</value>
        public DateTime InitialDosageTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets  value indicating the description of the medication
        /// </summary>
        /// <value>The description</value>
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating the GUId of the medication
        /// </summary>
        /// <value>The GUID</value>
        public Guid GUID
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is null.
        /// </summary>
        /// <value><c>true</c> if this instance is null; otherwise, <c>false</c>.</value>
        public bool IsNull
        {
            get;
            set;
        }
    }
}

