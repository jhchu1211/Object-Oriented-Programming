// ConsoleApplication3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
using namespace std;

int product(int m, int n) {
	if (n == 1) {
		return m;
	}
	else {
		return product(m, n - 1) + m;
	}
}
void sum(double *aPtr, double *bPtr, double *cPtr) {
	double a; double b; double c;
	a = *bPtr + *cPtr;
	b = *aPtr + *cPtr;
	c = *aPtr + *bPtr;
	*aPtr = a; *bPtr = b; *cPtr = c;
}
void order(double &a, double &b, double &c) {
	double s = a;
	double m = b;
	double l = c;
	if ((a < c) && (a < b) && (c < b)) {
		cout << "a is the smallest" << endl;
		a = s;
		cout << "c is the second smallest" << endl;
		cout << "b is the third smallest" << endl;
		b = l; c = m;
	}
	else if ((a < c) && (a < b) && (c > b)) {
		cout << "a is the smallest" << endl;
		a = s;
		cout << "b is the second smallest" << endl;
		cout << "c is the third smallest" << endl;
		c = l; b = m; //switched the *&c and b
	}
	else if ((b < a) && (b < c) && (a < c)) {
		cout << "b is the smallest" << endl;
		a = m;
		cout << "a is the second smallest" << endl;
		cout << "c is the third smallest" << endl;
		b = s; c = l;
	}
	else if ((b < a) && (b < c) && (a > c)) {
		cout << "b is the smallest" << endl;
		a = m;
		cout << "c is the second smallest" << endl;
		cout << "a is the third smallest" << endl;
		b = l; c = s;
	}
	else if ((c < a) && (c < b) && (a < b)) {
		cout << "c is the smallest" << endl;
		a = l;
		cout << "a is the second smallest" << endl;
		cout << "b is the third smallest" << endl;
		b = s; c = m;
	}
	else if ((c < a) && (c < b) && (a > b)) {
		cout << "c is the smallest" << endl;
		a = l;
		cout << "b is the second smallest" << endl;
		cout << "a is the third smallest" << endl;
		b = m; c = s;	
	}
}
int main() {
	cout << "JONATHAN CHU" << endl;
	int m; int n;
	cout << "====Step 1: call product() that uses recursion ====" << endl;
	cout << "Enter m, n: "; cin >> m >> n;
	cout << "product(" << m<< ", " << n << ") = " << product(m, n) << endl;
	cout << endl;
	cout << "====Step 2: call sum() that uses pointers ====" << endl;
	double a; double b; double c;
	cout << "Enter a, b, c: "; cin >> a >> b >> c;
	cout << "a = " << a << ", b = " << b << ", c = " << c << endl;
	sum(&a, &b, &c);
	cout << "After call to sum(): a = " << a << ", b = " << b << ", c = " << c << endl;
	cout << endl;
	cout << "====Step 3: call order() that uses references ====" << endl;
	cout << endl;
	for (int i = 0; i < 6; i++) {
		cout << "Enter a, b, c: "; cin >> a >> b >> c;
		cout << "a = " << a << ", b = " << b << ", c = " << c << endl;
		order(a, b, c);
		cout << "After call to order(): a = " << a << ", b = " << b << ", c = " << c << endl;
		cout << endl;
	}
	system("pause");
	return 0;
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
