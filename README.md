## XML to GUI Framework (v0.1.0)

### Welcome!
For now, we have libraries that you can link to dynamically.  
A simple C/C++ program would look like this:
```c
int main() {
    // ...
    return 0;
}
```
Now let us introduce xml2gui.
```c
int main() {
    // ...
    mcxml_loop("PASS_YOUR_XML_HERE");
    return 0;
}
```
PASS_YOUR_XML_HERE should be an xml data like the one below:

```xml
<?xml version="1.0" encoding="utf-8"?>
<App
	id="app"
	width="800"
	height="600"
	background="#111111"
	text="Hail Mary"
	>

	<Image
		id="input"
		width="300"
		height="300"
		center=". | app"
		src="Z:/images/1.png"
		actions="click | drag"
		/>
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
---

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

---

#### Attributes
| Attribute      | Application      | Example                                                                                                                                     |
|----------------|------------------|---------------------------------------------------------------------------------------------------------------------------------------------|
| id             | All              | id="myId1"                                                                                                                                  |
| width          | All * | width="100"<br/><sup>1</sup>width=". \| app"<br/><sup>2</sup>width="?w \| app"<br/><sup>3</sup>width="?w * 2/3 \| app"                      |
| height         | All * | ↑                                                                                                                                           |
| widthMin       | App              | widthMin="100"                                                                                                                              |
| heightMin      | App              | ↑                                                                                                                                           |
| widthMax       | App              | ↑                                                                                                                                           |
| heightMax      | App              | ↑                                                                                                                                           |
| fullscreen     | App              | fullscreen="true"<br/>fullscreen="false"                                                                                                    |
| text           | All              | text="Christlike"                                                                                                                           |
| hint           | Widgets          | ↑                                                                                                                                           |
| textColor      | Widgets          | textColor="#ff0000"<br/>textColor="#ff0000 \| #ffff00"                                                                                      |
| hintColor      | Widgets          | ↑                                                                                                                                           |
| background     | All              | textColor="#ff0000"                                                                                                                         |
| textSize       | Widgets          | textSize="18"                                                                                                                               |
| textAlign      | Input            | textAlign="left"<br/>textAlign="right"<br/>textAlign="center"                                                                               |
| inputType      | Input            | inputType="text"<br/>inputType="password"<br/>inputType="int"<br/>inputType="float"                                                         |
| left           | Widgets          | left="100"<br/><sup>4</sup>left=". \| app \| true"<br/><sup>5</sup>left="?x \| app \| false"<br/><sup>6</sup>left="?x * 2/3 \| app \| true" |
| right          | Widgets          | ↑                                                                                                                                           |
| top            | Widgets          | ↑                                                                                                                                           |
| bottom         | Widgets          | ↑                                                                                                                                           |
| center         | Widgets          | ↑                                                                                                                                           |
| leftOffset     | Widgets          | [Options by query](#byQuery)                                                                                                                |
| rightOffset    | Widgets          | ↑                                                                                                                                           |
| topOffset      | Widgets          | ↑                                                                                                                                           |
| bottomOffset   | Widgets          | ↑                                                                                                                                           |
| visible        | Widgets          | visible="true"<br/>visible="false"                                                                                                          |
| cursor         | All              | [Explained here](#cursor1)                                                                                                                  |
| actions        | Widgets          | [Explained here](#actions1)                                                                                                                 |
| src            | Image            | src="./sand.png"<br/>src="./a.png \| ./b.png"                                                                                               |
| selectionStart | Editor           | selectionStart="12"                                                                                                                         |
| selectionEnd   | Editor           | ↑                                                                                                                                           |
| wrap           | Editor           | wrap="true"<br/>wrap="false"                                                                                                                |
---

### API
```cpp
// Basic
const char* mcxml_version();
bool mcxml_add_widget(const char* widget, const char* idNew, const char* idDest);
bool mcxml_remove_widget(const char* id);
bool mcxml_loop(const char* xml);
void mcxml_exit();

