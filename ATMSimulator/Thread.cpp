/*
 * ThreadATM.c
 *
 *
 *      Author: Elliot Kinkead
 *      Account Number: 118118
 *      Pin Number: 0118
 *
 *      Description: Mainly Pesudocode, But mostly implemeted
 */
#include <iostream>
#include <cstdlib>
using namespace std;

Public int StoreAcNumber 118118;
Public int StorePin 0118;
Public int StoreBalance 50;


void StageAccountCheck()
{
	int ACNumber; //Account Number
	int Pin; // Pin Number
	// Please enter account number and check if true or false. (Hard coded for now)

	cout << "Please enter your account number";
	cin >> ACNumber;

	// Enter Pin number

	cout << "Please enter your Pin Number";
	cin >> Pin;

	//Check if true or false.

	if (ACNumber = StoreAcNumber && Pin = StorePin)
	{
		cout << "Hello Your Name";
		StageMenu();

	}
	else
	{
		cout << "Youve entered incorect account number or Pin Number Please try again";
		StageAccountCheck();
	}

	// Rejected throw them to

	// Correct yeet them to Stage2

}

void StageMenu()
{
	int num;

	cout << "Please select an option";
	cout << "1 - Return Card";
	cout << "2 - Withdraw Cash";
	cout << "3 - Check your Balance";

	switch (num)
		case 1;
	cout << "Return Card"
		returnCard();

	case 2;
		cout << "Withdraw Cash"
			WithdrawMoney()

			case 3;
		cout << "Check Balance"

			// Add Invalid Input

}

void ReturnCard()
{
	cout << "Thank you for using Generic Bank";
	//ReturnCard
}

void WithdrawMoney()
{
	int num;

	cout << "How much should be Withdrawn";
	cout << "£10";
	cout << "£20";
	cout << "£40";
	cout << "£100";
	cout << "£500";

	switch (num)
		case 1;
	cout << "£10"
		returnCard();

	case 2;
		cout << "£20"
			WithdrawMoney()

			case 3;
		cout << "£40"

			case 3;
		cout << "£100"

			case 4;
		cout << "£500"

			// Add Invalid Input and chose



}

void BalanceWithdraw()
{
	//Check Balance and withdarw money
	if (StoreBalance < Withdraw)
	{

	}

	else
}#include "Thread.h"
