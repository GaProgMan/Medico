/**
  * Medication.h
  * @author Jamie "GaProgMan" Taylor
  * @version 0.1
  */

#ifndef MEDICATION_H
#define MEDICATION_H

// so that we can use the string datatype
#include <string>

class Medication
{
public:
	Medication();
	Medication(	std::string newFullMedicalName, std::string newShortName,
				std::string newPerscribedDosage, std::string newMaximumDosage,
				std::string newInitialDosageTime, std::string newDescription,
				std::string newGuid, int newTimePeriodBetweenDoses);
	~Medication();
	
	// Setters
	void FullMedicalName(std::string newFullMedicalName);
	void ShortName(std::string newShortName);
	void PerscribedDosage(std::string newPerscribedDosage);
	void MaximumDosagePerDay(std::string newMaximumDosagePerDay);
	void InitialDosageTime(std::string newInitialDosageTime);
	void Description(std::string newDescription);
	void Guid(std::string newGuid);
	void TimePeriodBetweenDoses(int newTimePeriodBetweenDoses);
	
	// Setters
	std::string FullMedicaName();
	std::string ShortName();
	std::string PerscribedDosage();
	std::string MaximumDosagePerDay();
	std::string InitialDosageTime();
	std::string Description();
	std::string Guid();
	int			TimePeriodBetweenDoses();
	
	// debug methods
	std::string ToString();

private:
	std::string fullMedicalName;
	std::string shortName;
	std::string perscribedDoseage;
	std::string maximumDosagePerDay;
	std::string initialDosageTime;
	std::string description;
	std::string guid;
	int			timePeriodBetweenDoses;
};

#endif // MEDICATION_H
