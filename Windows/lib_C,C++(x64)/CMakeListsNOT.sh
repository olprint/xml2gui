	mkdir -p build
	cp -r ./lib/* ./build
	cd ./build && \
	gcc -o Example.exe ../../Example.c -L'../lib' -lmcxml64 && ./Example.exe