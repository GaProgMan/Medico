#include <iostream>
#include "Data/UserClass.h"

using namespace std;

/**
 * @brief Used to instanciate a UserClass object with one Medication object, then call the ToString() method on both
 */
void testMedicoClasses() {
	Medication* ptr;
	ptr = new Medication("Cocodemol", "Pain Meds", "2 pills, with food, every 4 hours",
						  "No more than 8 pills per day", "09:30",
						  "Oval shaped, grey pills with a 'C' on one side",
						  "Guid", 240);
	
	vector<Medication> medsVec;
	medsVec.clear();
	medsVec.push_back(*ptr);
	
	UserClass* usr;
	usr = new UserClass("gaProgMAn", "Jay Tay", medsVec);
	
	cout << usr->ToString() << endl;
}

void instanciateMedicationClass(UserClass* usr) {
	Medication* med = new Medication();
	
	string fullName;
	cout << "Please enter the full name of your medication: ";
	getline(cin, fullName);
	med->FullMedicalName(fullName);
	
}

UserClass* instanciateUserClass() {
	UserClass *usr = new UserClass();
	
	string userName;
	cout << "Please enter your user name: ";
	getline(cin, userName);
	
	string userId;
	cout << "Please enter your user ID: ";
	getline(cin, userId);
	
	usr->UserName(userName);
	usr->UserId(userId);
	
	return usr;
}

void instanciateMedicoClasses() {
	UserClass* usr = instanciateUserClass();
	cout << usr->ToString() << endl;
}

int main(int argc, char **argv)
{	
	//testMedicoClasses();
	instanciateMedicoClasses();
	return 0;
}