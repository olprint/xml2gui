
#include <stdio.h>
#include <stdbool.h>

const char* mcxml_version();
bool mcxml_add_widget(const char* widget, const char* idNew, const char* idDest);
bool mcxml_remove_widget(const char* id);
bool mcxml_loop(const char* xml);
void mcxml_exit();

void mcxml_listener_click(void (*ptr)(const char* id, const char* m));
void mcxml_listener_dbclick(void (*ptr)(const char* id, const char* m));
void mcxml_listener_hover(void (*ptr)(const char* id, const char* m));
void mcxml_listener_drag(void (*ptr)(const char* id, const char* m));
void mcxml_listener_keyboard(void (*ptr)(const char* id, const char* m));
void mcxml_listener_resize(void (*ptr)(const char* id, const char* m));

void mcxml_set_width(const char* id, const char* value);
void mcxml_set_height(const char* id, const char* value);
void mcxml_set_widthMin(const char* id, const char* value);
void mcxml_set_heightMin(const char* id, const char* value);
void mcxml_set_widthMax(const char* id, const char* value);
void mcxml_set_heightMax(const char* id, const char* value);
void mcxml_set_left(const char* id, const char* value);
void mcxml_set_right(const char* id, const char* value);
void mcxml_set_top(const char* id, const char* value);
void mcxml_set_bottom(const char* id, const char* value);
void mcxml_set_center(const char* id, const char* value);
void mcxml_set_leftOffset(const char* id, const char* value);
void mcxml_set_rightOffset(const char* id, const char* value);
void mcxml_set_topOffset(const char* id, const char* value);
void mcxml_set_bottomOffset(const char* id, const char* value);
void mcxml_set_background(const char* id, const char* value);
void mcxml_set_text(const char* id, const char* value);
void mcxml_set_hint(const char* id, const char* value);
void mcxml_set_textColor(const char* id, const char* value);
void mcxml_set_hintColor(const char* id, const char* value);
void mcxml_set_textSize(const char* id, const char* value);
void mcxml_set_inputType(const char* id, const char* value);
void mcxml_set_textAlign(const char* id, const char* value);
void mcxml_set_visible(const char* id, const char* value);
void mcxml_set_rotation(const char* id, const char* value);
void mcxml_set_fullscreen(const char* id, const char* value);
void mcxml_set_src(const char* id, const char* value);
void mcxml_set_actions(const char* id, const char* value);
void mcxml_set_cursor(const char* id, const char* value);
void mcxml_editor_set_caret(const char* id, int value);
void mcxml_set();

int mcxml_get_width(const char* id);
int mcxml_get_height(const char* id);
int mcxml_get_left(const char* id);
int mcxml_get_right(const char* id);
int mcxml_get_top(const char* id);
int mcxml_get_bottom(const char* id);
const char* mcxml_get_center(const char* id);
int mcxml_get_background(const char* id);
const char* mcxml_get_text(const char* id);
const char* mcxml_get_hint(const char* id);
const char* mcxml_get_textColor(const char* id);
const char* mcxml_get_hintColor(const char* id);
int mcxml_get_textSize(const char* id);
const char* mcxml_get_inputType(const char* id);
const char* mcxml_get_textAlign(const char* id);
bool mcxml_get_visible(const char* id);
const char* mcxml_get_rotation(const char* id);
const char* mcxml_get_src(const char* id);
const char* mcxml_get_actions(const char* id);
int mcxml_editor_get_caret(const char* id);
