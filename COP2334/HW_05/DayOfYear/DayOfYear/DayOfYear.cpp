/*
  Homework 5
  Programmed by: James Standeven
  Date: Oct 15, 2012
*/

#include <iostream>
#include <string>
using namespace std;

#include "DayOfYear.h"

//Static member variables
string DayOfYear::Jan = "January ";
string DayOfYear::Feb = "February ";
string DayOfYear::Mar = "March ";
string DayOfYear::Apr = "April ";
string DayOfYear::May = "May ";
string DayOfYear::Jun = "June ";
string DayOfYear::Jul = "July ";
string DayOfYear::Aug = "August ";
string DayOfYear::Sep = "September ";
string DayOfYear::Oct = "October ";
string DayOfYear::Nov = "November ";
string DayOfYear::Dec = "December ";

//Member functions
void DayOfYear::print() {
	int jan = 31,
		feb = 28,
		mar = 31,
		apr = 30,
		may = 31,
		jun = 30,
		jul = 31,
		aug = 31,
		sep = 30,
		oct = 31,
		nov = 30,
		dec = 31;
	int days = 0;

	if(numOfDay <= jan) {
		cout << Jan << numOfDay << endl;
		days += 365;
	}
	else days += jan; 
	if(numOfDay > days && numOfDay <= (days + feb)) {
		cout << Feb << (numOfDay - days) << endl;
		days += 365;
	}
	else days += feb;
	if(numOfDay > days && numOfDay <= (days + mar)) {
		cout << Mar << (numOfDay - days) << endl;
		days += 365;
	}
	else days += mar;
	if(numOfDay > days && numOfDay <= (days + apr)) {
		cout << Apr << (numOfDay - days) << endl;
		days += 365;
	}
	else days += apr;
	if(numOfDay > days && numOfDay <= (days + may)) {
		cout << May << (numOfDay - days) << endl;
		days += 365;
	}
	else days += may;
	if(numOfDay > days && numOfDay <= (days + jun)) {
		cout << Jun << (numOfDay - days) << endl;
		days += 365;
	}
	else days += jun;
	if(numOfDay > days && numOfDay <= (days + jul)) {
		cout << Jul << (numOfDay - days) << endl;
		days += 365;
	}
	else days += jul;
	if(numOfDay > days && numOfDay <= (days + aug)) {
		cout << Aug << (numOfDay - days) << endl;
		days += 365;
	}
	else days += aug;
	if(numOfDay > days && numOfDay <= (days + sep)) {
		cout << Sep << (numOfDay - days) << endl;
		days += 365;
	}
	else days += sep;
	if(numOfDay > days && numOfDay <= (days + oct)) {
		cout << Oct << (numOfDay - days) << endl;
		days += 365;
	}
	else days += oct;
	if(numOfDay > days && numOfDay <= (days + nov)) {
		cout << Nov << (numOfDay - days) << endl;
		days += 365;
	}
	else days += nov;
	if(numOfDay > days && numOfDay <= (days + dec)){
		cout << Dec << (numOfDay - days) << endl;
	}
}
