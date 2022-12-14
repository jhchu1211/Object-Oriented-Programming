// ConsoleApplication11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <cmath>
using namespace std;

unsigned long long factorial(int n) // factorial function
{
	unsigned long long answer;
	answer = 1;
	for (int i = 1; i <= n; i++)
	{
		answer *= i;
	}
	return answer;
}

double scale_angle(double degrees) // angle scale function
{
	int x = (int)(degrees / 360.0); // throws away the fractional portion
	// because x is defined as int, by including (int) we are telling compiler that it is ok to remove fraction.
	return degrees - x * 360;
}

double my_cos(double rad, double stop)
{
	double last_term;
	int termcount = 1;
	double answer = 1;
	do {
		
		last_term = (pow(rad, (2 * termcount)) / factorial(2 * termcount));
		if (termcount % 2 != 0)
		{
			last_term = -last_term;
		}
		answer = answer + last_term;
		termcount++;
	} while (abs(last_term) > stop && termcount < 10);
	cout << "number of terms in power series = " << termcount << endl;
	return answer;
}

double rad(double degrees)
{
	return (degrees * 3.14159265359) / 180.0;
}

int main()
{
    cout << "JONATHAN CHU \n"; 
	// part 1
	int numF; // number of factorials calcs
	cout << "===Part 1===" << endl;
	cout << "Please provide the amount of Factorial Calculations you would like to see: "; 
	cin >> numF;
	for (int i = 0; i <= numF - 1; i++)
	{
		cout << i << "! = " << factorial(i) << endl;
	}
	//part 2
	cout << "===Part 2===" << endl;
	cout << "Please provide the number of anles you'd like to scale: "; cin >> numF;
	//recycle numF
	double angle;
	for (int i = 0; i <= numF - 1; i++)
	{
		cout << "(" << i << ") Enter an angle in degrees to scale: "; cin >> angle;
		cout << "scale_angle(" << angle << ") = " << scale_angle(angle) << endl;
		cout << endl;
	}
	//part 3
	double rad1; // first radian conversion input
	cout << "===Part 3===" << endl;
	cout << "Please provide the number of angles you'd like to convert to radians: "; cin >> numF;
	//reuse numF
	for (int i = 0; i <= numF - 1; i++)
	{
		cout << "(" << i << ") Enter an angle in degrees to convert to radians: "; cin >> rad1;
		cout << rad1 << " degrees = " << rad(rad1) << " radians" << endl;
		cout << endl;
	}
	//part 4
	double rad2; // second radian conversion input
	double deg2; // second degree input
	double deg1; // initial degree input
	double stop;
	cout << "===Part 4===" << endl;
	cout << "Please provide the number of evaluations you would like to perform on cos(x): "; cin >> numF;
	//reuse numF
	for (int i = 0; i <= numF -1 ; i++)
	{
		cout << "(" << i << ") Enter x (in degrees) and a stop_value: "; cin >> deg1; cin >> stop;
		cout << "x = " << deg1 << ", stop_value = " << stop << endl;
		deg2 = scale_angle(deg1);
		rad2 = rad(deg2);
		cout << "my_cos(" << rad2 << ") = " << my_cos(rad2, stop) << endl;
		cout << "cos(" << rad2 << ") = " << cos(rad2) << endl;
		cout << endl;
	}
	system("pause");
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
