// ConsoleApplication4.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#define _USE_MATH_DEFINES
#include <iostream>
#include <vector>
#include <cmath>
using namespace std;

class Shape
{
public: 
	double mSize = 0.0;
	virtual void SetSize(double tSize)
	{
		mSize = tSize;
	}
	virtual double GetArea() = 0;
};

class Square : public Shape
{
public: 
	virtual double GetArea()
	{
		return mSize * mSize;
	}
};

class Circle : public Shape
{
public: 
	virtual double GetArea()
	{
		return mSize * mSize * M_PI;
	}
};

void pause()
{
	cout << "Please press any key to continue" << endl;
	cin.ignore();
}

int main()
{
	vector<Shape*>tShapes;
	tShapes.push_back(new Square);
	tShapes.push_back(new Circle);
	tShapes.push_back(new Square);
	tShapes.push_back(new Circle);
	for (int i = 0; i < tShapes.size(); i++)
		tShapes[i]->SetSize(i);
	for (int i = 0; i < tShapes.size(); i++)
		cout << tShapes[i]->GetArea() << endl;
	pause();
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
