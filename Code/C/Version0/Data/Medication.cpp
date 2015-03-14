/**
  * Medication.cpp
  * @author Jamie "GaProgMan" Taylor
  * @version 0.1
  */

#include "Medication.h"
// so that we can use the string datatype
#include <string>

/**
 * @brief Instanciates a new instance of the Medication class
 * @param newFullMedicalName the value for the FullMedicalName property
 * @param newShortName the value for the ShortName property
 * @param newPerscribedDosage the value for the PrescribedDosage property
 * @param newMaximumDosage the value for the MaximumDosagePerday property
 * @param newInitialDosageTime the value for the IntialDosageTime property
 * @param newDescription the value for the Description property
 * @param newGuid the value for the Guid propery
 * @param newTimePeriodBetweenDoses the value for the tieBetweenDosaes property
 */
Medication::Medication(	std::string newFullMedicalName, std::string newShortName,
			std::string newPerscribedDosage, std::string newMaximumDosage,
			std::string newInitialDosageTime, std::string newDescription,
			std::string newGuid, int newTimePeriodBetweenDoses) {
				fullMedicalName = newFullMedicalName;
				shortName = newShortName;
				maximumDosagePerDay = newMaximumDosage;
				initialDosageTime = newInitialDosageTime;
				description = newDescription;
				guid = newGuid;
				timePeriodBetweenDoses = newTimePeriodBetweenDoses;
			}

Medication::~Medication() {
	// todo: this, sucker
}

/**
 * @brief Get method for fullMedicalName property
 * @return the value of the fullMedicalName property
 */
std::string Medication::FullMedicaName() {
	return fullMedicalName;
}

/**
 * @brief Get method for the shortName property
 * @return the value of the shortName property
 */
std::string Medication::ShortName() {
	return shortName;
}

/**
 * @brief Get method for the perscribedDosage property
 * @return the value of the perscribedDosage property
 */
std::string Medication::PerscribedDosage() {
	return perscribedDoseage;
}

/**
 * @brief Get method for maximumDosagePerDay property
 * @return the value fo the maximumDosagePerDay property
 */
std::string Medication::MaximumDosagePerDay() {
	return maximumDosagePerDay;
}

/**
 * @brief Get method for initialDosageTime property
 * @return the value fo the initialDosageTime property
 */
std::string Medication::InitialDosageTime() {
	return initialDosageTime;
}

/**
 * @brief Get method for the description property
 * @return the value of the description property
 */
std::string Medication::Description() {
	return description;
}

/**
 * @brief Get method for guid property
 * @return the value of the guid property
 */
std::string Medication::Guid() {
	return guid;
}

/**
 * @brief Get method for timePeriodBetweenDoses property
 * @return the value of the timePeriodBetweenDoses property
 */
int Medication::TimePeriodBetweenDoses() {
	return timePeriodBetweenDoses;
}

/**
 * @brief Set method for fullMedicalName
 * @param newFullMedicalName the new value for the fullMedicalName property
 */
void Medication::FullMedicalName(std::string newFullMedicalName) {
	fullMedicalName = newFullMedicalName;
}

/**
 * @brief Set method for shortMedicalName
 * @param newShortName the new value for the shortName property
 */
void Medication::ShortName(std::string newShortName) {
	shortName = newShortName;
}

/**
 * @brief Set method for perscribedDosage
 * @param newPerscribedDosage the new value for the perscrbedDosage property
 */
void Medication::PerscribedDosage(std::string newPerscribedDosage) {
	perscribedDoseage = newPerscribedDosage;
}

/**
 * @brief Set method for maximumDosagePerDay
 * @param newMaximumDosagePerDay the new value for the maximumDosagePerDay property
 */
void Medication::MaximumDosagePerDay(std::string newMaximumDosagePerDay) {
	maximumDosagePerDay = newMaximumDosagePerDay;
}

/**
 * @brief Set method for initialDosageTime
 * @param newInitialDosageTime the new value for the initialDosageTime property
 */
void Medication::InitialDosageTime(std::string newInitialDosageTime) {
	initialDosageTime = newInitialDosageTime;
}

/**
 * @brief Set method for description
 * @param newDescription the new value for the description property
 */
void Medication::Description(std::string newDescription) {
	description = newDescription;
}

/**
 * @brief Set method for guid property
 * @param newGuid the new vallue for the guid property
 */
void Medication::Guid(std::string newGuid) {
	guid = newGuid;
}

/**
 * @brief Set method for timePeriodBetweenDoses property
 * @param newTimePeriodBetweenDoses the new value for the timePeriodBetweenDoses property
 */
void Medication::TimePeriodBetweenDoses(int newTimePeriodBetweenDoses) {
	timePeriodBetweenDoses = newTimePeriodBetweenDoses;
}