
/**
 * ---------- Dedicated to Mary our mother in spirit, and to her son Jesus our brother in spirit.
 * ---------- Just like Adam and Eve. A new beginning...
*/

import java.io.File;
import mcxml.MCXML;

class Example {
	static String xml =
		"<App" +
		"	id='app'" +
		"	width='800'" +
		"	height='600'" +
		"	>" +
		"	<Button" +
		"		id='input'" +
		"		width='200'" +
		"		height='40'" +
		"		center='.|app'" +
		"		actions='click|dbclick'" +
		"		text='We thank God for the day.'" +
		"		background='#111111'" +
		"		textColor='#eeeeee'" +
		"		/>" +
		"</App>";

    public static void main(String[] args) {
        // For IDEs, 'new File("./").getAbsolutePath()' won't give you the correct location where
        // libmcxml64.dll and libmcxml64java.dll are located.
        MCXML.loop(new File("./").getAbsolutePath(), xml);
    }
}
