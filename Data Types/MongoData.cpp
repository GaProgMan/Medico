public class User {
	private Medication[] meds;
	private string       userName;
	private string 		 userId;

	public User() {
		this.meds = new Medication[];
		this.userName = "";
		this.userId = "";
	}	
}

public class Medication {

	private string	fullName;
	private string	shortName;
	private int		timePeriodPerDose;
	private string	perscribedDose;
	private string	maximumDosePerDay;
	private string	initialDoseTime;
	private string	description;
	private GUID	id;

	public Medication() {
		this.fullName = "";
		this.shortName = "";
		this.timePeriodperDose = 0;
		this.perscribedDose = "";
		this.maximumDosePerDay = "";
		this.initialDoseTime = "";
		this.description = "";
		this.id = new GUID();
	}

	public void FullName (string inFullName) {
		this.fullName = inFullName;
	}

	public void ShortName (string inShortName) {
		this.shortName = inShortName;
	}

	public void TimePeriodPerDose (int inTimePeriod) {
		this.timePeriodPerDose = inTimePeriod;
	}

	public void PerscribedDose (string inPerscribedDose) {
		this.perscribedDose = inPerscribedDose;
	}

	public void MaximumDosePerDay (string inMaxDosePerDay) {
		this.maximumDosePerDay = inMaxDosePerDay;
	}

	public void InitialDosetime (string inInitialDoseTime) {
		this.initialDoseTime = inInitialDoseTime;
	}

	public string GetFullName() {
		return this.fullName;
	}

	public string GetShortName() {
		return this.shortName;
	}

	public int GetTimePeriodPerDose() {
		return this.timePeriodPerDose;
	}

	public string GetPerscribedDose() {
		return this.perscribedDose;
	}

	public string GetMaximumDosePerDay() {
		return this.maximumDosePerDay;
	}

	public string GetDescription() {
		return this.description;
	}

	public string GetGuid() {
		return this.id.ToString();
	}
}