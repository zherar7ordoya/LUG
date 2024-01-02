#ifndef STRING_DATABASE_H
#define STRING_DATABASE_H

typedef struct {
    char **strings;
    int count;
} StringDatabase;

StringDatabase* create_database();
void free_database(StringDatabase *db);
void add_string(StringDatabase *db, const char *str);
void sort_strings(StringDatabase *db);
int binary_search(StringDatabase *db, const char *query);
void remove_duplicates(StringDatabase *db);
void remove_invalid_lengths(StringDatabase *db);
void save_strings(const char *filename, StringDatabase *db);
StringDatabase* load_strings(const char *filename, StringDatabase *db);

#endif
