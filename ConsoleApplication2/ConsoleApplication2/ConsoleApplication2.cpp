#include <iostream>

void print(int n) {
	if (n == 0)
		return;
	print(n - 1);
	std::cout << n << " ";
}

int main() {
	int n;
	std::cout << "N = ";
	std::cin >> n;
	return 0;
}