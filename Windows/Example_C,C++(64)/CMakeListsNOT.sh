	mkdir -p build
	cp -r '../lib_C,C++(64)'/* ./build
	cd ./build && \
	gcc -o Example.exe ../Example.c -L'./' -lmcxml64 && ./Example.exe