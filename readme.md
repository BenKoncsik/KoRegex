
# KoRegex Program README

## English Version

### Overview
KoRegex is a C# based file processing utility designed to apply regex (regular expression) based modifications to files in a specified directory. It allows users to define custom regex patterns and replacements, making it versatile for various text processing needs.

### How to Use
1. **Source Directory (`-path` or `-p`)**: Specify the directory where the program will perform file operations. Usage: `-path [directory path]` or `-p [directory path]`.
2. **Output Directory (-o or -output)**: Specify the target directory for the program's output. If left empty, the output will default to a Debug subdirectory within the source directory. Usage: `-o [directory path]` or `-output [directory path]`. 
3. **Regex JSON File (`-regexjson` or `-rj`)**: Define the path to a JSON file containing regex patterns and replacements. Usage: `-regexjson [file path]` or `-rj [file path]`.

The program reads the specified JSON file to determine the regex patterns to apply to the files in the source directory.

## Hungarian Version

### Áttekintés
A KoRegex egy C# alapú fájl-feldolgozó eszköz, amely regex (reguláris kifejezések) alapú módosításokat hajt végre a megadott könyvtár fájljain. Lehetõvé teszi a felhasználók számára, hogy testreszabott regex mintákat és cseréket definiáljanak, így sokoldalúan használható különbözõ szövegfeldolgozási igényekhez.

### Használat
1. **Forráskönyvtár (`-path` vagy `-p`)**: Adja meg azt a könyvtárat, ahol a program a fájlmûveleteket végzi. Használat: `-path [könyvtár útvonala]` vagy `-p [könyvtár útvonala]`.
3.**Kimeneti Könyvtár (-o vagy -output)**: Adja meg a program kimeneti adatainak könyvtárát. Ha üresen hagyja, az alapértelmezett kimenet a forráskönyvtár Debug almappájába kerül. Használat: `-o [könyvtár útvonala]` vagy `-output [könyvtár útvonala]`.
2. **Regex JSON Fájl (`-regexjson` vagy `-rj`)**: Határozza meg a regex mintákat és cseréket tartalmazó JSON fájl útvonalát. Használat: `-regexjson [fájl útvonala]` vagy `-rj [fájl útvonala]`.

A program olvassa a megadott JSON fájlt, hogy meghatározza a forráskönyvtár fájljaira alkalmazandó regex mintákat.
