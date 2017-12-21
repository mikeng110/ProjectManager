import os
os.system("as -o src/main.o src/main.s")
os.system("gcc -o bin/main src/main.o")
os.system("./bin/main")
