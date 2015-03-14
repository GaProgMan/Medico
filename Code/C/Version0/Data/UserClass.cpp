/**
  * UserClass.cpp
  * @author Jamie "GaProgMan" Taylor
  * @version 0.1
  */

#include "UserClass.h"
#include "Medication.h"

// so that we can use the string datatype
#include <string>
// instances of the Medication class will be stored in a vector
#include <vector>
// For malloc
#include <stdlib.h>

/**
 * @brief Instanciates a new instance of the UserClass object
 * @param newUserId the value for the UserId property
 * @param newUserName the value for the UserName property
 * @param newMeds the values for the Medication vector property
 * @return A new instance of the UserClass object
 */
UserClass::UserClass(std::string newUserId, std::string newUserName, std::vector<Medication> newMeds) {
	userId = newUserId;
	userName = newUserName;
	medications.clear();
	medications.insert(medications.end(), newMeds.begin(), newMeds.end());
}

UserClass::~UserClass() {
	//To do: implement, sucker!
}

/**
 * @brief Accessor method for the userId propery
 * @return The value of the userId property
 */
std::string UserClass::UserId() {
	return userId;
}

/**
 * @brief Accessor method for the userName property
 * @return the value of the userName property
 */
std::string UserClass::UserName() {
	return userName;
}

/**
 * @brief Accessor method for all instances of Medication class
 * @return all instances of medication class
 */
std::vector<Medication> UserClass::Medications() {
	return medications;
}

/**
 * @brief Searches through instances of Medication for one which matches the supplied guid
 * @param guid the guid to search for
 * @return the matching Medication instance, or a blank one if it cannot be found
 */
Medication UserClass::Medications(std::string guid) {
	if (!medications.empty()) {
		for(int i = 0; i < medications.size(); i++) {
			if(medications[i].Guid() == guid) {
				return medications[i];
			}
		}
	}
	
	Medication* ptr;
	ptr = new Medication("Full Medical Name", "Short Name", "Perscribed Dosage",
						  "Maximum Dosage", "Initial Dosage Time", "Description",
						  "Guid", 0);
}

/**
 * @brief Mutator method for the userId property
 * @param NewUserId the new value for the userId property
 */
void UserClass::UserId(std::string NewUserId) {
	userId = NewUserId;
}

/**
 * @brief Mutator method for the userName property
 * @param NewUserName the new value for the userName property
 */
void UserClass::UserName(std::string NewUserName) {
	userName = NewUserName;
}

/**
 * @brief Used to add a single instance of the Medication class to the vector of instances
 * @param medsToAdd the single instance to add
 */
void UserClass::Medications(Medication medsToAdd) {
	medications.push_back(medsToAdd);
}

/**
 * @brief Used to add the contents of one vector of instances of the Medication class to the vector of instances within this class
 * @param medsToAdd the vector of instances to add
 */
void UserClass::Medications(std::vector<Medication> medsToAdd) {
	medications.insert(medications.end(), medsToAdd.begin(), medsToAdd.end());
}