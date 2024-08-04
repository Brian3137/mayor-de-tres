//Poner nombres linbdos de variables
//Limpiar el codigo y ver que ande dspues de hacer cambios
//Ver que metodos agregar
//Hacer que se repita preguntando al usuario
//TIP: vistiar el ejecrico del mayor de 2 con repeticion que hicimos en la casa de pato para sacar ejemplos de metodos, retornos, void

Console.WriteLine("Mayor De Tres");

string linea = Console.ReadLine();
string linea2 = Console.ReadLine();
string linea3 = Console.ReadLine();

int numeroA = int.Parse(linea);
int numeroB = int.Parse(linea2);
int numeroC = int.Parse(linea3);


if (numeroA == numeroB && numeroB == numeroC){

    Console.WriteLine("IGUALES");
}
else{
    if(numeroA > numeroB && numeroB > numeroC) {
        Console.WriteLine(numeroA);

    }
    else {
        if (numeroB > numeroC) {
            Console.WriteLine(numeroB);
        }
        else {
            Console.WriteLine(numeroC);

        }
    }
}






