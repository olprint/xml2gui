## XML to GUI Framework (v0.8.1)

### Dedicated to Our Lady of La Salette :one:

### Welcome!
* [x] C/C++ ![C/C++ 64 bit](https://img.shields.io/badge/64bit-229342)
    ![C/C++ 32 bit](https://img.shields.io/badge/32bit-97C900)
* [x] C# ![C# universal](https://img.shields.io/badge/CS-Universal-287DCC)
* [x] Java/Kotlin ![Java/Kotlin universal](https://img.shields.io/badge/Jar-Universal-287DCC)
* [x] Python ![Python 3.12 64 bit](https://img.shields.io/badge/v3.12-64bit-229342)
    ![Python 3.11 64 bit](https://img.shields.io/badge/v3.11-64bit-229342)
    ![Python 3.10 64 bit](https://img.shields.io/badge/v3.10-64bit-229342)
    ![Python 3.9 64 bit](https://img.shields.io/badge/v3.9-64bit-229342)
    ![Python 3.8 64 bit](https://img.shields.io/badge/v3.8-64bit-229342)
    ![Python 3.7 64 bit](https://img.shields.io/badge/v3.7-64bit-229342)
    ![Python 3.6 64 bit](https://img.shields.io/badge/v3.6-64bit-229342)
    <!---![Python 3.12 32 bit](https://img.shields.io/badge/v3.12-32bit-97C900)
    ![Python 3.11 32 bit](https://img.shields.io/badge/v3.11-32bit-97C900)
    ![Python 3.10 32 bit](https://img.shields.io/badge/v3.10-32bit-97C900)
    ![Python 3.9 32 bit](https://img.shields.io/badge/v3.9-32bit-97C900)
    ![Python 3.8 32 bit](https://img.shields.io/badge/v3.8-32bit-97C900)
    ![Python 3.7 32 bit](https://img.shields.io/badge/v3.7-32bit-97C900)
    ![Python 3.6 32 bit](https://img.shields.io/badge/v3.6-32bit-97C900)-->

![C](https://gitlab.com/olprint/xml2gui/-/raw/main/Windows/images/ic_c.png)
![C++](https://gitlab.com/olprint/xml2gui/-/raw/main/Windows/images/ic_cpp.png)
![C#](https://gitlab.com/olprint/xml2gui/-/raw/main/Windows/images/ic_csharp.png)
![Java](https://gitlab.com/olprint/xml2gui/-/raw/main/Windows/images/ic_java.png)
![Kotlin](https://gitlab.com/olprint/xml2gui/-/raw/main/Windows/images/ic_kotlin.png)
![Python](https://gitlab.com/olprint/xml2gui/-/raw/main/Windows/images/ic_python.png)
---
#### Programs built with xml2gui
[Calculator](https://gitlab.com/simple-gui/xml2gui-calculator)  
[Clock](https://gitlab.com/simple-gui/xml2gui-clock)  
[Scientific Clock](https://gitlab.com/simple-gui/xml2gui-scientific-clock)  
[Saints](https://gitlab.com/simple-gui/xml2gui-saints)  
[Birthday Gift](https://gitlab.com/simple-gui/xml2gui-birthday-gift)  
[Deathday Gift](https://gitlab.com/simple-gui/xml2gui-deathday-gift)  
[Bible](https://gitlab.com/simple-gui/xml2gui-bible)  
[Twitter](https://gitlab.com/simple-gui/xml2gui-twitter)  
[Blender 2D](https://gitlab.com/simple-gui/xml2gui-blender-2d)  
[Visual Studio Code Clone](https://gitlab.com/simple-gui/xml2gui-v-s-code-clone)  
[Google Chrome Clone](https://gitlab.com/simple-gui/xml2gui-google-chrome-clone)  
[Adverts](https://gitlab.com/simple-gui/xml2gui-adverts)  

---
A simple C/C++ program would look like this:
```c
int main() {
    // ...
    return 0;
}
```
Now let us introduce xml2gui:
```c
#include "../include/mcxml.h"
int main() {
    // ...
    mcxml_loop("PASS_YOUR_XML_HERE");
    return 0;
}
```
PASS_YOUR_XML_HERE should be an XML data like the one below:

```xml
<?xml version="1.0" encoding="utf-8"?>
<App
        id="app"
        width="800"
        height="600"
        background="#111111"
        text="Hail Mary"
>
    
    <!-- For widgets (i.e. App excluded), width, height, left, right, -->
    <!-- top, bottom, center, and ...Offset support calculations. -->
    <Image
            id="input"
            width="300"
            height="300"
            center=". | app"
            top="2*y-y | input,input"
            src="Z:/images/1.png"
            actions="click | drag"
            order="1"
    />
    <!-- For List, Tree, Table, Chart, pass a JSON file or text to src. -->
</App>
```
You are free to use the xml above!  
But make sure you have something else in ```src="YOUR_IMAGE_HERE"``` since you don't have the image Z:/images/1.png.

---
#### Screenshot

![Screenshot1](https://gitlab.com/olprint/xml2gui/-/raw/main/sh1.png)

---
#### Widgets
- Scroll
- Label
- Button
- Image
- Input
- Editor
- List
- Web
- Tree
- Table
- Check
- Chart
- Progress
- Choice
---

#### Data for Image, List, Tree, Table & Chart
`src="..."` is available for passing data to widgets.  
Image: `src="IMAGE_HERE"`
- PNG
- JPG
- SVG
- GIF

List: `src="JSON_HERE"`
```json
{
    "ANYTHING0": {
        "icon": "",
        "value": "Apple"
    },
    "ANYTHING1": {
        "icon": "",
        "value": "Box"
    }
}
```

Tree: `src="JSON_HERE"`
```json
{
    "ANYTHING0": {
        "icon": "",
        "value": "Folder1/MyMusic.mp3"
    },
    "ANYTHING1": {
        "icon": "",
        "value": "Folder1/MyMusicAbout.txt"
    }
}
```

Table: `src="JSON_HERE"`
```json
{
    "ANYTHING0": {
        "value": "1|Jesus|My Brother"
    },
    "ANYTHING1": {
        "value": "2|Mary|My Mother"
    }
}
```

Chart: `src="JSON_HERE"`
```json
{
    "ANYTHING0": {
        "label": "A",
        "value": "80",
        "color": "red"
    },
    "ANYTHING1": {
        "label": "B",
        "value": "81",
        "color": "green"
    }
}
```

Choice: `src="JSON_HERE"`
```json
{
    "ANYTHING0": {
        "value": "Apple"
    },
    "ANYTHING1": {
        "value": "Box"
    }
}
```

#### Options
<b>*</b> *App* doesn't support options.  
Options in the value are separated with vertical bars.  
<sup>1</sup> <u>Options by direction</u>.  
width = center of app.
- <b>&lt;</b> left
- <b>&gt;</b> right
- <b>^</b> top
- <b>v</b> bottom
- <b>.</b> center

<sup id='byQuery'>2</sup> <u>Options by query</u>.  
width = width of app.
- <b>x</b> abscissa
- <b>y</b> ordinate
- <b>w</b> width
- <b>h</b> height

<sup>3</sup> Options by query.  
width = width of app * 2/3.

<sup>4</sup> Options by <u>direction</u>.  
**Pivot the other end and** left = center of app.

<sup>5</sup> Options by query.  
**Do not pivot and** left = x of app.

<sup>6</sup> Options by query.  
**Pivot the other end and** left = x of app * 2/3.

<sup>7</sup> Check type.  
Use the same value to link Check widgets together.

---

#### XML Attributes
| Attribute      | Application   | Example                                                                                                                                   |
|----------------|---------------|-------------------------------------------------------------------------------------------------------------------------------------------|
| id             | All           | id="myId1"                                                                                                                                |
| width          | All *         | width="100"<br/><sup>1</sup>width=". \| app"<br/><sup>2</sup>width="w \| app"<br/><sup>3</sup>width="w * 2/3 \| app"                      |
| height         | All *         | ↑                                                                                                                                         |
| widthMin       | App           | widthMin="100"                                                                                                                            |
| heightMin      | App           | ↑                                                                                                                                         |
| widthMax       | App           | ↑                                                                                                                                         |
| heightMax      | App           | ↑                                                                                                                                         |
| fullscreen     | App           | fullscreen="true"<br/>fullscreen="false"                                                                                                  |
| text           | All           | text="Christlike"                                                                                                                         |
| hint           | Widgets       | ↑                                                                                                                                         |
| textColor      | Widgets       | textColor="#ff0000"<br/>textColor="#ff0000 \| #ffff00"                                                                                    |
| hintColor      | Widgets       | ↑                                                                                                                                         |
| background     | All           | textColor="#ff0000"                                                                                                                       |
| textSize       | Widgets       | textSize="18"                                                                                                                             |
| left           | Widgets       | left="100"<br/><sup>4</sup>left=". \| app \| true"<br/><sup>5</sup>left="x \| app \| false"<br/><sup>6</sup>left="x * 2/3 \| app \| true" |
| right          | Widgets       | ↑                                                                                                                                         |
| top            | Widgets       | ↑                                                                                                                                         |
| bottom         | Widgets       | ↑                                                                                                                                         |
| center         | Widgets       | center="50,50"<br/>center=". \| app"<br/>center="x,y \| app,app"                                                                          |
| leftOffset     | Widgets       | [Options by query](#byQuery)                                                                                                              |
| rightOffset    | Widgets       | ↑                                                                                                                                         |
| topOffset      | Widgets       | ↑                                                                                                                                         |
| bottomOffset   | Widgets       | ↑                                                                                                                                         |
| type           | Widgets       | type="text"<br/>type="password"<br/>type="int"<br/>type="float"<br/>type="bar"<br/>type="pie"<br/><sup>7</sup>type="12"                  |
| visible        | Widgets       | visible="true"<br/>visible="false"                                                                                                        |
| cursor         | All           | [Explained here](#cursor1)                                                                                                                |
| actions        | Widgets       | [Explained here](#actions1)                                                                                                               |
| src            | Image         | src="./sand.png"<br/>src="./a.png \| ./b.png"                                                                                             |
| selection      | Input, Editor | selection="12"<br/>selection="12\|15"                                                                                                     |
| selectionColor | Input, Editor | selectionColor="#9999ff"                                                                                                                  |
| wrap           | Editor        | wrap="true"<br/>wrap="false"                                                                                                              |
| editable       | Editor      | editable="true"<br/>editable="false"                                                                                                       |
| order          | Widgets       | order="1"                                                                                                                                 |
| logFile        | App           | logFile="Z:/logs/123.txt"                                                                                                                 |
| progress       | Progress      | progress="0.0"<br/>progress="100.0"                                                                                                       |
---

<span id='API'></span>
### API
```cpp
// Basic
const char* mcxml_version();
bool mcxml_add_widget(const char* widget, const char* idNew, const char* idDest);
bool mcxml_remove_widget(const char* id);
const char* mcxml_measure_text(const char* text, int fontSize);
void mcxml_select(const char* id);
const char* mcxml_selected();
int mcxml_lastCount();
void mcxml_logFile(const char* value);
void mcxml_repeat(void (*ptr)(), float sec);
void mcxml_started(void (*ptr)());
void mcxml_stopped(void (*ptr)());
bool mcxml_loop(const char* xml);
void mcxml_exit();

// Listeners
void mcxml_listener_click(void (*ptr)(const char* id, const char* m));
void mcxml_listener_dbclick(void (*ptr)(const char* id, const char* m));
void mcxml_listener_hover(void (*ptr)(const char* id, const char* m));
void mcxml_listener_drag(void (*ptr)(const char* id, const char* m));
void mcxml_listener_keyboard(void (*ptr)(const char* id, const char* m));
void mcxml_listener_resize(void (*ptr)(const char* id, const char* m));
void mcxml_listener_file(void (*ptr)(const char* id, const char* m));

void mcxml_listener_for_list(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_web(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_tree(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_table(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_check(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_chart(void (*ptr)(const char* id, const char* m));
void mcxml_listener_for_choice(void (*ptr)(const char* id, const char* m));

// Setters
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
void mcxml_set_selection(const char* id, const char* value);
void mcxml_set_selectionColor(const char* id, const char* value);
void mcxml_set_progress(const char* id, const char* value);
void mcxml_set_editable(const char* id, const char* value);
void mcxml_set(); // Needs to be called after other set operations.

// Getters
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
const char* mcxml_get_order(const char* id);
const char* mcxml_get_selection(const char* id);
const char* mcxml_get_selectionColor(const char* id);
int mcxml_get_progress(const char* id);
int mcxml_get_editable(const char* id);

// List
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

// Table
void mcxml_table_item_add(const char* id, const char* itemIcon, const char* value);
void mcxml_table_item_modify_icon(const char* id, const char* itemIcon, int pos);
void mcxml_table_item_modify_value(const char* id, const char* value, int pos);
const char* mcxml_table_item_get(const char* id, int pos);
void mcxml_table_item_remove(const char* id, int pos);
int mcxml_table_item_position(const char* id, const char* value);
void mcxml_table_item_insert(const char* id, const char* itemIcon, const char* value, int pos);
void mcxml_table_item_select(const char* id, int pos);
int* mcxml_table_item_selected(const char* id);
int mcxml_table_item_count(const char* id);

// Tree
void mcxml_tree_item_add(const char* id, const char* itemIcon, const char* value);
void mcxml_tree_item_modify_icon(const char* id, const char* itemIcon, int pos);
void mcxml_tree_item_modify_value(const char* id, const char* value, int pos);
const char* mcxml_tree_item_get(const char* id, int pos);
void mcxml_tree_item_remove(const char* id, int pos);
int mcxml_tree_item_position(const char* id, const char* value);
void mcxml_tree_item_select(const char* id, int pos);
int* mcxml_tree_item_selected(const char* id);
int mcxml_tree_item_count(const char* id);

// Web
bool mcxml_web_find_first(const char* id, const char* value);
bool mcxml_web_find_last(const char* id, const char* value);
bool mcxml_web_find_prev(const char* id, const char* value);
bool mcxml_web_find_next(const char* id, const char* value);

// Check
void mcxml_check_item_select(const char* id, bool check);
bool mcxml_check_item_selected(const char* id);

// Chart
void mcxml_chart_item_add(const char* id, const char* itemIcon, const char* value);
void mcxml_chart_item_modify_value(const char* id, const char* value, int pos);
void mcxml_chart_item_insert(const char* id, const char* itemIcon, const char* value, int pos);
int mcxml_chart_item_count(const char* id);
void mcxml_chart_item_bounds(const char* id, double min, double max);

// Choice
void mcxml_choice_item_add(const char* id, const char* itemIcon, const char* value);
void mcxml_choice_item_modify_value(const char* id, const char* value, int pos);
const char* mcxml_choice_item_get(const char* id, int pos);
void mcxml_choice_item_remove(const char* id, int pos);
int mcxml_choice_item_position(const char* id, const char* value);
void mcxml_choice_item_insert(const char* id, const char* itemIcon, const char* value, int pos);
void mcxml_choice_item_select(const char* id, int pos);
int* mcxml_choice_item_selected(const char* id);
int mcxml_choice_item_count(const char* id);

```

### Documentation
#### Basic


| Function            | Description                                                                                                                                                                                                                          |
|---------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| mcxml_version       | Get the version of this library.<br/>Return: Library version.                                                                                                                                                                        |
| mcxml_add_widget    | Add a new widget.<br/>- **widget** The widget type to add.<br/>- **idNew** A unique id to identify the widget.<br/>- **idDest** The id of App or the id of any Scroll widget.<br/>Return: true if successful, false if unsuccessful. |
| mcxml_remove_widget | Remove a widget.<br/>- **id** A widget id.<br/>Return: true if successful, false if unsuccessful.                                                                                                                                    |
| mcxml_measure_text  | Get the width and height of a text.                                                                                                                                                                                                  |
| mcxml_select        | Select a widget.                                                                                                                                                                                                                     |
| mcxml_selected      | Get the selected widget.                                                                                                                                                                                                             |
| mcxml_lastCount     | If 'int*' is returned by any function, mcxml_lastCount will hold its size.                                                                                                                                                           |
| mcxml_logFile       | Output errors to a file.                                                                                                                                                                                                             |
| mcxml_repeat        | Pass a function to be called every N seconds. Cancel with nullptr.                                                                                                                                                                   |
| mcxml_started       | Pass a function to be called after the app has initialized.                                                                                                                                                                          |
| mcxml_stopped       | Pass a function to be called when the app is just about to exit.                                                                                                                                                                     |
| mcxml_loop          | Start the app.<br/>- **xml** XML/MCXML to run.<br/>Return: true if successful, false if unsuccessful.                                                                                                                                |
| mcxml_exit          | Close the app.                                                                                                                                                                                                                       |

---
#### Listeners

| Function                  | Description                                                                                                                                                                                                                                   |
|---------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| mcxml_listener_click      | Called when any listening widget is clicked.<br/>A click widget listener can be set in the xml/mcxml with actions="click"<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }.                 |
| mcxml_listener_dbclick    | Called when any listening widget is double clicked.<br/>A double click widget listener can be set in the xml/mcxml with actions="dbclick"<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }. |
| mcxml_listener_hover      | Called when any listening widget is hovered.<br/>A hover widget listener can be set in the xml/mcxml with actions="hover"<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }.                 |
| mcxml_listener_drag       | Called when any listening widget is dragged.<br/>A drag widget listener can be set in the xml/mcxml with actions="drag"<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }.                   |
| mcxml_listener_keyboard   | When this global listener is set, all key events will be directed to it.<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }.                                                                  |
| mcxml_listener_resize     | When this global listener is set, any App resize will be directed to it.<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }.                                                                  |
| mcxml_listener_for_list   | Called when any List widget is interacted with.                                                                                                                                                                                               |
| mcxml_listener_for_web    | Called when any Web widget is interacted with.                                                                                                                                                                                                |
| mcxml_listener_for_tree   | Called when any Tree widget is interacted with.                                                                                                                                                                                               |
| mcxml_listener_for_table  | Called when any Table widget is interacted with.                                                                                                                                                                                              |
| mcxml_listener_for_check  | Called when any Check widget is interacted with.                                                                                                                                                                                                  |
| mcxml_listener_for_chart  | Called when any Chart widget is interacted with.                                                                                                                                                                                              |
| mcxml_listener_for_choice | Called when any Choice widget is interacted with.                                                                                                                                                                                             |

---
#### Setters

| Function                              | Description                                                                                                                                                                                                                                                                                                               |
|---------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| mcxml_set_width                       | Set the width of a widget or App.<br/>- **id** A widget or App id.<br/>- **value** The value to be set.                                                                                                                                                                                                                   |
| mcxml_set_height                      | Set the height of a widget or App.<br/>- **id** A widget or App id.<br/>- **value** The value to be set.                                                                                                                                                                                                                  |
| mcxml_set_widthMin                    | Set the width of App.<br/>- **id** The id of App.<br/>- **value** The value to be set. Does not support bar separated values.                                                                                                                                                                                             |
| mcxml_set_heightMin                   | Set the height of App.<br/>- **id** The id of App.<br/>- **value** The value to be set. Does not support bar separated values.                                                                                                                                                                                            |
| mcxml_set_widthMax                    | Set the width of App.<br/>- **id** The id of App.<br/>- **value** The value to be set. Does not support bar separated values.                                                                                                                                                                                             |
| mcxml_set_heightMax                   | Set the height of App.<br/>- **id** The id of App.<br/>- **value** The value to be set. Does not support bar separated values.                                                                                                                                                                                            |
| mcxml_set_left                        | Set the left position of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                                                         |
| mcxml_set_right                       | Set the right position of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                                                        |
| mcxml_set_top                         | Set the top position of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                                                          |
| mcxml_set_bottom                      | Set the bottom position of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                                                       |
| mcxml_set_center                      | Set the center position of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                                                       |
| mcxml_set_leftOffset                  | Set the left offset of a widget.<br/>This will only be set when 'left' is set.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                             |
| mcxml_set_rightOffset                 | Set the right offset of a widget.<br/>This will only be set when 'right' is set.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                           |
| mcxml_set_topOffset                   | Set the top offset of a widget.<br/>This will only be set when 'top' is set.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                               |
| mcxml_set_bottomOffset                | Set the bottom offset of a widget.<br/>This will only be set when 'bottom' is set.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                         |
| mcxml_set_background                  | Set the background color of a widget or App.<br/>- **id** A widget or App id.<br/>- **value** The value to be set.                                                                                                                                                                                                        |
| mcxml_set_text                        | Set the text of a widget or the title of App.<br/>- **id** A widget or App id.<br/>- **value** The value to be set.                                                                                                                                                                                                       |
| mcxml_set_hint                        | Set the hint of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                                                                  |
| mcxml_set_textColor                   | Set the text color of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set. Supports bar separated values.                                                                                                                                                                                             |
| mcxml_set_hintColor                   | Set the hint color of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set. Supports bar separated values.                                                                                                                                                                                             |
| mcxml_set_textSize                    | Set the text size of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                                                             |
| mcxml_set_type                        | Set the input type of Input.<br/>- **id** The id.<br/>- **value** The value to be set.                                                                                                                                                                                                                                    |
| mcxml_set_visible                     | Set the visibility of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                                                            |
| mcxml_set_fullscreen                  | Make App fullscreen.<br/>- **id** The id of App.<br/>- **value** The value to be set.                                                                                                                                                                                                                                     |
| mcxml_set_src                         | Set the image of Image.<br/>- **id** The id.<br/>- **value** The value to be set. Supports bar separated values.                                                                                                                                                                                                          |
| <span id='actions1'>mcxml_set_actions | Set listeners on a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set. Supports bar separated values.                                                                                                                                                                                                  |
| <span id='cursor1'>mcxml_set_cursor   | Set the cursor type of a widget or App.<br/>- **id** A widget or App id.<br/>- **value** The value to be set. Available values: default, none, insert, hand, drag, cross, help, load, ew (i.e. East-West), ns (i.e. North-South), ne (i.e. North-East), sw (i.e. South-West), nw (i.e. North-West), se (i.e. South-East). |
| mcxml_set_autoFit                     | Neglect the width and height and make the widget fit to its text or image.                                                                                                                                                                                                                                                |
| mcxml_set_from                        | Use attributes of another widget as basis.                                                                                                                                                                                                                                                                                |
| mcxml_set                             | Commit modifications made.                                                                                                                                                                                                                                                                                                |

---
#### Getters

| Function                  | Description                                                                                                                                 |
|---------------------------|---------------------------------------------------------------------------------------------------------------------------------------------|
| mcxml_get_width           | Get the width of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The width set to a widget or App.                            |
| mcxml_get_height          | Get the height of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The height set to a widget or App.                          |
| mcxml_get_left            | Get the left of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The left set to a widget or App.                              |
| mcxml_get_right           | Get the right of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The right set to a widget or App.                            |
| mcxml_get_top             | Get the top of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The top set to a widget or App.                                |
| mcxml_get_bottom          | Get the bottom of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The bottom set to a widget or App.                          |
| mcxml_get_center          | Get the center of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The center set to a widget or App.                          |
| mcxml_get_background      | Get the background color of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The background color set to a widget or App.      |
| mcxml_get_text            | Get the text of a widget or the title of App.<br/>- **id** A widget or App id.<br/>Return: The text set to a widget or the title of App.    |
| mcxml_get_hint            | Get the hint of a widget.<br/>- **id** A widget id.<br/>Return: The hint set to a widget.                                                   |
| mcxml_get_textColor       | Get the text color of a widget.<br/>- **id** A widget id.<br/>Return: The text color set to a widget. Supports bar separated values.        |
| mcxml_get_hintColor       | Get the hint color of a widget.<br/>- **id** A widget id.<br/>Return: The hint color set to a widget. Supports bar separated values.        |
| mcxml_get_textSize        | Get the text size of a widget.<br/>- **id** A widget id.<br/>Return: The text size set to a widget.                                         |
| mcxml_get_type            | Get the input type of Input.<br/>- **id** The id.<br/>Return: The input type set to Input.                                                  |
| mcxml_get_visible         | Get the visibility of a widget.<br/>- **id** A widget id.<br/>Return: The visibility set to a widget.                                       |
| mcxml_get_src             | Get the image of Image.<br/>- **id** The id.<br/>Return: Images set to Image. Supports bar separated values.                                |
| mcxml_get_actions         | Get listeners of a widget.<br/>- **id** A widget id.<br/>Return: Widget listeners of a widget or an empty string if there is no action set. |
| mcxml_get_cursor          | Get the cursor type of a widget or App.                                                                                                     |
| mcxml_get_cursor_position | Get the position of the cursor.                                                                                                             |
| mcxml_get_autoFit         | Get the auto fit value of a widget.                                                                                                         |
| mcxml_get_from            | Get the ID of the widget used as a basis.                                                                                                   |
| mcxml_get_order        | Get the order of a widget.                                                                             |

---
#### Text Editor

| Function                        | Description                               |
|---------------------------------|-------------------------------------------|
| mcxml_set_selection      | Set the insert position or the selection. |
| mcxml_set_selectionColor | Set the selection color.                  |
| mcxml_get_selection      | Get the insert position or the selection. |
| mcxml_get_selectionColor | Get the selection color.                  |
---
*Others are quite intuitive. Check the API section [above](#API).* 

---
**Please build apps for Jesus and Mary.**

---
