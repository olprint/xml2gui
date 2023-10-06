#include <stdio.h>
#include <stdbool.h>

const char* mcxml_version();
bool mcxml_add_widget(const char* widget, const char* idNew, const char* idDest);
bool mcxml_remove_widget(const char* id);
const char* mcxml_measure_text(const char* text, int fontSize);
void mcxml_select(const char* id);
const char* mcxml_selected();
int mcxml_last_count();
bool mcxml_loop(const char* xml);
void mcxml_exit();

void mcxml_listener_click(void (*ptr)(const char* id, const char* m));
void mcxml_listener_dbclick(void (*ptr)(const char* id, const char* m));
void mcxml_listener_hover(void (*ptr)(const char* id, const char* m));
void mcxml_listener_drag(void (*ptr)(const char* id, const char* m));
void mcxml_listener_keyboard(void (*ptr)(const char* id, const char* m));
void mcxml_listener_resize(void (*ptr)(const char* id, const char* m));

void mcxml_listener_for_list(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_web(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_tree(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_table(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_check(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_chart(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_choice(void (*ptr)(const char* id, const char* m));

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
void mcxml_set_type(const char* id, const char* value);
void mcxml_set_visible(const char* id, const char* value);
void mcxml_set_fullscreen(const char* id, const char* value);
void mcxml_set_src(const char* id, const char* value);
void mcxml_set_actions(const char* id, const char* value);
void mcxml_set_autoFit(const char* id, const char* value);
void mcxml_set_from(const char* id, const char* value);
void mcxml_set_cursor(const char* id, const char* value);
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
const char* mcxml_get_type(const char* id);
bool mcxml_get_visible(const char* id);
const char* mcxml_get_src(const char* id);
const char* mcxml_get_actions(const char* id);
bool mcxml_get_autoFit(const char* id);
const char* mcxml_get_from(const char* id);
const char* mcxml_get_cursor(const char* id);
const char* mcxml_get_cursor_position();

void mcxml_editor_set_selection(const char* id, const char* value);
void mcxml_editor_set_selectionColor(const char* id, const char* value);
const char* mcxml_editor_get_selection(const char* id);
const char* mcxml_editor_get_selectionColor(const char* id);

void mcxml_list_item_add(const char* id, const char* itemIcon, const char* value);
void mcxml_list_item_modify_icon(const char* id, const char* itemIcon, int pos);
void mcxml_list_item_modify_value(const char* id, const char* value, int pos);
const char* mcxml_list_item_get(const char* id, int pos);
void mcxml_list_item_remove(const char* id, int pos);
int mcxml_list_item_position(const char* id, const char* value);
void mcxml_list_item_insert(const char* id, const char* itemIcon, const char* value, int pos);
void mcxml_list_item_select(const char* id, int pos);
int* mcxml_list_item_selected(const char* id);
int mcxml_list_item_count(const char* id);
