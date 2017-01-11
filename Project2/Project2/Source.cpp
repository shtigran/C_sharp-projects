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
	// Получаем дескриптор соединения
	conn = mysql_init(NULL);
	if (conn == NULL)
	{
		// Если дескриптор не получен – выводим сообщение об ошибке
		fprintf(stderr, "Error: can'tcreate MySQL-descriptor\n");
		//exit(1); //Если используется оконное приложение
	}
	// Подключаемся к серверу
	if (!mysql_real_connect(conn, "localhost", "root", "root", "test", NULL, NULL, 0))
	{
		// Если нет возможности установить соединение с сервером 
		// базы данных выводим сообщение об ошибке
		fprintf(stderr, "Error: can'tconnecttodatabase %s\n", mysql_error(conn));
	}
	else
	{
		// Если соединение успешно установлено выводим фразу - "Success!"
		fprintf(stdout, "Success!\n");
	}
	// Закрываем соединение с сервером базы данных
	mysql_close(conn);

	system("Pause");
	return 0;
}