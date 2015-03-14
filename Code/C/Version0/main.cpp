#include <iostream>
#include "Data/UserClass.h"

using namespace std;

int main(int argc, char **argv)
{
	Medication* ptr;
	ptr = new Medication("Full Medical Name", "Short Name", "Perscribed Dosage",
						  "Maximum Dosage", "Initial Dosage Time", "Description",
						  "Guid", 0);
	
	vector<Medication> medsVec;
	medsVec.clear();
	medsVec.push_back(*ptr);
	
	UserClass* usr;
	usr = new UserClass("thing", "another thing", medsVec);
	
	cout << "UserId:\t" << usr->UserId() << endl;
	cout << "Medications -> Short Name:\t" << usr->Medications("Guid").ShortName() << endl;
	
	return 0;
}
