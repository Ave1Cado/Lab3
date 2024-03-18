#include <iostream>

using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");

	int a, b;

	a = 1;
	b = 2;

	std::cout << "Значение переменной a: " << a << "Адрес переменной a: " << &a << std::endl;
	std::cout << "Значение переменной b: " << b << "Адрес переменной b: " << &b << std::endl;

	return 0;
}
