
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

### Áttekintés
A KoRegex egy C# alapú fájl-feldolgozó eszköz, amely regex (reguláris kifejezések) alapú módosításokat hajt végre a megadott könyvtár fájljain. Lehetõvé teszi a felhasználók számára, hogy testreszabott regex mintákat és cseréket definiáljanak, így sokoldalúan használható különbözõ szövegfeldolgozási igényekhez.

### Használat
1. **Forráskönyvtár (`-path` vagy `-p`)**: Adja meg azt a könyvtárat, ahol a program a fájlmûveleteket végzi. Használat: `-path [könyvtár útvonala]` vagy `-p [könyvtár útvonala]`.
2. **Kimeneti Könyvtár (`-o` vagy `-output`)**: Adja meg a program kimeneti adatainak könyvtárát. Ha üresen hagyja, az alapértelmezett kimenet a forráskönyvtár Debug almappájába kerül. Használat: `-o [könyvtár útvonala]` vagy `-output [könyvtár útvonala]`.
3. **Regex Név Kiválasztása (`-rn` vagy `-regexname`)**: Ez az új kapcsoló lehetõvé teszi a felhasználó számára, hogy a megadott JSON fájlból a regex minták közül egy adott nevût válasszon ki. Ha a megadott név nem létezik, a felhasználónak manuálisan kell választania a rendelkezésre álló opciók közül. Használat: `-rn [regex név]` vagy `-regexname [regex név]`.
4. **Regex JSON Fájl (`-regexjson` vagy `-rj`)**: Határozza meg a regex mintákat és cseréket tartalmazó JSON fájl útvonalát. Használat: `-regexjson [fájl útvonala]` vagy `-rj [fájl útvonala]`.
1. **Csendes Mód (`-s` vagy `-silent`)**: Ha a parancs argumentumai között szerepel, ez a kapcsoló engedélyezi a csendes módot, ami elnyom minden konzol kimenetet a build folyamat során. Ez hasznos, ha a programot egy .csproj fájlból indítják, mivel megakadályozza a nem hibaüzenetek megjelenítését. Használat: `-s` vagy `-silent`. 

A program olvassa a megadott JSON fájlt, hogy meghatározza a forráskönyvtár fájljaira alkalmazandó regex mintákat.
