// GENERAR LIBRERÍA DINÁNIMCA DLL || WINDOWS (CONSULTAR PARA LINUX)
// Opción 1
// *** Eliminada (era más complicada).
// Opción 2
// gcc -shared -o string_database.dll string_database.c -fPIC
// gcc -o main main.c -L. -lstring_database

#include <stdio.h>
#include <stdlib.h>
#include "string_database.h"

int main() {
    // Crear una base de datos
    StringDatabase *db = create_database();
    if (!db) {
        return 1;
    }

    // Solicitar al usuario ingresar el nombre del archivo
    char filename[100];
    printf("Ingrese el nombre del archivo: ");
    scanf("%99s", filename);

    // Cargar las cadenas desde el archivo
    if (load_strings(filename, db) == NULL) {
        free_database(db);
        return 1;
    }

    // Solicitar al usuario ingresar la cadena de búsqueda
    char search_query[100];
    printf("Ingrese la cadena de busqueda: ");
    scanf("%99s", search_query);

    // Ordenar, limpiar y buscar la cadena en la base de datos
    sort_strings(db);
    remove_duplicates(db);
    remove_invalid_lengths(db);

    // Realizar la búsqueda y mostrar el resultado
    if (db->count == 0) {
        printf("ERROR: La lista quedo vacia despues de la limpieza.\n");
    } else {
        int index = binary_search(db, search_query);
        if (index != -1) {
            printf("EXISTE: Cadena encontrada en el indice %d: %s\n", index, db->strings[index]);
        } else {
            printf("NO EXISTE: Cadena no encontrada.\n");
        }
    }

    // Guardar la lista depurada en un archivo de texto
    save_strings("depurada.txt", db);
    printf("Lista depurada guardada en 'depurada.txt'\n");

    // Liberar la memoria utilizada por la base de datos
    free_database(db);

    return 0;
}
