// gcc -o test nuevo.c

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>

// Declaración de la estructura StringDatabase
typedef struct {
    char **strings;
    int count;
} StringDatabase;

// Función auxiliar para intercambiar dos cadenas
static void swap_strings(char **a, char **b) {
    char *temp = *a;
    *a = *b;
    *b = temp;
}

// Función auxiliar para dividir el arreglo y colocar el pivote en su posición correcta
static int partition(StringDatabase *db, int low, int high) {
    char *pivot = db->strings[high]; // Elegir el último elemento como pivote
    int i = low - 1; // Índice del elemento más pequeño

    for (int j = low; j <= high - 1; j++) {
        if (strcmp(db->strings[j], pivot) < 0) {
            i++;
            swap_strings(&db->strings[i], &db->strings[j]);
        }
    }

    swap_strings(&db->strings[i + 1], &db->strings[high]);
    return i + 1;
}

// Función principal de QuickSort
static void quick_sort(StringDatabase *db, int low, int high) {
    if (low < high) {
        int pivot_index = partition(db, low, high);

        // Ordenar las dos mitades separadamente
        quick_sort(db, low, pivot_index - 1);
        quick_sort(db, pivot_index + 1, high);
    }
}

// Función para ordenar las cadenas en la base de datos usando QuickSort
void sort_strings(StringDatabase *db) {
    quick_sort(db, 0, db->count - 1);
}

// Función para eliminar cadenas duplicadas en la base de datos utilizando una tabla hash
void remove_duplicates(StringDatabase *db) {
    bool *seen = (bool *)calloc(db->count, sizeof(bool));
    if (!seen) {
        perror("ERROR AL ASIGNAR MEMORIA");
        return;
    }

    int unique_count = 0; // Contador de cadenas únicas

    for (int i = 0; i < db->count; i++) {
        if (!seen[i]) {
            seen[i] = true;
            db->strings[unique_count++] = db->strings[i];
            
            for (int j = i + 1; j < db->count; j++) {
                if (strcmp(db->strings[i], db->strings[j]) == 0) {
                    seen[j] = true;
                }
            }
        }
    }

    db->count = unique_count;

    free(seen);
}

// Función para eliminar cadenas de longitud inválida en la base de datos
void remove_invalid_lengths(StringDatabase *db) {
    int valid_count = 0; // Contador de cadenas válidas

    for (int i = 0; i < db->count; i++) {
        int len = strlen(db->strings[i]);
        if (len == 8 || len == 14) {
            if (i != valid_count) {
                db->strings[valid_count] = db->strings[i];
            }
            valid_count++;
        } else {
            free(db->strings[i]);
        }
    }

    db->count = valid_count;
}

// Función para guardar las cadenas en un archivo de texto
void save_strings(const char *filename, StringDatabase *db) {
    FILE *file = fopen(filename, "w");
    if (!file) {
        perror("ERROR AL ABRIR EL ARCHIVO");
        return;
    }

    for (int i = 0; i < db->count; i++) {
        fprintf(file, "%s\n", db->strings[i]);
    }

    fclose(file);
}

// Función para cargar las cadenas desde un archivo de texto
StringDatabase* load_strings(const char *filename, StringDatabase *db) {
    FILE *file = fopen(filename, "r");
    if (!file) {
        perror("ERROR AL ABRIR EL ARCHIVO");
        return NULL;
    }

    db->count = 0;
    db->strings = NULL;

    char line[16];
    while (fgets(line, sizeof(line), file)) {
        line[strcspn(line, "\n")] = '\0';
        // Asignar memoria para una nueva cadena y agregarla a la base de datos
        db->strings = (char **)realloc(db->strings, (db->count + 1) * sizeof(char *));
        db->strings[db->count] = strdup(line);
        db->count++;
    }

    fclose(file);
    return db;
}

// Función para buscar una cadena en la base de datos
int binary_search(StringDatabase *db, const char *query) {
    int left = 0, right = db->count - 1;
    while (left <= right) {
        int mid = left + (right - left) / 2;
        int cmp = strcmp(db->strings[mid], query);
        if (cmp == 0) {
            return mid; // Encontrada
        } else if (cmp < 0) {
            left = mid + 1;
        } else {
            right = mid - 1;
        }
    }
    return -1; // No encontrada
}

// Inicializa y prepara una nueva base de datos en memoria dinámica, 
// devolviendo un puntero para su posterior uso.
StringDatabase* create_database() {
    StringDatabase *db = (StringDatabase *)malloc(sizeof(StringDatabase));
    if (db) {
        db->strings = NULL;
        db->count = 0;
    }
    return db;
}

// Función para liberar la memoria utilizada por la base de datos
void free_database(StringDatabase *db) {
    if (db) {
        for (int i = 0; i < db->count; i++) {
            free(db->strings[i]);
        }
        free(db->strings);
        free(db);
    }
}

// Verifica la validez del puntero de la base de datos
// Redimensiona dinámicamente la memoria para acomodar una cadena adicional
// Copia la cadena en la base de datos
// Actualiza el contador de cadenas en la base de datos
void add_string(StringDatabase *db, const char *str) {
    // Verificar si el puntero de la base de datos es válido (no es NULL)
    if (db) {
        // Redimensionar la matriz de punteros para acomodar una cadena adicional
        db->strings = (char **)realloc(db->strings, (db->count + 1) * sizeof(char *));
        
        // Verificar si la asignación de memoria fue exitosa
        if (db->strings) {
            // Copiar la cadena en la última posición de la matriz de punteros
            db->strings[db->count] = strdup(str);
            
            // Verificar si la copia de la cadena fue exitosa
            if (db->strings[db->count]) {
                // Incrementar el contador de cadenas en la base de datos
                db->count++;
            }
        }
    }
}

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
    printf("Ingrese la cadena de búsqueda: ");
    scanf("%99s", search_query);

    // Ordenar, limpiar y buscar la cadena en la base de datos
    sort_strings(db);
    remove_duplicates(db);
    remove_invalid_lengths(db);

    // Realizar la búsqueda y mostrar el resultado
    if (db->count == 0) {
        printf("ERROR: La lista quedó vacía después de la limpieza.\n");
    } else {
        int index = binary_search(db, search_query);
        if (index != -1) {
            printf("EXISTE: Cadena encontrada en el índice %d: %s\n", index, db->strings[index]);
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
