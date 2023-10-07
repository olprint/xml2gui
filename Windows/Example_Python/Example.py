
"""
---------- Dedicated to Mary our mother in spirit, and to her son Jesus our brother in spirit.
---------- Just like Adam and Eve. A new beginning...
"""

import sys
sys.path.append('./')

import xml2gui as g

xml = """
<App
    id="app"
    width="800"
    height="600"
    >
    <Button
        id="input"
        width="200"
        height="40"
        center=".|app"
        actions="click|dbclick"
        text="We thank God for the day."
        background="#111111"
        textColor="#eeeeee"
        />
</App>
"""
# The button and not the app registered for clicks and double clicks: actions="click|dbclick".


def listener_click(id, msg):
    print(f"CLICK   id: {id}, msg: {msg}")
    
    
def listener_dbclick(id, msg):
    print(f"DBCLICK id: {id}, msg: {msg}")
    
    
def listener_hover(id, msg):
    print(f"HOVER   id: {id}, msg: {msg}")
    
    
def listener_drag(id, msg):
    print(f"DRAG    id: {id}, msg: {msg}")
    
    
def listener_keyboard(id, msg):
    print(f"KEYBOARD    id: {id}, msg: {msg}")
    
    
def listener_resize(id, msg):
    print(f"RESIZE  id: {id}, msg: {msg}")


g.mcxml_listener_click(listener_click)
g.mcxml_listener_dbclick(listener_dbclick)
# g.mcxml_listener_hover(listener_hover)
# g.mcxml_listener_drag(listener_drag)
# g.mcxml_listener_keyboard(listener_keyboard)
# g.mcxml_listener_resize(listener_resize)

g.mcxml_loop(xml);

