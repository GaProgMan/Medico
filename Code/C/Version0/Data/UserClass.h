/**
  * UserClass.h
  * @author Jamie "GaProgMan" Taylor
  * @version 0.1
  */

#ifndef USERCLASS_H
#define USERCLASS_H
#include "Medication.h"

// so that we can use the string datatype
#include <string>
// instances of the Medication class will be stored in a vector
#include <vector>

class UserClass
{
public:
	UserClass();
	UserClass(std::string newUserId, std::string newUserName, std::vector<Medication> newMeds);
	~UserClass();
	
	// Mutator methods
	void UserName(std::string newUserName);
	void UserId(std::string newUserId);
	void Medications(Medication medsToAdd);
	void Medications(std::vector<Medication> medsToAdd);
	
	// Accessor methods
	std::string UserName();
	std::string UserId();
	std::vector<Medication> Medications();
	Medication Medications(std::string guid);
	
	// Debug Code
	std::string ToString();
	
private:
	std::string userName;
	std::string userId;
	std::vector<Medication> medications;

};

#endif // USERCLASS_H
