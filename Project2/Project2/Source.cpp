// 0.cpp : Defines the entry point for the console application.
//
#include "libmysql.lib"
#include <my_global.h>
#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <stdlib.h>
#include <winsock.h> 
#include <mysql.h>

using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	MYSQL *conn;
	// �������� ���������� ����������
	conn = mysql_init(NULL);
	if (conn == NULL)
	{
		// ���� ���������� �� ������� � ������� ��������� �� ������
		fprintf(stderr, "Error: can'tcreate MySQL-descriptor\n");
		//exit(1); //���� ������������ ������� ����������
	}
	// ������������ � �������
	if (!mysql_real_connect(conn, "localhost", "root", "root", "test", NULL, NULL, 0))
	{
		// ���� ��� ����������� ���������� ���������� � �������� 
		// ���� ������ ������� ��������� �� ������
		fprintf(stderr, "Error: can'tconnecttodatabase %s\n", mysql_error(conn));
	}
	else
	{
		// ���� ���������� ������� ����������� ������� ����� - "Success!"
		fprintf(stdout, "Success!\n");
	}
	// ��������� ���������� � �������� ���� ������
	mysql_close(conn);

	system("Pause");
	return 0;
}