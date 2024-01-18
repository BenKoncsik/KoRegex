
# KoRegex Program README

## English Version

### Overview
KoRegex is a C# based file processing utility designed to apply regex (regular expression) based modifications to files in a specified directory. It allows users to define custom regex patterns and replacements, making it versatile for various text processing needs.

### How to Use
1. **Source Directory (`-path` or `-p`)**: Specify the directory where the program will perform file operations. Usage: `-path [directory path]` or `-p [directory path]`.
2. **Output Directory (`-o` or `-output`)**: Specify the target directory for the program's output. If left empty, the output will default to a Debug subdirectory within the source directory. Usage: `-o [directory path]` or `-output [directory path]`. 
3. **Regex Name Selection (`-rn` or `-regexname`)**: This new switch allows the user to select a specific regex pattern from the provided JSON file by its name. If the specified name does not exist, the user must manually choose from the available options. Usage: `-rn [regex name]` or `-regexname [regex name]`. 
4. **Regex JSON File (`-regexjson` or `-rj`)**: Define the path to a JSON file containing regex patterns and replacements. Usage: `-regexjson [file path]` or `-rj [file path]`.
5. **Silent Mode (`-s` or `-silent`)**: When included in the command arguments, this switch enables the silent mode, which suppresses all console outputs during the build process. This is useful when running the program from a .csproj file, as it prevents the display of non-error messages. Usage: `-s` or `-silent`.

The program reads the specified JSON file to determine the regex patterns to apply to the files in the source directory.

## Hungarian Version

### �ttekint�s
A KoRegex egy C# alap� f�jl-feldolgoz� eszk�z, amely regex (regul�ris kifejez�sek) alap� m�dos�t�sokat hajt v�gre a megadott k�nyvt�r f�jljain. Lehet�v� teszi a felhaszn�l�k sz�m�ra, hogy testreszabott regex mint�kat �s cser�ket defini�ljanak, �gy sokoldal�an haszn�lhat� k�l�nb�z� sz�vegfeldolgoz�si ig�nyekhez.

### Haszn�lat
1. **Forr�sk�nyvt�r (`-path` vagy `-p`)**: Adja meg azt a k�nyvt�rat, ahol a program a f�jlm�veleteket v�gzi. Haszn�lat: `-path [k�nyvt�r �tvonala]` vagy `-p [k�nyvt�r �tvonala]`.
2. **Kimeneti K�nyvt�r (`-o` vagy `-output`)**: Adja meg a program kimeneti adatainak k�nyvt�r�t. Ha �resen hagyja, az alap�rtelmezett kimenet a forr�sk�nyvt�r Debug almapp�j�ba ker�l. Haszn�lat: `-o [k�nyvt�r �tvonala]` vagy `-output [k�nyvt�r �tvonala]`.
3. **Regex N�v Kiv�laszt�sa (`-rn` vagy `-regexname`)**: Ez az �j kapcsol� lehet�v� teszi a felhaszn�l� sz�m�ra, hogy a megadott JSON f�jlb�l a regex mint�k k�z�l egy adott nev�t v�lasszon ki. Ha a megadott n�v nem l�tezik, a felhaszn�l�nak manu�lisan kell v�lasztania a rendelkez�sre �ll� opci�k k�z�l. Haszn�lat: `-rn [regex n�v]` vagy `-regexname [regex n�v]`.
4. **Regex JSON F�jl (`-regexjson` vagy `-rj`)**: Hat�rozza meg a regex mint�kat �s cser�ket tartalmaz� JSON f�jl �tvonal�t. Haszn�lat: `-regexjson [f�jl �tvonala]` vagy `-rj [f�jl �tvonala]`.
1. **Csendes M�d (`-s` vagy `-silent`)**: Ha a parancs argumentumai k�z�tt szerepel, ez a kapcsol� enged�lyezi a csendes m�dot, ami elnyom minden konzol kimenetet a build folyamat sor�n. Ez hasznos, ha a programot egy .csproj f�jlb�l ind�tj�k, mivel megakad�lyozza a nem hiba�zenetek megjelen�t�s�t. Haszn�lat: `-s` vagy `-silent`. 

A program olvassa a megadott JSON f�jlt, hogy meghat�rozza a forr�sk�nyvt�r f�jljaira alkalmazand� regex mint�kat.
