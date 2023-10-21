/*
 * 21-10-2023
 */

namespace ConsoleApp1 {

using System.Runtime.InteropServices;

class Example {
    private static string? CharArrayToString(IntPtr s) { return Marshal.PtrToStringAnsi(s); }

    private static void ListenerClick(string id, string msg) {
        if (msg != "up") return;
        switch (id) {
            case "l1":
                Console.Write("Version: ");
                Console.WriteLine(CharArrayToString(MCXML.mcxml_version()));
                break;
        }
    }

    public static void Main() {
        MCXML.mcxml_listener_click(ListenerClick);
        MCXML.mcxml_loop(@"
            <App
                id=""app""
                width=""800""
                height=""600""
                text=""Jesus, Mary &amp; Joseph."">
               
               <Label
                    id=""l1""
                    autoFit=""true""
                    center="".|app""
                    text=""Jesus, Mary &amp; Joseph.""
                    background=""black""
                    color=""white""
                    actions=""click""
                    />
            </App>
            ");
    }
}

}