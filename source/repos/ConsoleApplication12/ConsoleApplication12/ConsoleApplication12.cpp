// ConsoleApplication12.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <string>
using namespace std;
/*
Course: ECE 1310-05
Assignment: Project 007
Due date: 10/17/2019
Description: to become familiar with functions and struct.
also to re-write project 1 in a more complex manner.
*/

struct poly2_t
{
	double a;
	double b;
	double c;
}; // struture of second order polynomial

struct poly4_t
{
	double a;
	double b;
	double c;
	double d;
	double e;
}; // structure of a fourth order polynomial

poly2_t read_poly2(string p1)
{
	poly2_t p;
	cout << "Enter coefficients of " << p1 << ": ";
	cin >> p.a >> p.b >> p.c;
	return p;
} //input values for the second order polynomial

void print_poly2(string s1, poly2_t p)
{
	cout << s1;
	cout << "(" << p.a << ")x^2 + (" << p.b << ")x + (" << p.c << ")" << endl;
} // print second order polynomial


poly2_t sum_poly2(poly2_t p1, poly2_t p2)
{
	poly2_t ans;
	ans.a = p1.a + p2.a;
	ans.b = p1.b + p2.b;
	ans.c = p1.c + p2.c;
	return ans;
} //sum of 2 polynomials

poly4_t mult_poly2(poly2_t p1, poly2_t p2)
{
	poly4_t ans;
	ans.a = p1.a * p2.a;
	ans.b = (p1.a * p2.b) + (p1.b * p2.a);
	ans.c = (p1.a * p2.c) + (p2.a * p1.c) + (p1.b * p2.b);
	ans.d = (p1.b * p2.c) + (p1.c * p2.b);
	ans.e = p1.c * p2.c;
	return ans;
} // creates fourth orrder polynomial

void print_poly4(string s1, poly4_t p)
{
	cout << s1;
	cout << "(" << p.a << ")x^4 + (" << p.b << ")x^3 + (" << p.c << ")x^2 + (" << p.d << ")x + (" << p.e << ")" << endl;
} // prints 1st fourth order polynomial

double eval_poly2(poly2_t p, double x)
{
	double answer;
	answer = p.a * (x * x) + p.b * (x) + p.c;
	return answer;
} // evaluate second order polynomials at x

double eval_poly4(poly4_t p, double x)
{
	double answer;
	answer = p.a *(x *x*x*x) + p.b * (x*x*x) + p.c * (x*x) + p.d * (x)+p.e;
	return answer;
} // evaluate fourth order polynomials at x

poly2_t diff_poly2(poly2_t p1, poly2_t p2)
{
	poly2_t ans;
	ans.a = p1.a - p2.a;
	ans.b = p1.b - p2.b;
	ans.c = p1.c - p2.c;
	return ans;
} // difference of both second order polynomails


int main()
{
	cout << "JONATHAN CHU" << endl;
	cout << endl;
	poly2_t polyone, polytwo;
	cout << "Part 1: Read coefficients of Polynomial 1" << endl;
	polyone = read_poly2("Polynomial 1");
	cout << endl;
	cout << "Part 2: Read coefficients of Polynomial 2" << endl;
	polytwo = read_poly2("Polynomial 2");
	double x;
	cout << endl;
	cout << "Part 3: Read value of x" << endl;
	cout << "Enter value of x to evaluate the polynomials: "; cin >> x;
	cout << endl;
	cout << "Part 4: Print polynomials and value of x" << endl;
	print_poly2("f1(x) = ", polyone);
	print_poly2("f2(x) = ", polytwo);
	cout << "Value of x = " << x << endl;
	cout << endl;
	cout << "Part 5: Print sum, difference, and product" << endl;
	poly2_t sum, dif; poly4_t prod;
	sum = sum_poly2(polyone, polytwo);
	dif = diff_poly2(polyone, polytwo);
	prod = mult_poly2(polyone, polytwo);
	print_poly2("sum(x) = ", sum);
	print_poly2("diff(x) = ", dif);
	print_poly4("prod(x) = ", prod);
	cout << endl;
	double ans1, ans2, ans3, ans4, ans5;
	ans1 = eval_poly2(polyone, x);
	ans2 = eval_poly2(polytwo, x);
	ans3 = eval_poly2(sum, x);
	ans4 = eval_poly2(dif, x);
	ans5 = eval_poly4(prod, x);
	cout << "f1(" << x << ") = " << ans1 << endl;
	cout << "f2(" << x << ") = " << ans2 << endl;
	cout << "sum(" << x << ") = " << ans3 << endl;
	cout << "diff(" << x << ") = " << ans4 << endl;
	cout << "prod(" << x << ") = " << ans5 << endl;

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
