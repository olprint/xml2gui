	mkdir -p build
	cp -r '../lib_C,C++(32)'/* ./build
	cd ./build && \
	gcc -o Example.exe ../Example.c -L'./' -lmcxml32 && ./Example.exe