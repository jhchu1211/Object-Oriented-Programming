// ConsoleApplication10.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
using namespace std;
/*
Course: ECE 1310-05
Assignment: Project 5
Due Date: 10-3-19
To get familiar with switches, for statements and to have very fun
*/
int main()
{
	cout << "JONATHAN CHU" << endl;
	// begin the generate n random numbers m per line, use tab
	unsigned seed;
	int N, M, i;
	int n;//numeric value for srand
	cout << "Welcome to the random number generator. Please input the following." << endl;
	cout << "Enter seed value: "; cin >> seed;
	cout << "Enter N numbers to be printed: "; cin >> N;
	cout << "Enter M numbers per row: "; cin >> M;
	srand(seed);
	for (i = 1; i <= N; i++)
	{
		n = rand();
		cout << n << "\t\t";
		if (i % M == 0)
		{
			cout << endl;
		}
	}
	cout << endl;
	//begin dice problem
	cout << endl;
	cout << "Welcome the dice roll generator. Pleas press enter to continue." << endl;
	int d; // value of dice d
	for (i = 1; i <= 10; i++)
	{
		n = rand();
		d = n % 6 + 1;
		cout << d << endl;
	}
	cout << endl;
	//begin 10 random numbers/symbols
	int s; // random symbols
	cout << "Welcome the random generator, generating 2,5,8,11 randomly." << endl;
	cout << "Please press enter to continue." << endl;
	for (i = 1; i <= 10; i++)
	{
		n = rand();
		s = 2 + 3 * (n % 4);
		cout << s << endl;
	}
	cout << endl;
	double nP;//number of problems
	int o;// o for operation
	int so, si; // solution and solutioon input
	int v1, v2; // value 1 value 2
	double c = 0; // correct
	int st; // statement after problem is correct
	// begin how many math problems 
	cout << "Now lets do math problems." << endl;
	cout << "How many problems would you like to do? "; cin >> nP;
	for (i = 1; i <= nP; i++)
	{
		do
		{
			cout << "Which operation would you like to perform? 1 = (+) ; 2 = (-) ; 3 = (*) " << endl; cin >> o;
			if ((o < 1) || (o > 3))
			{
				cout << "Please input a valid response." << endl;
			}
		} while ((o < 1) || (o > 3));
		v1 = rand() % 10;
		v2 = rand() % 10;
		switch (o)
		{
		case 1:
			so = v1 + v2;
			cout << v1 << " + " << v2 << " = "; cin >> si; break;
		case 2:
			so = v1 - v2;
			cout << v1 << " - " << v2 << " = "; cin >> si; break;
		case 3:
			so = v1 * v2;
			cout << v1 << " * " << v2 << " = "; cin >> si; break;
		}
		st = rand() % 4;
		if (so == si)
		{
			switch (st)
			{
			case 0:
				cout << "Good Job!" << endl; break;
			case 1:
				cout << "Nice Work!" << endl; break;
			case 2:
				cout << "Fantastic!" << endl; break;
			case 3:
				cout << "Stellar Job!" << endl; break;
			}
			c++;
		}
		else
		{
			switch (st)
			{
			case 0:
				cout << "You'll get it next time!" << endl; break;
			case 1:
				cout << "Good Try!" << endl; break;
			case 2:
				cout << "It was a little off..." << endl; break;
			case 3:
				cout << "Not quite..." << endl; break;
			}
		}
		cout << "You have answered " << c << " correctly!" << endl;
	}
	double percent;
	percent = (c / nP) * 100;
	cout << "You scored a " << percent <<"%"<< endl;
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
