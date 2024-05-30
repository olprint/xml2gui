/*
 * 21-10-2023
 */

namespace ConsoleApp1;

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


// [ComImport]
// [Guid("CAA80694-1A87-4BA6-BA8E-1C2CD99B46CA")]
class MCXML {
    
    // Basic
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_version();
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  bool mcxml_add_widget(string widget, string idNew, string idDest);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  bool mcxml_remove_widget(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_measure_text(string text, int fontSize);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_select(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_selected();
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_lastCount();
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_logFile(string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  bool mcxml_loop(string xml);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_exit();

    // Setters
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_width(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_height(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_widthMin(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_heightMin(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_widthMax(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_heightMax(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_left(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_right(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_top(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_bottom(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_center(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_leftOffset(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_rightOffset(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_topOffset(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_bottomOffset(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_background(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_text(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_hint(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_textColor(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_hintColor(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_textSize(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_type(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_visible(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_fullscreen(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_maximize(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_src(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_actions(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_autoFit(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_from(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_cursor(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_selection(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_selectionColor(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_progress(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_editable(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_scroll(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set_pixels(string id, IntPtr value, int width, int height, int depth);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_set(); // Needs to be called after other set operations.

    // Getters
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_get_width(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_get_height(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_get_left(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_get_right(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_get_top(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_get_bottom(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_center(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_get_background(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_text(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_hint(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_textColor(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_hintColor(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_get_textSize(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_type(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  bool mcxml_get_visible(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_src(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_actions(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  bool mcxml_get_autoFit(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_from(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_cursor(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_cursor_position();
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_order(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_selection(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_get_selectionColor(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  string mcxml_get_progress(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  string mcxml_get_editable(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  string mcxml_get_info(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  string mcxml_get_scroll(string id);

    // List
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_list_item_add(string id, string itemIcon, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_list_item_modify_icon(string id, string itemIcon, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_list_item_modify_value(string id, string value, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_list_item_get(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_list_item_remove(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_list_item_clear(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_list_item_position(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_list_item_insert(string id, string itemIcon, string value, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_list_item_select(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_list_item_selected(string id); // int*
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_list_item_count(string id);

    // Table
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_table_item_add(string id, string itemIcon, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_table_item_modify_icon(string id, string itemIcon, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_table_item_modify_value(string id, string value, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_table_item_get(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_table_item_remove(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_table_item_clear(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_table_item_position(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_table_item_insert(string id, string itemIcon, string value, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_table_item_select(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_table_item_selected(string id); // int*
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_table_item_count(string id);

    // Tree
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_tree_item_add(string id, string itemIcon, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_tree_item_modify_icon(string id, string itemIcon, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_tree_item_modify_value(string id, string value, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_tree_item_get(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_tree_item_remove(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_tree_item_clear(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_tree_item_position(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_tree_item_select(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_tree_item_selected(string id); // int*
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_tree_item_count(string id);

    // Web
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  bool mcxml_web_find_first(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  bool mcxml_web_find_last(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  bool mcxml_web_find_prev(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  bool mcxml_web_find_next(string id, string value);

    // Check
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_check_item_select(string id, bool check);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  bool mcxml_check_item_selected(string id);

    // Chart
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_chart_item_add(string id, string itemIcon, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_chart_item_modify_value(string id, string value, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_chart_item_clear(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_chart_item_insert(string id, string itemIcon, string value, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_chart_item_count(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_chart_item_bounds(string id, double min, double max);

    // Choice
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_choice_item_add(string id, string itemIcon, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_choice_item_modify_value(string id, string value, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_choice_item_get(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_choice_item_remove(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_choice_item_clear(string id);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_choice_item_position(string id, string value);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_choice_item_insert(string id, string itemIcon, string value, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  void mcxml_choice_item_select(string id, int pos);
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  IntPtr mcxml_choice_item_selected(string id); // int*
    [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] public static extern  int mcxml_choice_item_count(string id);

    
    private class Listeners {
        // Listeners
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_click(IntPtr fn);
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_dbclick(IntPtr fn);
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_hover(IntPtr fn);
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_drag(IntPtr fn);
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_keyboard(IntPtr fn);
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_resize(IntPtr fn);

        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_for_list(IntPtr fn);
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_for_web(IntPtr fn);
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_for_tree(IntPtr fn);
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_for_table(IntPtr fn);
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_for_check(IntPtr fn);
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_for_chart(IntPtr fn);
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_listener_for_choice(IntPtr fn);

        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_repeat(IntPtr fn, float sec); // FnVoid
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_started(IntPtr fn); // FnVoid
        [DllImport("libmcxml64.dll", CharSet = CharSet.Ansi)] [MethodImpl(MethodImplOptions.InternalCall)] public static extern void mcxml_stopped(IntPtr fn); // FnVoid
    }
    
    public delegate void FnStringString(string id, string msg);
    public delegate void FnVoid();
    
    public static void mcxml_listener_click(FnStringString fn) { Listeners.mcxml_listener_click(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_listener_dbclick(FnStringString fn) { Listeners.mcxml_listener_dbclick(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_listener_hover(FnStringString fn) { Listeners.mcxml_listener_hover(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_listener_drag(FnStringString fn) { Listeners.mcxml_listener_drag(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_listener_keyboard(FnStringString fn) { Listeners.mcxml_listener_keyboard(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_listener_resize(FnStringString fn) { Listeners.mcxml_listener_resize(Marshal.GetFunctionPointerForDelegate(fn)); }

    public static void mcxml_listener_for_list(FnStringString fn) { Listeners.mcxml_listener_for_list(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_listener_for_web(FnStringString fn) { Listeners.mcxml_listener_for_web(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_listener_for_tree(FnStringString fn) { Listeners.mcxml_listener_for_tree(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_listener_for_table(FnStringString fn) { Listeners.mcxml_listener_for_table(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_listener_for_check(FnStringString fn) { Listeners.mcxml_listener_for_check(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_listener_for_chart(FnStringString fn) { Listeners.mcxml_listener_for_chart(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_listener_for_choice(FnStringString fn) { Listeners.mcxml_listener_for_choice(Marshal.GetFunctionPointerForDelegate(fn)); }

    public static void mcxml_repeat(FnStringString fn, float sec) { Listeners.mcxml_repeat(Marshal.GetFunctionPointerForDelegate(fn), sec); }
    public static void mcxml_started(FnStringString fn) { Listeners.mcxml_started(Marshal.GetFunctionPointerForDelegate(fn)); }
    public static void mcxml_stopped(FnStringString fn) { Listeners.mcxml_stopped(Marshal.GetFunctionPointerForDelegate(fn)); }
}
