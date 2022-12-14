// ConsoleApplication13.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <iomanip>
using namespace std;

void display(unsigned reg)
{
	const int SHIFT = 8 * sizeof(unsigned) - 1; //constant values are defined by capital letters rip
 //if sizeof(unsigned) is 4 then SHIFT = 31
	const unsigned MASK = 1 << SHIFT; // starts off as 0.....0001 but shifts 31 to the left 1000.....0
	cout << setw(10) << reg << " = ";
	for (unsigned i = 1; i <= SHIFT + 1; i++) {
		cout << ((reg & MASK) ? '1' : '0'); // first time most significant bit is printed
		// all the bits except highest order bit in reg are masked
		reg <<= 1; // reg = reg << 1 (shift reg left by 1)
		if (i % 4 == 0)//output an underscore after bits
			cout << "_";
	}
	cout << endl;
}

unsigned get_operation_type(unsigned reg)
{
	const unsigned MASK = 0x0000000F; //only gets first four bits
	unsigned ans;
	ans = reg & MASK;
	return ans;
}

unsigned get_operand1(unsigned reg) {
	const unsigned MASK = 0x00007F00; // 0x tells C++ it is a hexadecimal number.
	   // 0000_0000_0000_0000_0111_1111_0000_0000
	unsigned ans;
	ans = reg & MASK;
	ans >>= 8;
	return ans;
} // get operand1

unsigned get_operand2(unsigned reg) 
{
	const unsigned MASK = 0x007F0000;
	// 0000_0000_0111_1111_0000_0000_0000_0000
	unsigned ans;
	ans = reg & MASK;
	ans >>= 16;
	return ans;
}

unsigned set_op_type(unsigned reg, unsigned operation_type)
{
	unsigned changed;
	const unsigned MASK = 0xFFFFFFF0;
	changed = reg & MASK;
	unsigned ans;
	ans = changed | operation_type;
	return ans;
}

unsigned set_op1(unsigned reg, unsigned operand1)
{
	operand1 <<= 8;
	unsigned changed;
	const unsigned MASK = 0xFFFF80FF;
	changed = reg & MASK;
	unsigned ans;
	ans = changed | operand1;
	return ans;
}

unsigned set_op2(unsigned reg, unsigned operand2)
{
	operand2 <<= 16;
	unsigned changed;
	const unsigned MASK = 0xFF80FFFF;
	changed = reg & MASK;
	unsigned ans;
	ans = changed | operand2;
	return ans;
}

int main()
{
	unsigned num, num_1, num_2, num_3;
	cout << "Please enter a positive integer: "; cin >> num;
	display(num);
	num_1 = get_operation_type(num); num_2 = get_operand1(num);
	num_3 = get_operand2(num);
	cout << endl;
	cout << "The following is the operation type, operand1, and operand 2 respectively: " << endl;
	display(num_1); display(num_2); display(num_3);
	cout << endl;
	cout << "Please enter a number between 0-15 to change operation type: ";
	unsigned number;
	cin >> number;
	num = set_op_type(num, number); //resets old value of num with new value of num
	display(num);
	cout << endl;
	cout << "Please enter a number between 0-127 to change operand1: ";
	cin >> number;
	num = set_op1(num, number);
	display(num);
	cout << endl;
	cout << "Please enter a value between 0-127 to change operand2: ";
	cin >> number;
	num = set_op2(num, number);
	display(num);
	cout << endl; //resets old values of op and uses new values entered+
	num_1 = get_operation_type(num); num_2 = get_operand1(num);
	num_3 = get_operand2(num);
	cout << endl;
	cout << "The following is the new operation type, operand1, and operand 2 respectively: " << endl;
	display(num_1); display(num_2); display(num_3);
	cout << endl;
	cout << "With these new values, we perform operations onto them" << endl;
	unsigned a, b, c, e, f, g;
	a = num_2 | num_3; display(a);
	b = num_2 & num_3; display(b);
	c = ~num_2; display(c);
	e = ~num_3 + 1; display(e); //two's complement
	//e = ~num_3; display(e); //inverted num_2 checked and good
	f = num_2 << 3; display(f);
	g = num_3 >> 6; display(g);
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
