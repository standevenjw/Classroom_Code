/*
  Homework 5
  Programmed by: James Standeven
  Date: Oct 15, 2012
*/

#ifndef DAYOFYEAR_H
#define DAYOFYEAR_H

#include <string>
using namespace std;

class DayOfYear {
private:
	int numOfDay;
	static string Jan;
	static string Feb;
	static string Mar;
	static string Apr;
	static string May;
	static string Jun;
	static string Jul;
	static string Aug;
	static string Sep;
	static string Oct;
	static string Nov;
	static string Dec;
public:
	DayOfYear(int input) {
		numOfDay = input;
	}

	void print();
};

#endif
