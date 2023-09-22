
import java.io.File;
import mcxml.MCXML;

class Example {

    public static void main(String[] args) {
        // For IDEs, 'new File("lib_Java,Kotlin(All)").getAbsolutePath()' won't give you the correct location where
        // libmcxml64.dll and libmcxml64java.dll are located.
        MCXML.loop(new File("lib_Java,Kotlin(All)/").getAbsolutePath(), "<App width='800' height='600' >" +
                "<Label width='400' height='300' text='Thanks be to God.' background='#ffffff' />" +
                "</App>");
    }
}