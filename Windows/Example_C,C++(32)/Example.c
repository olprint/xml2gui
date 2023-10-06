/**
 * ---------- Dedicated to Mary our mother in spirit, and to her son Jesus our brother in spirit.
 * ---------- Just like Adam and Eve. A new beginning...
*/

#include "../include/mcxml.h"

void my_listener1(const char* id, const char* m){
	printf("\n\n--- Click ---\nid: %s\nmessage: %s", id, m);
}
void my_listener2(const char* id, const char* m){
	printf("\n\n--- Drag ---\nid: %s\nmessage: %s", id, m);
}

int main() {
	mcxml_listener_click(my_listener1);
	mcxml_listener_drag(my_listener2);
	
	mcxml_loop("<?xml version='1.0' encoding='utf-8'?> <App id='app' width='400' height='400' background='#111111' text='Hail Mary' > <Image id='input' width='300' height='300' center='. | app' src='../../images/my_image.png' actions='click | drag' cursor='drag' /> </App>");
	return 0;
}
