// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
using namespace std;
/*
Course: ECE 1310.05
Assignment: Project 10
Due date: 11/14/2019
Descripotion: to familiarize using 
arrays and practicing creating functions
*/

void fill(int array[], int N)
{
	int ans;
	cout << "Please enter numbers for the array: " << endl;
	for (int i = 0; i < N; i++)
	{
		cin >> ans;
		array[i] = ans;
	}
	cout << endl;
}

void fillEven(int array[], int N)
{
	cout << "An array has beeen filled with even numbers starting with 0" << endl;
	for (int i = 0; i < N; i++)
	{
		array[i] = i * 2;
	}
	cout << endl;
}

void print(int array[], int N)
{
	for (int i = 0; i < N; i++)
	{
		cout << array[i] << "\t";
		if ((i + 1) % 5 == 0)
		{
			cout << endl;
		}
	}
	cout << endl;
}

void multiply(int array[], int array2[], int N, int c)
{
	for (int i = 0; i < N; i++)
	{
		array2[i] = array[i] * c;
	}
	cout << endl;
}

void add(int array1[], int array2[], int sum[], int N)
{
	for (int i = 0; i < N; i++)
	{
		sum[i] = array1[i] + array2[i];
	}
	cout << endl;
}

int main()
{
	int p[100], q[100], r[100], s[100];
	cout << "Please enter an array size from 1-100: ";
	int N; cin >> N;
	fill(p, N);
	print(p, N);
	fillEven(q, N);
	print(q, N);
	cout << "Please enter a scalar value between 1-10 to multiply an array with: ";
	int c; cin >> c;
	multiply(p, r, N, c);
	print(r, N);
	add(p, q, s, N);
	print(s, N);
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
