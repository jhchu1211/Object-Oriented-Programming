
#include "pch.h"
#include "Header.h"
#include <iostream>
using namespace std;

void fill(int array[], int N)
{
	int max;
	max = 2 * N;// 2*N - 1 + 1
	for (int i = 0; i < N; i++)
	{
		array[i] = rand() % max;
	}
}

void print(int array[], int N, int M)
{
	for (int i = 0; i < N; i++)
	{
		cout << array[i] << "\t";
		if ((i+1) % (M) == 0)
		{
			cout << endl;
		}
	}
	cout << endl;
}

void sort(int array[], int N)
{
	int insert;
	for (int next = 1; next < N; next++)
	{
		insert = array[next];
		int moveItem = next;
		while ((moveItem > 0) && (array[moveItem - 1] > insert))
		{
			array[moveItem] = array[moveItem - 1];
			moveItem--;
		}
		array[moveItem] = insert;
	}
}

int search(int array[], int N, int e)
{
	int indexFound = -1;
	for(int i = 0; i < N; i++)
	{
		if(e == array[i])
		{
			indexFound = i;
			break; // exit loop
		}
	}
	if(indexFound == -1)
	{
		cout << "- ";
		return -1;
	}
	else
	{
		cout << "+ ";
		return indexFound;
	}
}

void result(int array[], int N)
{
	int max = 2 * N - 1;
	for (int i = 0; i <= max; i++)
	{
		search(array, N, i);
	}
	cout << endl;
}