// Listeners
void mcxml_listener_click(void (*ptr)(const char* id, const char* m));
void mcxml_listener_dbclick(void (*ptr)(const char* id, const char* m));
void mcxml_listener_hover(void (*ptr)(const char* id, const char* m));
void mcxml_listener_drag(void (*ptr)(const char* id, const char* m));
void mcxml_listener_keyboard(void (*ptr)(const char* id, const char* m));
void mcxml_listener_resize(void (*ptr)(const char* id, const char* m));

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
const char* mcxml_get_inputType(const char* id);
const char* mcxml_get_textAlign(const char* id);
bool mcxml_get_visible(const char* id);
const char* mcxml_get_rotation(const char* id);
const char* mcxml_get_src(const char* id);
const char* mcxml_get_actions(const char* id);
int mcxml_editor_get_caret(const char* id);
```

### Documentation
#### Basic


|Function| Description                                                                                                                                                                                                                         |
|--------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|mcxml_version| Get the version of this library.<br/>Return: Library version.                                                                                                                                                                        |
|mcxml_add_widget| Add a new widget.<br/>- **widget** The widget type to add.<br/>- **idNew** A unique id to identify the widget.<br/>- **idDest** The id of App or the id of any Scroll widget.<br/>Return: true if successful, false if unsuccessful. |
|mcxml_remove_widget| Remove a widget.<br/>- **id** A widget id.<br/>Return: true if successful, false if unsuccessful.                                                                                                                                    |
|mcxml_loop| Start the app.<br/>- **xml** XML/MCXML to run.<br/>Return: true if successful, false if unsuccessful.                                                                                                                                |
|mcxml_exit| Close the app.                                                                                                                                                                                                                      |

---
#### Listeners

|Function| Description                                                                                                                                                                                                                                                                                            |
|--------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|mcxml_listener_click| Called when any listening widget is clicked.<br/>A click widget listener can be set in the xml/mcxml with actions="click"<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }.                    |
|mcxml_listener_dbclick| Called when any listening widget is double clicked.<br/>A double click widget listener can be set in the xml/mcxml with actions="dbclick"<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }. |
|mcxml_listener_hover| Called when any listening widget is hovered.<br/>A hover widget listener can be set in the xml/mcxml with actions="hover"<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }.                        |
|mcxml_listener_drag| Called when any listening widget is dragged.<br/>A drag widget listener can be set in the xml/mcxml with actions="drag"<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }.                           |
|mcxml_listener_keyboard| When this global listener is set, all key events will be directed to it.<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }.                                                                                                                               |
|mcxml_listener_resize| When this global listener is set, any App resize will be directed to it.<br/>- **ptr** A function in the form void my_listener1(const char* id, const char* m){ /\*...\*/ }.                                                                                                                               |

---
#### Setters

| Function                                     | Description                                                                                                                                                                                                                                                                             |
|----------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| mcxml_set_width                              | Set the width of a widget or App.<br/>- **id** A widget or App id.<br/>- **value** The value to be set.                                                                                                                                                                                 |
| mcxml_set_height                             | Set the height of a widget or App.<br/>- **id** A widget or App id.<br/>- **value** The value to be set.                                                                                                                                                                                |
| mcxml_set_widthMin                           | Set the width of App.<br/>- **id** The id of App.<br/>- **value** The value to be set. Does not support bar separated values.                                                                                                                                                           |
| mcxml_set_heightMin                          | Set the height of App.<br/>- **id** The id of App.<br/>- **value** The value to be set. Does not support bar separated values.                                                                                                                                                          |
| mcxml_set_widthMax                           | Set the width of App.<br/>- **id** The id of App.<br/>- **value** The value to be set. Does not support bar separated values.                                                                                                                                                           |
| mcxml_set_heightMax                          | Set the height of App.<br/>- **id** The id of App.<br/>- **value** The value to be set. Does not support bar separated values.                                                                                                                                                          |
| mcxml_set_left                               | Set the left position of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                       |
| mcxml_set_right                              | Set the right position of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                      |
| mcxml_set_top                                | Set the top position of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                        |
| mcxml_set_bottom                             | Set the bottom position of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                     |
| mcxml_set_center                             | Set the center position of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                     |
| mcxml_set_leftOffset                         | Set the left offset of a widget.<br/>This will only be set when 'left' is set.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                            |
| mcxml_set_rightOffset                        | Set the right offset of a widget.<br/>This will only be set when 'right' is set.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                           |
| mcxml_set_topOffset                          | Set the top offset of a widget.<br/>This will only be set when 'top' is set.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                               |
| mcxml_set_bottomOffset                       | Set the bottom offset of a widget.<br/>This will only be set when 'bottom' is set.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                         |
| mcxml_set_background                         | Set the background color of a widget or App.<br/>- **id** A widget or App id.<br/>- **value** The value to be set.                                                                                                                                                                      |
| mcxml_set_text                               | Set the text of a widget or the title of App.<br/>- **id** A widget or App id.<br/>- **value** The value to be set.                                                                                                                                                                     |
| mcxml_set_hint                               | Set the hint of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                                |
| mcxml_set_textColor                          | Set the text color of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set. Supports bar separated values.                                                                                                                                                           |
| mcxml_set_hintColor                          | Set the hint color of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set. Supports bar separated values.                                                                                                                                                           |
| mcxml_set_textSize                           | Set the text size of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                           |
| mcxml_set_inputType                          | Set the input type of Input.<br/>- **id** The id.<br/>- **value** The value to be set.                                                                                                                                                                                                  |
| mcxml_set_textAlign                          | Set the text alignment of Input.<br/>- **id** The id.<br/>- **value** The value to be set.                                                                                                                                                                                              |
| mcxml_set_visible                            | Set the visibility of a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set.                                                                                                                                                                                          |
| mcxml_set_rotation                           | Set the rotation of Label.<br/>- **id** The id.<br/>- **value** The value to be set.                                                                                                                                                                                                    |
| mcxml_set_fullscreen                         | Make App fullscreen.<br/>- **id** The id of App.<br/>- **value** The value to be set.                                                                                                                                                                                                   |
| mcxml_set_src                                | Set the image of Image.<br/>- **id** The id.<br/>- **value** The value to be set. Supports bar separated values.                                                                                                                                                                        |
| <span id='actions1'></span>mcxml_set_actions | Set listeners on a widget.<br/>- **id** A widget id.<br/>- **value** The value to be set. Supports bar separated values.                                                                                                                                                                |
| <span id='cursor1'></span>mcxml_set_cursor   | Set the cursor type of a widget or App.<br/>- **id** A widget or App id.<br/>- **value** The value to be set. Available values: insert, hand, drag, ew (i.e. East-West), ns (i.e. North-South), ne (i.e. North-East), sw (i.e. South-West), nw (i.e. North-West), se (i.e. South-East). |
| mcxml_set                                    | Commit modifications made.                                                                                                                                                                                                                                                              |

---
#### Getters

|Function| Description |
|--------|-|
|mcxml_get_width|Get the width of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The width set to a widget or App.|
|mcxml_get_height|Get the height of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The height set to a widget or App.|
|mcxml_get_left|Get the left of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The left set to a widget or App.|
|mcxml_get_right|Get the right of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The right set to a widget or App.|
|mcxml_get_top|Get the top of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The top set to a widget or App.|
|mcxml_get_bottom|Get the bottom of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The bottom set to a widget or App.|
|mcxml_get_center|Get the center of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The center set to a widget or App.|
|mcxml_get_background|Get the background color of a widget or App.<br/>- **id** A widget or App id.<br/>Return: The background color set to a widget or App.|
|mcxml_get_text|Get the text of a widget or the title of App.<br/>- **id** A widget or App id.<br/>Return: The text set to a widget or the title of App.|
|mcxml_get_hint|Get the hint of a widget.<br/>- **id** A widget id.<br/>Return: The hint set to a widget.|
|mcxml_get_textColor|Get the text color of a widget.<br/>- **id** A widget id.<br/>Return: The text color set to a widget. Supports bar separated values.|
|mcxml_get_hintColor|Get the hint color of a widget.<br/>- **id** A widget id.<br/>Return: The hint color set to a widget. Supports bar separated values.|
|mcxml_get_textSize|Get the text size of a widget.<br/>- **id** A widget id.<br/>Return: The text size set to a widget.|
|mcxml_get_inputType|Get the input type of Input.<br/>- **id** The id.<br/>Return: The input type set to Input.|
|mcxml_get_textAlign|Get the text alignment of Input.<br/>- **id** The id.<br/>Return: The text alignment set to Input.|
|mcxml_get_visible|Get the visibility of a widget.<br/>- **id** A widget id.<br/>Return: The visibility set to a widget.|
|mcxml_get_rotation|Get the rotation of Label.<br/>- **id** The id.<br/>Return: The rotation set to Label.|
|mcxml_get_src|Get the image of Image.<br/>- **id** The id.<br/>Return: Images set to Image. Supports bar separated values.|
|mcxml_get_actions|Get listeners of a widget.<br/>- **id** A widget id.<br/>Return: Widget listeners of a widget or an empty string if there is no action set.|

---
#### Text Editor

|Function| Description                                                                          |
|--------|--------------------------------------------------------------------------------------|
|mcxml_editor_set_caret| Set insert position or selection.<br/>- **id** The id.<br/>- **value** The value to be set.  |
|mcxml_editor_get_caret| Get insert position or selection.<br/>- **id** The id.<br/>Return: The start position.    |


---
#### TODO
- [x] C/C++
- [x] Java/Kotlin
- [x] Python

---
**Please build apps for Jesus and Mary.**

---
