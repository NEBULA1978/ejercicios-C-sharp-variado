// Alarma cronometro.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//
#include <iostream>
#include <thread>
#include <chrono>
#include <conio.h>

using namespace std; //para evitar poner abajo std::cout se pone using namespace std aqui
using namespace std::this_thread;
using namespace std::chrono;


int main() {
	int segundo=0;
	int minuto = 0;
	int hora = 0;
	int fin = 0;

	cout << "Ingrese la cantidad de tiempo a temporizar" << endl;
	cout << "Horas:";
	cin >> hora;
	cout << "Minutos";
	cin >> minuto;
	cout << "Segundos";
	cin >> segundo;


while (fin == 0) {
		system("cls"); //limpia pantalla y sale en mismo sitio todos los numero
		cout << "                               CRONOMETRO" << endl;
		cout << "                               " << hora << ":" << minuto << ":" << segundo << endl;
		sleep_for(seconds(1));
		segundo--;

		if (minuto == 0 && segundo == 0 && hora == 0) {
			fin = 1;
		}
		
		if (minuto == 0 && segundo == 0) {//cambiamos el oreden bucles para &&
			hora--;
			minuto = 59;
			segundo = 60;
		}
		
		
		
		if (segundo == 0) {
			minuto--;
			segundo = 60;
		}
		
	}
system("cls"); //limpia pantalla y sale en mismo sitio todos los numero
cout << "                               CRONOMETRO" << endl;
cout << "                               0:0:0" << endl;
	
_getch();
}
// Ejecutar programa: Ctrl + F5 o menú Depurar > Iniciar sin depurar
// Depurar programa: F5 o menú Depurar > Iniciar depuración

// Sugerencias para primeros pasos: 1. Use la ventana del Explorador de soluciones para agregar y administrar archivos
//   2. Use la ventana de Team Explorer para conectar con el control de código fuente
//   3. Use la ventana de salida para ver la salida de compilación y otros mensajes
//   4. Use la ventana Lista de errores para ver los errores
//   5. Vaya a Proyecto > Agregar nuevo elemento para crear nuevos archivos de código, o a Proyecto > Agregar elemento existente para agregar archivos de código existentes al proyecto
//   6. En el futuro, para volver a abrir este proyecto, vaya a Archivo > Abrir > Proyecto y seleccione el archivo .sln
