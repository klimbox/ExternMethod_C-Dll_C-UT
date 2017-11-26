#include "Calc.h"
using namespace std;
double Calc(double fNum, double sNum, char op)
{
	double res;
	switch (op)
	{
	case '+':res = fNum + sNum; break;
	case '-':res = fNum - sNum; break;
	case '*':res = fNum * sNum; break;
	case '/':res = fNum / sNum; break;
	}
	return res;
}